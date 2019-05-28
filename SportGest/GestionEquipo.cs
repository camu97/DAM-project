using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SportGest
{
    public partial class GestionEquipo : Form
    {
        string sCnn = Properties.Settings.Default.SportGestConnection;
        bool todos = true;
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
            todos = true;
            cargarJugadores();
        }

        private void listEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            todos = false;
            cargarJugadores();
        }



        private void listJugadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listJugadores.SelectedIndices.Count > 0)
            {
                using (SQLiteConnection connection = new SQLiteConnection(sCnn))
                {
                    try
                    {
                        SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Jugadores]", connection);
                        cmd.CommandType = CommandType.Text;

                        connection.Open();
                        SQLiteDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr["nick"].Equals(listJugadores.SelectedItem.ToString().Split('-')[1].Trim()))
                            {
                                lblNombre.Text = dr["nombre"].ToString();
                                //try
                                //{
                                lblNacimiento.Text = dr["fecha_nacimiento"].ToString().Split(' ')[0];
                                //}
                                //catch (FormatException)
                                //{
                                //    lblNacimiento.Text = dr["fecha_nacimiento"].ToString();
                                //}
                                lblNumero.Text = dr["num"].ToString();
                                lblPosicion.Text = dr["posicion"].ToString();
                                tbObservaciones.Text = dr["observaciones"].ToString();
                            }
                        }
                    }
                    catch (SQLiteException ex)
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

        private void atrás_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBorrarJugador_Click(object sender, EventArgs e)
        {
            if (listJugadores.SelectedIndices.Count > 0)
            {
                //jugadoresAdapter.Delete(int.Parse(listJugadores.SelectedItem.ToString().Split('|')[0]));
                using (SQLiteConnection connection = new SQLiteConnection(sCnn))
                {

                    SQLiteCommand cmd = new SQLiteCommand("DELETE FROM [Jugadores] WHERE id=@id", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", listJugadores.SelectedItem.ToString().Split('|')[0]);
                    try
                    {
                        connection.Open();
                        int fa = cmd.ExecuteNonQuery();
                        //MessageBox.Show(fa.ToString());
                    }
                    catch (SQLiteException ex)
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
        }

        private void editarJugador_Click(object sender, EventArgs e)
        {
            if (listEquipos.SelectedIndices.Count > 0)
            {
                NuevoJugador nj = new NuevoJugador();
                nj.editar = true;
                nj.id = listJugadores.SelectedItem.ToString().Split('|')[0].Trim();
                nj.ShowDialog();
                cargarJugadores();
            }
        }


        private void editarEquipo_Click(object sender, EventArgs e)
        {
            if (listEquipos.SelectedIndices.Count > 0)
            {
                NuevoEquipo ne = new NuevoEquipo();
                ne.editar = true;
                ne.id = listEquipos.SelectedItem.ToString().Split('|')[0].Trim();
                ne.ShowDialog();
                cargarEquipos();
            }
        }

        private void borrarEquipo_Click(object sender, EventArgs e)
        {
            if (listEquipos.SelectedIndices.Count > 0)
            {
                using (SQLiteConnection connection = new SQLiteConnection(sCnn))
                {
                    try
                    {
                        //equiposAdapter.Delete(int.Parse(listEquipos.SelectedItem.ToString().Split('|')[0]));   

                        SQLiteCommand cmd = new SQLiteCommand("DELETE FROM [Equipos] WHERE id=@id", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", listEquipos.SelectedItem.ToString().Split('|')[0]);
                        connection.Open();
                        int fa = cmd.ExecuteNonQuery();
                        //MessageBox.Show(fa.ToString());

                        cargarEquipos();

                    }
                    catch (SQLiteException exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void cargarEquipos()
        {
            listEquipos.Items.Clear();
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Equipos]", connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        listEquipos.Items.Add(dr["Id"].ToString() + "| " + dr["nombre"].ToString() + " - " + dr["categoria"].ToString());
                    }

                }
                catch (SQLiteException ex)
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
            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {
                SQLiteCommand cmd;
                if (!todos)
                {
                    cmd = new SQLiteCommand("SELECT * FROM [Jugadores] WHERE equipo=@equipo", connection);
                }
                else
                {
                    cmd = new SQLiteCommand("SELECT * FROM [Jugadores]", connection);
                }
                cmd.CommandType = CommandType.Text;
                try
                {
                    if (!todos)
                        cmd.Parameters.AddWithValue("@equipo", listEquipos.SelectedItem.ToString().Split('|')[1].Split('-')[0].Trim()); //10| Alerta A - Alevines

                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        //if (dr["equipo"].Equals(listEquipos.SelectedItem.ToString().Split('|')[1].Trim()))
                        listJugadores.Items.Add(dr["Id"].ToString() + "| " + dr["num"].ToString() + " - " + dr["nick"].ToString());
                    }
                }
                catch (SQLiteException) { }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
