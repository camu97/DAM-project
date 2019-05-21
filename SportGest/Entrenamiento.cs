using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGest
{
    public partial class Entrenamiento : Form
    {
        bool error = false, e_prog = false;
        string sCnn = Properties.Settings.Default.SportGestConnection;

        public Entrenamiento()
        {
            InitializeComponent();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProgramarSesion_Click(object sender, EventArgs e)
        {
            error = false;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox && this.Controls[i].Text.Equals("") && this.Controls[i].Name.Contains("Material"))
                {
                    error = true;
                }
            }
            if (!error)
            {
                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Entrenamientos values(@fecha,@objetivo,@duracion,@descripcion," +
                        "@descrip_calent,@descrip_princi,@descrip_calma,@equipo,@t_calent,@t_princi,@t_calma,@mat_calent,@mat_princi,@mat_calma)", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(tbFecha.Text + " " + tbHora.Text));
                    cmd.Parameters.AddWithValue("@objetivo", tbObjetivo.Text);
                    cmd.Parameters.AddWithValue("@duracion", int.Parse(tbTiempoSesion.Text));
                    cmd.Parameters.AddWithValue("@descripcion", tbDescripcionObjectivo.Text);
                    cmd.Parameters.AddWithValue("@descrip_calent", tbDescripcionCalentamiento.Text);
                    cmd.Parameters.AddWithValue("@descrip_princi", tbDescripcionPrincipal.Text);
                    cmd.Parameters.AddWithValue("@descrip_calma", tbDescripcionCalma.Text);
                    cmd.Parameters.AddWithValue("@equipo", cbEquipo.Text);
                    cmd.Parameters.AddWithValue("@t_calent", int.Parse(tbTiempoCalentamiento.Text));
                    cmd.Parameters.AddWithValue("@t_princi", int.Parse(tbTiempoPrincipal.Text));
                    cmd.Parameters.AddWithValue("@t_calma", int.Parse(tbTiempoCalma.Text));
                    cmd.Parameters.AddWithValue("@mat_calent", tbMateriaCalentamiento.Text);
                    cmd.Parameters.AddWithValue("@mat_princi", tbMaterialPrincipal.Text);
                    cmd.Parameters.AddWithValue("@mat_calma", tbMaterialCalma.Text);
                    try
                    {
                        connection.Open();
                        int fa = cmd.ExecuteNonQuery();
                        if (fa == 1)
                        {
                            MessageBox.Show("Entrenamiento añadido");
                            e_prog = true;
                        }
                        {
                            //entrenamientosAdapter.Insert(
                            //DateTime.Parse(tbFecha.Text + " " + tbHora.Text),
                            //  tbObjetivo.Text,
                            //  int.Parse(tbTiempoSesion.Text),
                            //  tbDescripcionObjectivo.Text,
                            //  tbDescripcionCalentamiento.Text,
                            //  tbDescripcionPrincipal.Text,
                            //  tbDescripcionCalma.Text,
                            //  cbEquipo.Text,
                            //  int.Parse(tbTiempoCalentamiento.Text),
                            //  int.Parse(tbTiempoPrincipal.Text),
                            //  int.Parse(tbTiempoCalma.Text),
                            //  tbMateriaCalentamiento.Text,
                            //  tbMaterialPrincipal.Text,
                            //  tbMaterialCalma.Text
                            //);
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Algún campo vacío", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Entrenamiento_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Equipos", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        cbEquipo.Items.Add(dr["nombre"].ToString() + " - " + dr["categoria"]);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Entrenamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!e_prog)
            {
                if (DialogResult.No == MessageBox.Show
                    ("¿Deseas cancelar la sesión?", "Cancelar partido", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    e.Cancel = true;
                }
            }
        }

        private void tbTiempoSesion_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbTiempoSesion.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introducir un número de minutos válido para la sesión");
            }
        }

        private void tbHora_TextChanged(object sender, EventArgs e)
        {
            if (tbHora.TextLength == 5)
            {
                try
                {
                    int horas = int.Parse(tbHora.Text.Split(':')[0]);
                    int minutos = int.Parse(tbHora.Text.Split(':')[1]);
                    if (horas < 0 || horas > 23 || minutos > 59 || minutos < 0)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, introducir una HORA válida");
                }
            }
        }

        private void tbFecha_TextChanged(object sender, EventArgs e)
        {
            if (tbFecha.TextLength == 10)
            {
                try
                {
                    int.Parse(tbFecha.Text.Split('/')[0]);
                    int.Parse(tbFecha.Text.Split('/')[1]);
                    int.Parse(tbFecha.Text.Split('/')[2]);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Por favor, introducir una FECHA válida");
                }
            }
        }

        private void tbTiempoCalentamiento_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(((TextBox)sender).Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, introducir un número de minutos válido para la parte de la sesión");
            }
        }
    }
}
