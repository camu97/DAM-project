using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGest
{
    public partial class HistorialPartidos : Form
    {
        string sCnn = Properties.Settings.Default.Conexion;
        string titulares = "", suplentes = "";
        public HistorialPartidos()
        {
            InitializeComponent();
        }

        private void lblEquipoConvocado_Click(object sender, EventArgs e)
        {
            string[] tit = { "" }, sup = { "" };
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Id"].ToString().Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                        {
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
                }
                catch (SqlException) { }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Seleccionad un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void HistorialPartidos_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    dt = equiposAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cbEquipo.Items.Add(dr["nombre"] + " - " + dr["categoria"]);
                    }

                }
                catch (SqlException) { }
                //catch (ConstraintException) { }
            }
        }

        private void lblEstilo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Id"].ToString().Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                        {
                            MessageBox.Show("Ataque: " + dr["estilo_atq"] + "\r\nDefensa: " + dr["estilo_def"].ToString(), "Estilo de juego");
                        }
                    }
                }
                catch (SqlException) { }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Seleccionad un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void lblPosicionamiento_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Id"].ToString().Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                        {
                            MessageBox.Show("Ataque: " + dr["posicion_atq"] + "\r\nDefensa: " + dr["posicion_def"].ToString(), "Posicionamiento");
                        }
                    }
                }
                catch (SqlException) { }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Seleccionad un partido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listPartidos.Items.Clear();
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
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
                catch (SqlException) { }
            }
        }

        private void volverAlMenúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Id"].ToString().Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                        {
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
                }
                catch (SqlException) { }
            }
        }
    }
}
