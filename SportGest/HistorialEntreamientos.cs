using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SportGest
{
    public partial class HistorialEntrenamientos : Form
    {
        string sCnn = Properties.Settings.Default.SportGestConnection;
        public HistorialEntrenamientos()
        {
            InitializeComponent();
        }

        private void lblCalentamiento_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Entrenamientos] WHERE Id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", listSesiones.SelectedItem.ToString().Split('|')[0].Trim());
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MessageBox.Show("Duración: " + dr["t_calentamiento"] + "'\r\nTarea:" + dr["calentamiento_descripcion"], "Calentamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lblPrincipal_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Entrenamientos] WHERE Id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", listSesiones.SelectedItem.ToString().Split('|')[0].Trim());
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MessageBox.Show("Duración: " + dr["t_principal"] + "'\r\nTarea:" + dr["principal_descripcion"], "Calentamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lblCalma_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Entrenamientos] WHERE Id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", listSesiones.SelectedItem.ToString().Split('|')[0].Trim());
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        MessageBox.Show("Duración: " + dr["t_calma"] + "'\r\nTarea:" + dr["calma_descripcion"], "Calentamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Entrenamientos]", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listSesiones.Items.Add(dr["Id"] + " | " + dr["fecha"] + " - " + dr["equipo"] /*Se incluye la categoría*/ + " - " + dr["objetivo"]);
                    }

                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
        }

        private void listSesiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Entrenamientos] WHERE Id=@id", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@id", listSesiones.SelectedItem.ToString().Split('|')[0].Trim());
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lblFecha.Text = dr["fecha"].ToString();
                        lblDuracion.Text = dr["duracion"].ToString() + " '";
                        lblEquipo.Text = dr["equipo"].ToString().Split('-')[0].Trim();
                        lblCategoria.Text = dr["equipo"].ToString().Split('-')[1].Trim();
                        lblObjectivo.Text = dr["objetivo"].ToString();
                        tbDescripción.Text = dr["descripcion"].ToString();
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
    }
}
