using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGest
{
    public partial class HistorialPartidos : Form
    {
        string sCnn = Properties.Settings.Default.SportGestConnection;
        string titulares = "", suplentes = "";
        public HistorialPartidos()
        {
            InitializeComponent();
        }

        private void lblEquipoConvocado_Click(object sender, EventArgs e)
        {
            string[] tit = { "" }, sup = { "" };
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Partidos] WHERE Id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", listPartidos.SelectedItem.ToString().Split('-')[0].Trim());

                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //if (dr["Id"].ToString().Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                        tit = dr["titulares"].ToString().Split('|');
                        for (int j = 0; j < tit.Length; j++)
                        {
                            titulares += tit[j] + ",";
                        }
                        sup = dr["suplentes"].ToString().Split('|');
                        for (int j = 0; j < sup.Length; j++)
                        {
                            suplentes += sup[j] + ",";
                        }

                        MessageBox.Show(titulares.Substring(0, titulares.Length - 1) + "\r\n" + suplentes.Substring(0, suplentes.Length - 1), "Equipo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (NullReferenceException)
                {
                    //MessageBox.Show("Seleccionad un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void HistorialPartidos_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Equipos]", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbEquipo.Items.Add(dr["nombre"] + " - " + dr["categoria"]);
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void lblEstilo_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Partidos] WHERE Id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", listPartidos.SelectedItem.ToString().Split('-')[0].Trim());
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //    if (dr["Id"].ToString().Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                        MessageBox.Show("Ataque: " + dr["estilo_atq"] + "\r\nDefensa: " + dr["estilo_def"].ToString(), "Estilo de juego");
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (NullReferenceException)
                {
                    //MessageBox.Show("Seleccionad un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void lblPosicionamiento_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Partidos] WHERE Id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", listPartidos.SelectedItem.ToString().Split('-')[0].Trim());
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //    if (dr["Id"].ToString().Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                        MessageBox.Show("Ataque: " + dr["posicion_atq"] + "\r\nDefensa: " + dr["posicion_def"].ToString(), "Posicionamiento");
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (NullReferenceException)
                {
                    //MessageBox.Show("Seleccionad un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPartidos.Items.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {

                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Partidos]", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["condicion"].ToString().Equals("Local"))
                        {
                            if (cbEquipo.SelectedItem.ToString().Equals(dr["equipo_local"]))
                            {
                                listPartidos.Items.Add(dr["Id"] + " - " + dr["fecha"] + " - vs. " + dr["equipo_visitante"] + " - " + dr["competicion"]);
                            }
                        }
                        else
                        {
                            if (cbEquipo.SelectedItem.ToString().Equals(dr["equipo_visitante"]))
                            {
                                listPartidos.Items.Add(dr["Id"] + " - " + dr["fecha"] + " - vs. " + dr["equipo_local"] + " - " + dr["competicion"]);
                            }
                        }
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (NullReferenceException)
                {
                    //MessageBox.Show("Seleccionad un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void volverAlMenúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Partidos] WHERE Id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", listPartidos.SelectedItem.ToString().Split('-')[0].Trim());

                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //if (dr["Id"].ToString().Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                        lblFecha.Text = dr["fecha"].ToString();
                        if (dr["resultado"].ToString().Equals("VICTORIA"))
                        {
                            lblResultado.ForeColor = Color.DarkGreen;
                        }
                        else
                        {
                            lblResultado.ForeColor = Color.DarkRed;
                        }
                        lblResultado.Text = dr["resultado"].ToString() + " [" + dr["goles_local"] + "-" + dr["goles_visitante"] + "]";
                        lblEquipo.Text = cbEquipo.SelectedItem.ToString().Split('-')[0].Trim();
                        lblCategoria.Text = cbEquipo.SelectedItem.ToString().Split('-')[1].Trim();
                        if (dr["condicion"].ToString().Equals("Local"))
                        {
                            lblRival.Text = dr["equipo_visitante"].ToString();
                        }
                        else
                        {
                            lblRival.Text = dr["equipo_local"].ToString();
                        }
                        tbObservaciones.Text = dr["observaciones"].ToString();
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                catch (NullReferenceException)
                {
                    //MessageBox.Show("Seleccionad un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
