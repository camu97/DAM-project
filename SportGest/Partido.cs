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
        string sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";
        string resultado = "", tipo = "", condicion = "";
        string cambios = "", suplentes = "";
        List<string> equipoTitular, titulares;
        bool error = false;
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
                tbVisitante.Text = cbEquipo.SelectedItem.ToString();
                condicion = "Visitante";
            }
            catch (NullReferenceException) { }
        }

        private void rbLocal_CheckedChanged(object sender, EventArgs e)
        {
            tbLocal.ReadOnly = !tbLocal.ReadOnly;
            tbVisitante.Clear();
            try
            {
                tbLocal.Text = cbEquipo.SelectedItem.ToString();
                condicion = "Local";
            }
            catch (NullReferenceException) { }
        }

        private void Partido_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt;

                    dt = equiposAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cbEquipo.Items.Add(dr["nombre"].ToString() + " - " + dr["categoria"]);
                    }
                }
                catch (SqlException sqle)
                {
                    MessageBox.Show(sqle.Message);
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
                    DataTable dt;

                    dt = equiposAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        switch (dr["categoria"].ToString())
                        {
                            case "MINIS":
                            case "PREBENJAMIN":
                            case "BENJAMIN":
                            case "ALEVIN":
                                tipo = "F8";
                                break;
                            case "INFANTIL":
                            case "CADETE":
                            case "JUVENIL":
                            case "SENIOR":
                            case "FEMENINO":
                                tipo = "F11";
                                break;
                        }
                        lblTipo.Text = "[" + tipo + "]";
                    }

                    dt = jugadoresAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["equipo"].ToString().Equals(cbEquipo.SelectedItem.ToString().Split('-')[0].Trim()))
                        {
                            listJugadores.Items.Add(dr["num"].ToString() + " - " + dr["nombre"].ToString() + " - " + dr["posicion"].ToString());
                        }
                    }
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
                for (int i = 0; i < listJugadores.Items.Count; i++)
                {
                    for (int j = 0; j < listJugadores.SelectedIndices.Count; j++)
                    {
                        if (!listJugadores.Items[i].ToString().Split('-')[1].Trim().Equals(listJugadores.SelectedItems[j].ToString().Split('-')[1].Trim()))
                        {
                            suplentes += listJugadores.Items[i].ToString().Split('-')[1].Trim() + ",";
                        }
                    }
                }
                MessageBox.Show("Titulares y suplentes confirmados", "Equipo titular", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        cambios.Substring(0, cambios.Length - 1);
                        suplentes.Substring(0, suplentes.Length - 1);
                        string tit = "|";
                        foreach (string s in equipoTitular)
                        {
                            tit += s + "|";
                        }
                        partidosAdapter.Insert(DateTime.Parse(date.Value + " " + tbHora.Text), tbLocal.Text, tbVisitante.Text, int.Parse(resultLocal.Text), int.Parse(resultVisitante.Text), resultado, int.Parse(tbJornada.Text), tbCampo.Text, tbEstAtq.Text, tbEstDef.Text, tbPosAtq.Text, tbPosDef.Text, tbCalentamiento.Text, tbObservaciones.Text, tit, suplentes, cambios, condicion);

                    }
                    catch (SqlException) { }
                }
            }
            else
            {
                MessageBox.Show("Algún campo vacío", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
