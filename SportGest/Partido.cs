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
    public partial class Partido : Form
    {
        string sCnn = Properties.Settings.Default.SportGestConnection;
        string resultado = "", tipo = "", condicion = "Local", cambios = "", suplentes = "", jornada, tit = "", local, visitante, mensaje = "";
        List<string> equipoTitular, titulares;
        bool error = false, p_prog = false;
        public Partido()
        {
            InitializeComponent();
            equipoTitular = new List<string>();
            titulares = new List<string>();
        }

        private void rbVisitante_CheckedChanged(object sender, EventArgs e)
        {
            tbVisitante.ReadOnly = !tbVisitante.ReadOnly;
            tbLocal.Clear();
            try
            {
                condicion = "Visitante";
                tbVisitante.Text = cbEquipo.SelectedItem.ToString();
            }
            catch (NullReferenceException exc)
            {
                //MessageBox.Show(exc.Message);
            }
        }

        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            tbLocal.ReadOnly = !tbLocal.ReadOnly;
            tbVisitante.Clear();
            try
            {
                condicion = "Local";
                tbLocal.Text = cbEquipo.SelectedItem.ToString();
            }
            catch (NullReferenceException exc)
            {
                //MessageBox.Show(exc.Message);
            }
        }

        private void Partido_Load(object sender, EventArgs e)
        {
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
                        cbEquipo.Items.Add(dr["nombre"].ToString() + " - " + dr["categoria"]);
                    }
                    //DataTable dt;
                    //dt = equiposAdapter.GetData();
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    cbEquipo.Items.Add(dr["nombre"].ToString() + " - " + dr["categoria"]);
                    //}
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rbLocal.Checked)
            {
                tbLocal.Text = cbEquipo.SelectedItem.ToString();
            }
            else
            {
                tbVisitante.Text = cbEquipo.SelectedItem.ToString();
            }


            listJugadores.Items.Clear();
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Equipos", connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["nombre"].ToString().Equals(cbEquipo.SelectedItem.ToString().Split('-')[0].Trim()))
                            switch (dr["categoria"].ToString())
                            {
                                case "MINIS":
                                case "PREBENJAMIN":
                                case "BENJAMIN":
                                case "ALEVIN":
                                    tipo = "F8";
                                    cbCambio1.Enabled = false;
                                    cbCambio2.Enabled = false;
                                    cbCambio3.Enabled = false;
                                    cbCambio4.Enabled = false;
                                    cbCambio5.Enabled = false;
                                    break;
                                case "INFANTIL":
                                case "CADETE":
                                case "JUVENIL":
                                case "SENIOR":
                                case "FEMENINO":
                                    tipo = "F11";
                                    cbCambio1.Enabled = true;
                                    cbCambio2.Enabled = true;
                                    cbCambio3.Enabled = true;
                                    cbCambio4.Enabled = true;
                                    cbCambio5.Enabled = true;
                                    break;
                            }
                        lblTipo.Text = "[" + tipo + "]";
                    }



                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Jugadores", connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    SqlDataReader dr2 = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (dr["equipo"].ToString().Equals(cbEquipo.SelectedItem.ToString().Split('-')[0].Trim()))
                        {
                            listJugadores.Items.Add(dr["num"].ToString() + " - " + dr["nombre"].ToString() + " - " + dr["posicion"].ToString());
                        }
                    }
                    //    if (dr["equipo"].ToString().Equals(cbEquipo.SelectedItem.ToString().Split('-')[0].Trim()))
                    //    {
                    //        listJugadores.Items.Add(dr["num"].ToString() + " - " + dr["nombre"].ToString() + " - " + dr["posicion"].ToString());
                    //    }
                    //}
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message);
                }
            }
        }

        private void cbCambio1_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio11.Enabled = !cbCambio11.Enabled;
            cbCambio12.Enabled = !cbCambio12.Enabled;
            minCambio1.Enabled = !minCambio1.Enabled;
        }

        private void cbCambio2_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio21.Enabled = !cbCambio21.Enabled;
            cbCambio22.Enabled = !cbCambio22.Enabled;
            minCambio2.Enabled = !minCambio2.Enabled;
        }

        private void cbCambio3_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio31.Enabled = !cbCambio31.Enabled;
            cbCambio32.Enabled = !cbCambio32.Enabled;
            minCambio3.Enabled = !minCambio3.Enabled;
        }

        private void cbCambio4_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio41.Enabled = !cbCambio41.Enabled;
            cbCambio42.Enabled = !cbCambio42.Enabled;
            minCambio4.Enabled = !minCambio4.Enabled;
        }

        private void cbCambio5_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio51.Enabled = !cbCambio51.Enabled;
            cbCambio52.Enabled = !cbCambio52.Enabled;
            minCambio5.Enabled = !minCambio5.Enabled;
        }

        private void cbCompeticion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCompetición.SelectedItem.ToString().Equals("Liga"))
            {
                tbJornada.Enabled = true;
            }
            else
            {
                tbJornada.Enabled = false;
            }
        }

        private void cancelarPartido_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbHora_TextChanged(object sender, EventArgs e)
        {
            if (tbHora.TextLength == 5)
            {
                try
                {
                    int.Parse(tbHora.Text.Split(':')[0]);
                    int.Parse(tbHora.Text.Split(':')[1]);
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

        private void Partido_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!p_prog)
            {
                if (DialogResult.No == MessageBox.Show("¿Deseas cancelar este partido?", "Cancelar partido", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    e.Cancel = true;

                }
            }
        }

        private void seleccionarTitular_Click(object sender, EventArgs e)
        {

        }

        private void eliminarTitular_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarAlineacion_Click(object sender, EventArgs e)
        {
            if ((listJugadores.SelectedItems.Count == 11 && tipo.Equals("F11")) || (listJugadores.SelectedItems.Count == 8 && tipo.Equals("F8")))
            {
                //try
                //{
                for (int i = 0; i < listJugadores.SelectedItems.Count; i++)
                {
                    titulares.Add(listJugadores.SelectedItems[i].ToString().Split('-')[1].Trim());
                    equipoTitular.Add(listJugadores.SelectedItems[i].ToString().Split('-')[0].Trim());
                }


                if (listJugadores.Items.Count == listJugadores.SelectedIndices.Count)
                {
                    suplentes = "Sin suplentes";
                }
                else
                {
                    for (int i = 0; i < listJugadores.Items.Count; i++)
                    {
                        if (!equipoTitular.Contains(listJugadores.Items[i].ToString().Split('-')[0].Trim()))
                        {
                            suplentes += listJugadores.Items[i].ToString().Split('-')[0].Trim() + "|";
                        }
                    }
                    suplentes.Substring(0, suplentes.Length - 1);
                }
                MessageBox.Show("Titulares y suplentes confirmados", "Equipo de partido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //catch (NullReferenceException nre)
                //{
                //}
            }
            else
            {
                if (listJugadores.SelectedItems.Count != 11 && tipo.Equals("F11"))
                {
                    MessageBox.Show("Debes seleccionar un 11 titular");
                }
                else if (listJugadores.SelectedItems.Count != 8 && tipo.Equals("F8"))
                {
                    MessageBox.Show("Debes seleccionar un 8 titular");
                }
            }
        }

        private void AñadirPartido_Click(object sender, EventArgs e)
        {
            error = false;
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox && this.Controls[i].Text.Equals("") && !this.Controls[i].Name.Equals("tbJornada"))
                {
                    error = true;
                    mensaje += "\r\n" + this.Controls[i].Name + "vacío";
                }
            }
            try
            {
                DateTime.Parse(tbFecha.Text);
            }
            catch (FormatException)
            {
                error = true;
                mensaje += "\r\nFormato erróneo en la fecha";
            }
            if (equipoTitular.Count == 0)
            {
                error = true;
                mensaje += "\r\nNo hay equipo confirmado";
            }
            if (!error)
            {
                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    if (int.Parse(resultLocal.Text) > int.Parse(resultVisitante.Text))
                    {
                        if (condicion.Equals("Local"))
                        {
                            resultado = "VICTORIA";
                        }
                        else
                        {
                            resultado = "DERROTA";
                        }
                    }
                    else if (int.Parse(resultLocal.Text) < int.Parse(resultVisitante.Text))
                    {
                        if (condicion.Equals("Local"))
                        {
                            resultado = "DERROTA";
                        }
                        else
                        {
                            resultado = "VICTORIA";
                        }
                    }
                    else
                    {
                        resultado = "EMPATE";
                    }
                    try
                    {
                        cambios.Substring(0, cambios.Length - 1);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        cambios = "Sin cambios";
                    }
                    try
                    {
                        suplentes.Substring(0, suplentes.Length - 1);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        suplentes = "Sin jugadores suplentes";
                    }

                    foreach (string s in equipoTitular)
                    {
                        tit += s + "|";
                    }
                    tit = tit.Substring(0, tit.Length - 1);

                    if (tbJornada.Enabled)
                    {
                        jornada = tbJornada.Text;
                    }
                    else
                    {
                        jornada = null;
                    }

                    local = tbLocal.Text;
                    visitante = tbVisitante.Text;
                    if (condicion.Equals("Local"))
                    {
                        local.Split('-')[0].Trim();
                    }
                    else
                    {
                        visitante.Split('-')[0].Trim();
                    }

                    {
                        // partidosAdapter.Insert(
                        //    DateTime.Parse(tbFecha.Text + " " + tbHora.Text),
                        //    local,
                        //    visitante,
                        //    int.Parse(resultLocal.Text),
                        //    int.Parse(resultVisitante.Text),
                        //    resultado,
                        //    jornada,
                        //    cbCompetición.SelectedItem.ToString(),
                        //    tbCampo.Text,
                        //    tbEstAtq.Text,
                        //    tbEstDef.Text,
                        //    tbPosAtq.Text,
                        //    tbPosDef.Text,
                        //    tbCalentamiento.Text,
                        //    tbObservaciones.Text,
                        //    tit,
                        //    suplentes,
                        //    cambios,
                        //    condicion
                        //);
                    }

                    SqlCommand cmd = new SqlCommand("INSERT INTO Partidos VALUES(@fecha,@local,@visitante,@goles_local,@goles_visitante,@resultado,@jornada,@competicion" +
                        ",@campo,@est_atq,@est_def,@pos_atq,@pos_def,@calentamiento,@observaciones,@titulares,@suplentes,@cambios,@condicion_campo)", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@fecha", DateTime.Parse(tbFecha.Text + " " + tbHora.Text));
                    cmd.Parameters.AddWithValue("@local", local);
                    cmd.Parameters.AddWithValue("@visitante", visitante);
                    cmd.Parameters.AddWithValue("@goles_local", int.Parse(resultLocal.Text));
                    cmd.Parameters.AddWithValue("@goles_visitante", int.Parse(resultVisitante.Text));
                    cmd.Parameters.AddWithValue("@resultado", resultado);
                    cmd.Parameters.AddWithValue("@jornada", jornada);
                    cmd.Parameters.AddWithValue("@competicion", cbCompetición.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@campo", tbCampo.Text);
                    cmd.Parameters.AddWithValue("@est_atq", tbEstAtq.Text);
                    cmd.Parameters.AddWithValue("@est_def", tbEstDef.Text);
                    cmd.Parameters.AddWithValue("@pos_atq", tbPosAtq.Text);
                    cmd.Parameters.AddWithValue("@pos_def", tbPosDef.Text);
                    cmd.Parameters.AddWithValue("@calentamiento", tbCalentamiento.Text);
                    cmd.Parameters.AddWithValue("@observaciones", tbObservaciones.Text);
                    cmd.Parameters.AddWithValue("@titulares", tit);
                    cmd.Parameters.AddWithValue("@suplentes", suplentes);
                    cmd.Parameters.AddWithValue("@cambios", cambios);
                    cmd.Parameters.AddWithValue("@condicion_campo", condicion);

                    try
                    {
                        connection.Open();
                        int fa = cmd.ExecuteNonQuery();
                        MessageBox.Show(fa.ToString());

                        connection.Close();

                        p_prog = true;
                        MessageBox.Show("Partido añadido", "Partidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
            else
            {
                MessageBox.Show("Campo(s) incorrecto(s) o vacío(s):" + mensaje, "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
