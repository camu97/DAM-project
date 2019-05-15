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
                        cbEquipo.Items.Add(dr["nombre"].ToString());
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
                            listJugadores.Items.Add(dr["nombre"].ToString());
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
        }

        private void cbCambio2_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio21.Enabled = !cbCambio21.Enabled;
            cbCambio22.Enabled = !cbCambio22.Enabled;
        }

        private void cbCambio3_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio31.Enabled = !cbCambio31.Enabled;
            cbCambio32.Enabled = !cbCambio32.Enabled;
        }

        private void cbCambio4_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio41.Enabled = !cbCambio41.Enabled;
            cbCambio42.Enabled = !cbCambio42.Enabled;
        }

        private void cbCambio5_CheckedChanged(object sender, EventArgs e)
        {
            cbCambio51.Enabled = !cbCambio51.Enabled;
            cbCambio52.Enabled = !cbCambio52.Enabled;
        }
    }
}
