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
        string condicion = "";
        string resultado = "";
        string[] titulares;
        string equipoTitular = "", cambios = "", suplentes = "";
        bool error = false;
        public Partido()
        {
            InitializeComponent();
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
                        switch (dr["categoria"].ToString())
                        {
                            case "MINIS":
                            case "PREBENJAMIN":
                            case "BENJAMIN":
                            case "ALEVIN":
                                cbEquipo.Items.Add(dr["nombre"].ToString() + "- F8");
                                break;
                            case "INFANTIL":
                            case "CADETE":
                            case "JUVENIL":
                            case "SENIOR":
                            case "FEMENINO":
                                cbEquipo.Items.Add(dr["nombre"].ToString() + "- F11");
                                break;
                        }
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

                    dt = jugadoresAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["equipo"].ToString().Equals(cbEquipo.SelectedItem.ToString()))
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

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarDelEquipoTitularToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmarAlineacion_Click(object sender, EventArgs e)
        {
            if ((listJugadores.SelectedItems.Count == 11 && cbEquipo.SelectedItem.ToString().Split('-')[1].Trim().Equals("F11")) || (listJugadores.SelectedItems.Count == 8 && cbEquipo.SelectedItem.ToString().Split('-')[1].Trim().Equals("F8")))
            {
                for (int i = 0; i < listJugadores.SelectedItems.Count; i++)
                {
                    titulares[i] = listJugadores.SelectedItems[i].ToString().Split('-')[1].Trim();
                    equipoTitular += listJugadores.SelectedItems[i].ToString().Split('-')[0].Trim() + ",";
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
            }
            else
            {
                if (listJugadores.SelectedItems.Count != 11 && cbEquipo.SelectedItem.ToString().Split('-')[1].Trim().Equals("F11"))
                {
                    MessageBox.Show("Debes seleccionar un 11 titular");
                }
                else if (listJugadores.SelectedItems.Count != 8 && cbEquipo.SelectedItem.ToString().Split('-')[1].Trim().Equals("F8"))
                {
                    MessageBox.Show("Debes seleccionar un 8 titular");
                }
            }
        }

        private void AñadirEntrenamiento_Click(object sender, EventArgs e)
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
                        equipoTitular.Substring(0, equipoTitular.Length - 1);
                        cambios.Substring(0, cambios.Length - 1);
                        suplentes.Substring(0, suplentes.Length - 1);
                        partidosAdapter.Insert(DateTime.Parse(date.Value + " " + tbHora.Text), tbLocal.Text, tbVisitante.Text, int.Parse(resultLocal.Text), int.Parse(resultVisitante.Text), resultado, int.Parse(tbJornada.Text), tbCampo.Text, tbEstAtq.Text, tbEstDef.Text, tbPosAtq.Text, tbPosDef.Text, tbCalentamiento.Text, tbObservaciones.Text, equipoTitular, suplentes, cambios, condicion);

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
