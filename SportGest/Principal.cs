using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SportGest
{
    public partial class Principal : Form
    {
        string sCnn = Properties.Settings.Default.SportGestConnection;
        public Principal()
        {
            InitializeComponent();
        }

        private void btnNuevoEntrenamiento_Click(object sender, EventArgs e)
        {
            Entrenamiento ent = new Entrenamiento();
            ent.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show
                ("¿Deseas abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.ShowDialog();

            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Notas]", connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        ListaMensajes.Items.Add(dr["id"].ToString() + " - " + dr["fecha"].ToString().Split(' ')[0] + " - " + dr["nota"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnAñadirNota_Click(object sender, EventArgs e)
        {
            if (tbNuevaNota.Text.Length != 0)
            {
                using (SQLiteConnection connection = new SQLiteConnection(sCnn))
                {

                    SQLiteCommand cmd = new SQLiteCommand("INSERT into [Notas] (fecha,nota) VALUES(@fecha,@nota)", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Now);
                    cmd.Parameters.AddWithValue("@nota", tbNuevaNota.Text);
                    try
                    {
                        connection.Open();
                        int fa = cmd.ExecuteNonQuery();
                        //MessageBox.Show(fa.ToString());


                        SQLiteCommand cmd2 = new SQLiteCommand("SELECT * FROM [Notas];", connection);
                        cmd2.CommandType = CommandType.Text;
                        SQLiteDataReader r = cmd2.ExecuteReader();
                        tbNuevaNota.Clear();
                        ListaMensajes.Items.Clear();
                        while (r.Read())
                        {
                            ListaMensajes.Items.Add(r["id"].ToString() + " - " + r["fecha"].ToString().Split(' ')[0] + " - " + r["nota"].ToString());
                        }
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        private void btnNuevoPartido_Click(object sender, EventArgs e)
        {
            Partido p = new Partido();
            p.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialEntrenamientos he = new HistorialEntrenamientos();
            he.ShowDialog();

        }

        private void btnGestionEquipo_Click(object sender, EventArgs e)
        {
            GestionEquipo ge = new GestionEquipo();
            ge.ShowDialog();
        }

        private void ListaMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] nota_mostrar = ListaMensajes.SelectedItem.ToString().Split('-');
                tbLeerNotas.Text = nota_mostrar[0] + " - " + nota_mostrar[1] + "\r\n" + nota_mostrar[2];
            }
            catch (NullReferenceException) { }
        }

        private void itemSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SpotGest\nDesarrollador: Javier Cameselle", "Sobre...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM [Notas] WHERE id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", ListaMensajes.SelectedItem.ToString().Split('-')[0]);
                    connection.Open();
                    int fa = cmd.ExecuteNonQuery();
                    //MessageBox.Show(fa.ToString());
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show(ex.Message);
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
            ListaMensajes.Items.Remove(ListaMensajes.SelectedItem);
            ListaMensajes.Refresh();
            ListaMensajes.SelectedItem = null;
            tbLeerNotas.Clear();
        }

        private void btnHistorialPartidos_Click(object sender, EventArgs e)
        {
            HistorialPartidos hp = new HistorialPartidos();
            hp.ShowDialog();
        }
    }
}
