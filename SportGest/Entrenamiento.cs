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
    public partial class Entrenamiento : Form
    {
        bool error = false, e_prog = false;
        string sCnn = Properties.Settings.Default.Conexion;

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
                    try
                    {
                        connection.Open();
                        entrenamientosAdapter.Insert(
                            DateTime.Parse(tbFecha.Text + " " + tbHora.Text),
                            tbObjetivo.Text,
                            int.Parse(tbTiempoSesion.Text),
                            tbDescripcionObjectivo.Text,
                            tbDescipcionCalentamiento.Text,
                            tbDescripcionPrincipal.Text,
                            tbDescripcionCalma.Text,
                            cbEquipo.SelectedItem.ToString(),
                            int.Parse(tbTiempoCalentamiento.Text),
                            int.Parse(tbTiempoPrincipal.Text),
                            int.Parse(tbTiempoCalma.Text),
                            tbMateriaCalentamiento.Text,
                            tbMaterialPrincipal.Text,
                            tbMaterialCalma.Text
                          );
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    MessageBox.Show("Entrenamiento añadido");
                    e_prog = true;
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
                try
                {
                    connection.Open();
                    DataTable dt = equiposAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
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
                    ("¿Deseas abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo,
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
