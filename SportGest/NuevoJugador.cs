using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SportGest
{
    public partial class NuevoJugador : Form
    {
        public bool editar = false, error = false;
        public string id = "";
        string sCnn = Properties.Settings.Default.SportGestConnection;
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
            try
            {
                DateTime x = DateTime.Parse(tbNacimiento.Text).Date;
            }
            catch (FormatException)
            {
                error = true;
            }
            try
            {
                int x = int.Parse(tbNumero.Text);
            }
            catch (FormatException)
            {
                error = true;
            }
            string pos = cbPosicion.Text;
            if (!pos.Equals("PT") && !pos.Equals("DEF") & !pos.Equals("MED") && !pos.Equals("DEL"))
            {
                error = true;
            }
            bool e_equipo = false;
            string s = "";
            for (int i = 0; i < cbEquipos.Items.Count; i++)
            {
                s = cbEquipos.Items[i].ToString();
                if (s.Equals(cbEquipos.Text))
                {
                    e_equipo = true;
                }
            }
            if (!e_equipo)
            {
                error = true;
            }
            if (!error)
            {
                using (SQLiteConnection connection = new SQLiteConnection(sCnn))
                {
                    SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Jugadores] WHERE num=@numero and equipo=@equipo and nombre!=@nombre", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@numero", int.Parse(tbNumero.Text));
                    cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                    cmd.Parameters.AddWithValue("@equipo", cbEquipos.Text.Split('[')[0].Trim());
                    try
                    {
                        connection.Open();
                        SQLiteDataReader dr = cmd.ExecuteReader();
                        while (dr.Read()) { }
                        if (dr.HasRows)
                        {
                            error = true;
                            MessageBox.Show("Ya hay un jugador con ese número[" + tbNumero.Text + "]");
                        }
                        {
                            //DataTable dt = jugadoresAdapter.GetData();
                            //DataRow dr;
                            //for (int i = 0; i < dt.Rows.Count; i++)
                            //{
                            //    dr = dt.Rows[i];
                            //    if (dr["num"].ToString().Equals(tbNumero.Text) && dr["equipo"].ToString().Equals(cbEquipos.SelectedItem.ToString().Split('[')[0].Trim()))
                            //    {
                            //        error = true;
                            //        tbNumero.Text = "¡" + tbNumero.Text + "!";
                            //        toolTip1.SetToolTip(tbNumero, "Ya existe un jugador con ese número");
                            //        toolTip1.SetToolTip(label7, "Ya existe un jugador con ese número");
                            //    }
                            //}
                            //dt.AcceptChanges();
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

            if (!error)
            {
                if (!editar)
                {
                    using (SQLiteConnection connection = new SQLiteConnection(sCnn))
                    {
                        //jugadoresAdapter.Insert(int.Parse(tbNumero.Text), tbNombre.Text, tbNick.Text, cbPosicion.SelectedItem.ToString(), DateTime.Parse(tbNacimiento.Text), cbEquipos.SelectedItem.ToString().Split('[')[0].Trim(), tbObservaciones.Text);

                        SQLiteCommand cmd = new SQLiteCommand("INSERT into [Jugadores] (num,nombre,nick,posicion,fecha_nacimiento,equipo,observaciones) VALUES(@numero,@nombre,@nick,@posicion,@fecha,@equipo,@observaciones)", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@nick", tbNick.Text);
                        cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(tbNacimiento.Text).Date);
                        try
                        {
                            cmd.Parameters.AddWithValue("@numero", int.Parse(tbNumero.Text));
                        }
                        catch (FormatException)
                        {
                            error = true;
                        }



                        cmd.Parameters.AddWithValue("@observaciones", tbObservaciones.Text);
                        cmd.Parameters.AddWithValue("@posicion", cbPosicion.Text);
                        cmd.Parameters.AddWithValue("@equipo", cbEquipos.Text.Split('[')[0].Trim());
                        try
                        {
                            connection.Open();
                            int fa = cmd.ExecuteNonQuery();
                            if (fa >= 1)
                            {
                                MessageBox.Show("Añadido", "Añadir jugador", MessageBoxButtons.OK);
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
                    this.Dispose();
                }
                else
                {
                    using (SQLiteConnection connection = new SQLiteConnection(sCnn))
                    {
                        {
                            //DataTable dt = jugadoresAdapter.GetData();
                            //DataRow dr;
                            //for (int i = 0; i < dt.Rows.Count; i++)
                            //{
                            //    dr = dt.Rows[i];
                            //    if (dr["id"].ToString().Equals(id))
                            //    {
                            //        dr["num"] = int.Parse(tbNumero.Text);
                            //        dr["nombre"] = tbNombre.Text;
                            //        dr["nick"] = tbNick.Text;
                            //        dr["posicion"] = cbPosicion.SelectedItem.ToString();
                            //        dr["observaciones"] = tbObservaciones.Text;
                            //        dr["fecha_nacimiento"] = DateTime.Parse(tbNacimiento.Text).Date;
                            //        dr["equipo"] = cbEquipos.SelectedItem.ToString().Split('[')[0].Trim();
                            //        jugadoresAdapter.Update(dr);
                            //    }
                            //}
                            //dt.AcceptChanges();
                        }
                        SQLiteCommand cmd = new SQLiteCommand("UPDATE [Jugadores] SET " +
                            "nombre=@nombre," +
                            "posicion=@posicion," +
                            "fecha_nacimiento=@fecha," +
                            "nick=@nick," +
                            "num=@numero," +
                            "equipo=@equipo," +
                            "observaciones=@observaciones WHERE id=@id", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@nick", tbNick.Text);
                        cmd.Parameters.AddWithValue("@nombre", tbNombre.Text);
                        cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(tbNacimiento.Text));
                        cmd.Parameters.AddWithValue("@numero", int.Parse(tbNumero.Text));
                        cmd.Parameters.AddWithValue("@observaciones", tbObservaciones.Text);
                        cmd.Parameters.AddWithValue("@posicion", cbPosicion.Text);
                        cmd.Parameters.AddWithValue("@equipo", cbEquipos.Text.Split('[')[0].Trim());
                        try
                        {
                            connection.Open();
                            int fa = cmd.ExecuteNonQuery();
                            if (fa == 1)
                            {
                                MessageBox.Show("Operación correcta", "Modificar datos", MessageBoxButtons.OK);
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
            else
            {
                MessageBox.Show("Error en algún campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNumero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(tbNumero.Text);
            }
            catch (FormatException)
            {
                error = true;

            }
        }

        private void NuevoJugador_Load(object sender, EventArgs e)
        {
            this.cbPosicion.Items.Add("PT");
            this.cbPosicion.Items.Add("DEF");
            this.cbPosicion.Items.Add("MED");
            this.cbPosicion.Items.Add("DEL");

            if (editar)
            {
                btnAñadirJugador.Text = "Acpetar";
                this.Text = "Jugador";
            }
            else
            {
                btnAñadirJugador.Text = "Añadir";
                this.Text = "Nuevo jugador";
            }

            using (SQLiteConnection connection = new SQLiteConnection(sCnn))
            {


                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM [Equipos]", connection);
                cmd.CommandType = CommandType.Text;
                try
                {
                    connection.Open();
                    SQLiteDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        this.cbEquipos.Items.Add(dr["nombre"] + "   [" + dr["categoria"] + "]");
                    }
                }
                catch (SQLiteException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    connection.Close();
                }

                if (editar)
                {
                    cmd = new SQLiteCommand("SELECT * FROM [Jugadores] WHERE id=@id", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id", id);
                    try
                    {
                        connection.Open();
                        SQLiteDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            {
                                //if (dr["id"].ToString().Equals(id))
                                tbNumero.Text = dr["num"].ToString();
                                tbNombre.Text = dr["nombre"].ToString();
                                tbNick.Text = dr["nick"].ToString();
                                cbPosicion.Text = dr["posicion"].ToString();
                                tbObservaciones.Text = dr["observaciones"].ToString();
                                tbNacimiento.Text = dr["fecha_nacimiento"].ToString().Split(' ')[0];
                                cbEquipos.Text = dr["equipo"].ToString();
                            }
                        }
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
    }
}