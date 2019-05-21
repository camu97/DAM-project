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
            cargarEquipos();
        }

        private void nuevoJugador_Click(object sender, EventArgs e)
        {
            NuevoJugador nj = new NuevoJugador();
            nj.ShowDialog();
            cargarJugadores();
        }

        private void GestionEquipo_Load(object sender, EventArgs e)
        {
            cargarEquipos();
        }

        private void listEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarJugadores();
        }



        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Jugadores", connection);
                        cmd.CommandType = CommandType.Text;

                        connection.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr["nick"].Equals(listJugadores.SelectedItem.ToString().Split('-')[1].Trim()))
                            {
                                lblNombre.Text = dr["nombre"].ToString();
                                lblNacimiento.Text = dr["fecha_nacimiento"].ToString().Split(' ')[0];
                                lblNumero.Text = dr["num"].ToString();
                                lblPosicion.Text = dr["posicion"].ToString();
                                tbObservaciones.Text = dr["observaciones"].ToString();
                            }
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
            try
            {
                //jugadoresAdapter.Delete(int.Parse(listJugadores.SelectedItem.ToString().Split('|')[0]));
                using (SqlConnection connection = new SqlConnection(sCnn))
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM Jugadores WHERE id=@id", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", listJugadores.SelectedItem.ToString().Split('|')[0]);
                    try
                    {
                        connection.Open();
                        int fa = cmd.ExecuteNonQuery();
                        MessageBox.Show(fa.ToString());
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
                cargarJugadores();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar un elemento de la lista");
            }
        }

        private void editarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoJugador nj = new NuevoJugador();
                nj.editar = true;
                nj.id = listJugadores.SelectedItem.ToString().Split('|')[0].Trim();
                nj.ShowDialog();
                cargarJugadores();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar un elemento de la lista");
            }
        }

        private void editarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                NuevoEquipo ne = new NuevoEquipo();
                ne.editar = true;
                ne.id = listEquipos.SelectedItem.ToString().Split('|')[0].Trim();
                ne.ShowDialog();
                cargarEquipos();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar un elemento de la lista");
            }
        }

        private void borrarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                //equiposAdapter.Delete(int.Parse(listEquipos.SelectedItem.ToString().Split('|')[0]));
                using (SqlConnection connection = new SqlConnection(sCnn))
                {

                    SqlCommand cmd = new SqlCommand("DELETE FROM Equipos WHERE id=@id", connection);
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        cmd.Parameters.AddWithValue("@id", listEquipos.SelectedItem.ToString().Split('|')[0]);
                        connection.Open();
                        int fa = cmd.ExecuteNonQuery();
                        MessageBox.Show(fa.ToString());
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
                cargarEquipos();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debes seleccionar un elemento de la lista");
            }
        }

        private void cargarEquipos()
        {
            listEquipos.Items.Clear();
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Equipos", connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listEquipos.Items.Add(dr["Id"].ToString() + "| " + dr["nombre"].ToString() + " - " + dr["categoria"].ToString());
                    }
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

        private void cargarJugadores()
        {
            listJugadores.Items.Clear();
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Jugadores WHERE equipo=@equipo", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    cmd.Parameters.AddWithValue("@equipo", listEquipos.SelectedItem.ToString().Split('|')[1].Split('-')[0].Trim()); //10| Alerta A - Alevines

                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //if (dr["equipo"].Equals(listEquipos.SelectedItem.ToString().Split('|')[1].Trim()))
                        listJugadores.Items.Add(dr["Id"].ToString() + "| " + dr["num"].ToString() + " - " + dr["nick"].ToString());
                    }
                }
                catch (NullReferenceException) { }
                catch (SqlException) { }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
