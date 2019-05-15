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
    public partial class NuevoJugador : Form
    {
        public bool editar = false;
        public string id;
        string sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";
        public NuevoJugador()
        {
            InitializeComponent();
        }

        private void btnAñadirJugador_Click(object sender, EventArgs e)
        {
            if (!editar)
            {
                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    try
                    {
                        jugadoresTableAdapter1.Insert(int.Parse(tbNumero.Text), tbNombre.Text, tbNick.Text, cbPosicion.SelectedItem.ToString(), DateTime.Parse(tbNacimiento.Text), cbEquipos.SelectedItem.ToString(), tbComentarios.Text);
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
                        DataTable dt = jugadoresTableAdapter1.GetData();
                        DataRow dr;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            dr = dt.Rows[i];
                            if (dr["id"].ToString().Equals(id))
                            {
                                dr["num"] = int.Parse(tbNumero.Text);
                                dr["nombre"] = tbNombre.Text;
                                dr["nick"] = tbNick.Text;
                                dr["posicion"] = cbPosicion.SelectedItem.ToString();
                                dr["observaciones"] = tbComentarios.Text;
                                dr["fecha_nacimiento"] = DateTime.Parse(tbNacimiento.Text).Date;
                                dr["equipo"] = cbEquipos.SelectedItem.ToString();
                                jugadoresTableAdapter1.Update(dr);
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

        private void NuevoJugador_Load(object sender, EventArgs e)
        {
            if (editar)
            {
                btnAñadirJugador.Text = "Acpetar";
            }
            else
            {
                btnAñadirJugador.Text = "Añadir";
            }

            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                connection.Open();
                DataTable dt = equiposTableAdapter.GetData();
                foreach (DataRow dr in dt.Rows)
                {
                    this.cbEquipos.Items.Add(dr["nombre"]);
                }
            }

            this.cbPosicion.Items.Add(ePosicion.PT);
            this.cbPosicion.Items.Add(ePosicion.DEF);
            this.cbPosicion.Items.Add(ePosicion.MED);
            this.cbPosicion.Items.Add(ePosicion.DEL);

        }
    }
}
