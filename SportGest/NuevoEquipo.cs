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
    public partial class NuevoEquipo : Form
    {
        public bool editar = false;
        public string id;
        string sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";
        public NuevoEquipo()
        {
            InitializeComponent();
        }

        private void lbObjetivos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NuevoEquipo_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                btnAñadirEquipo.Text = "Acpetar";
            }
            else
            {
                btnAñadirEquipo.Text = "Añadir";
            }

        }

        private void btnAñadirEquipo_Click(object sender, EventArgs e)
        {

            if (!editar)
            {
                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    try
                    {
                        equiposTableAdapter1.Insert(tbNombre.Text, cbCategoria.SelectedItem.ToString(), tbLiga.Text, int.Parse(tbNumero.Text), tbObservaciones.Text);
                        MessageBox.Show("Operación correcta", "Añadir", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                this.Dispose();
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    try
                    {
                        connection.Open();
                        DataTable dt = equiposTableAdapter1.GetData();
                        DataRow dr;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dr = dt.Rows[i];
                            if (dr["id"].ToString().Equals(id))
                            {
                                dr["num_jugadores"] = int.Parse(tbNumero.Text);
                                dr["nombre"] = tbNombre.Text;
                                dr["categoria"] = cbCategoria.SelectedItem.ToString();
                                dr["observaciones"] = tbObservaciones.Text;
                                dr["liga"] = tbLiga.Text;
                                equiposTableAdapter1.Update(dr);
                            }
                        }

                        dt.AcceptChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
    }
}
