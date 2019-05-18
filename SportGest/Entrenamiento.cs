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
        bool error = false;
        string sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";
        public Entrenamiento()
        {
            InitializeComponent();
        }

        private void imgConoRojo_Click(object sender, EventArgs e)
        {

        }

        private void imgConoAzul_Click(object sender, EventArgs e)
        {

        }

        private void imgJugador_Click(object sender, EventArgs e)
        {

        }

        private void imgBalon_Click(object sender, EventArgs e)
        {

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cancelar entrenamiento", "¿Deseas cancelar la preparación de este entrenamiento? Perderás todo lo que hayas hecho", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void añadirMaterial_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Text.Contains("Calent"))
            {
                tbMateriaCalentamiento.AppendText("- " + cbAñadirMaterial.SelectedItem.ToString() + ((PictureBox)sender).Tag + "\r\n");
            }
            else if (((PictureBox)sender).Text.Contains("Princi"))
            {
                tbMaterialPrincipal.AppendText("- " + cbAñadirMaterial.SelectedItem.ToString() + ((PictureBox)sender).Tag + "\r\n");
            }
            else if (((PictureBox)sender).Text.Contains("Calm"))
            {
                tbMaterialCalma.AppendText("- " + cbAñadirMaterial.SelectedItem.ToString() + ((PictureBox)sender).Tag + "\r\n");
            }
        }

        private void btnProgramarSesion_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox && this.Controls[i].Text.Equals(""))
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
                        entrenamientosAdapter.Insert(DateTime.Parse(fechaPicker.Text + tbHora.Text), tbObjetivo.Text,
                            int.Parse(tbTiempoSesion.Text), tbDescripcionObjectivo.Text, tbDescipcionCalentamiento.Text,
                            tbDescripcionPrincipal.Text, tbDescripcionCalma.Text, cbEquipo.SelectedItem.ToString(),
                            int.Parse(tbTiempoCalentamiento.Text), int.Parse(tbTiempoPrincipal.Text), int.Parse(tbTiempoCalma.Text));
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

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
    }
}
