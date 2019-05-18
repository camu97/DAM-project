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
        public bool editar = false, error = false;
        public string id = "";
        string sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";
        public NuevoJugador()
        {
            InitializeComponent();
        }

        private void btnAñadirJugador_Click(object sender, EventArgs e)
        {
            error = false;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox && this.Controls[i].Text.Equals("") && !this.Controls[i].Name.Equals("tbObservaciones"))
                {
                    error = true;
                }
            }

            if (!error)
            {
                if (!editar)
                {
                    if (tbObservaciones.Text.Equals("") || tbNacimiento.Text.Equals("") || tbNick.Text.Equals("") || tbNombre.Text.Equals("") || tbNumero.Text.Equals(""))
                    {
                        MessageBox.Show("Toddos los campos se deben rellenar");
                    }
                    else
                    {
                        using (SqlConnection connection = new SqlConnection(sCnn))
                        {
                            connection.Open();
                            DataTable dt = new DataTable();
                            try
                            {
                                jugadoresAdapter.Insert(int.Parse(tbNumero.Text), tbNombre.Text, tbNick.Text, cbPosicion.SelectedItem.ToString(), DateTime.Parse(tbNacimiento.Text), cbEquipos.SelectedItem.ToString(), tbObservaciones.Text);
                                MessageBox.Show("Operación correcta", "Añadir", MessageBoxButtons.OK);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        this.Dispose();
                    }

                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(sCnn))
                    {
                        try
                        {
                            connection.Open();
                            DataTable dt = jugadoresAdapter.GetData();
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
                                    dr["observaciones"] = tbObservaciones.Text;
                                    dr["fecha_nacimiento"] = DateTime.Parse(tbNacimiento.Text).Date;
                                    dr["equipo"] = cbEquipos.SelectedItem.ToString();
                                    jugadoresAdapter.Update(dr);
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
            else
            {
                MessageBox.Show("Algún campo vacío", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                dt = jugadoresAdapter.GetData();
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["id"].ToString().Equals(id))
                    {
                        tbNumero.Text = dr["num"].ToString();
                        tbNombre.Text = dr["nombre"].ToString();
                        tbNick.Text = dr["nick"].ToString();
                        cbPosicion.SelectedItem = dr["posicion"].ToString();
                        tbObservaciones.Text = dr["observaciones"].ToString();
                        tbNacimiento.Text = dr["fecha_nacimiento"].ToString().Split(' ')[0];
                        cbEquipos.SelectedItem = dr["equipo"].ToString();

                    }
                }
            }

            this.cbPosicion.Items.Add(ePosicion.PT);
            this.cbPosicion.Items.Add(ePosicion.DEF);
            this.cbPosicion.Items.Add(ePosicion.MED);
            this.cbPosicion.Items.Add(ePosicion.DEL);

        }
    }
}
