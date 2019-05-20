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
    public partial class GestionEquipo : Form
    {
        string sCnn = Properties.Settings.Default.SportGestConnection;
        public GestionEquipo()
        {
            InitializeComponent();
        }

        private void nuevoEquipo_Click(object sender, EventArgs e)
        {
            NuevoEquipo ne = new NuevoEquipo();
            ne.ShowDialog();
            this.Refresh();
        }

        private void nuevoJugador_Click(object sender, EventArgs e)
        {
            NuevoJugador nj = new NuevoJugador();
            this.Refresh();
            nj.ShowDialog();
        }

        private void GestionEquipo_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();

                    //dt = equiposAdapter.GetData();
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    listEquipos.Items.Add(dr["Id"].ToString() + "| " + dr["nombre"].ToString() + " - [" + dr["categoria"].ToString() + " ]");
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void listEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {

            listJugadores.Items.Clear();
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt;


                    //dt = jugadoresAdapter.GetData();
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    if (dr["equipo"].Equals(listEquipos.SelectedItem.ToString().Split('-')[0].Split('|')[1].Trim()))
                    //    {
                    //        listJugadores.Items.Add(dr["Id"].ToString() + "| " + dr["num"].ToString() + " - " + dr["nick"].ToString());
                    //    }
                    //}
                }
                catch (NullReferenceException) { }
                catch (SqlException) { }
            }
        }



        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    try
                    {
                        //dt = jugadoresAdapter.GetData();
                        //foreach (DataRow dr in dt.Rows)
                        //{
                        //    if (dr["nick"].Equals(listJugadores.SelectedItem.ToString().Split('-')[1].Trim()))
                        //    {
                        //        lblNombre.Text = dr["nombre"].ToString();
                        //        lblNacimiento.Text = dr["fecha_nacimiento"].ToString().Split(' ')[0];
                        //        lblNumero.Text = dr["num"].ToString();
                        //        lblPosicion.Text = dr["posicion"].ToString();
                        //        tbObservaciones.Text = dr["observaciones"].ToString();
                        //    }
                        //}
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (NullReferenceException) { }
        }

        private void atrás_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBorrarJugador_Click(object sender, EventArgs e)
        {
            if (listJugadores.SelectedIndices.Count == 1)
            {
                //jugadoresAdapter.Delete(int.Parse(listJugadores.SelectedItem.ToString().Split('|')[0]));

                listJugadores.Items.Remove(listJugadores.SelectedItem);
                listJugadores.Refresh();
                listJugadores.SelectedItem = null;
            }
        }

        private void editarJugador_Click(object sender, EventArgs e)
        {
            if (listJugadores.SelectedIndices.Count == 1)
            {
                NuevoJugador nj = new NuevoJugador();
                nj.editar = true;
                nj.id = listJugadores.SelectedItem.ToString().Split('|')[0].Trim();
                nj.ShowDialog();
                this.Refresh();
            }
        }

        private void editarEquipo_Click(object sender, EventArgs e)
        {
            if (listEquipos.SelectedIndices.Count == 1)
            {
                NuevoEquipo ne = new NuevoEquipo();
                ne.editar = true;
                ne.id = listEquipos.SelectedItem.ToString().Split('|')[0].Trim();
                ne.ShowDialog();
                this.Refresh();
            }
        }

        private void borrarEquipo_Click(object sender, EventArgs e)
        {
            if (listEquipos.SelectedIndices.Count == 1)
            {
                //equiposAdapter.Delete(int.Parse(listEquipos.SelectedItem.ToString().Split('|')[0]));

                listEquipos.Items.Remove(listJugadores.SelectedItem);
                listEquipos.Refresh();
                listEquipos.SelectedItem = null;
            }
        }
    }
}
