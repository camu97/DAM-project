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
    public partial class HistorialEntrenamientos : Form
    {
        string sCnn = Properties.Settings.Default.Conexion;
        public HistorialEntrenamientos()
        {
            InitializeComponent();
        }

        private void lblCalentamiento_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = entrenamientosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int i = 0; i < listSesiones.Items.Count; i++)
                        {
                            if (dr["Id"].Equals(listSesiones.SelectedItem.ToString().Split('-')[0].Trim()))
                            {
                                MessageBox.Show("Tiempo: " + dr["t_calentamiento"] + "\r\nTarea:" + dr["calentamiento_descripcion"], "Calentamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (SqlException) { }
            }

        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = entrenamientosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int i = 0; i < listSesiones.Items.Count; i++)
                        {
                            if (dr["Id"].Equals(listSesiones.SelectedItem.ToString().Split('-')[0].Trim()))
                            {
                                MessageBox.Show("Tiempo: " + dr["t_principal"] + "\r\nTarea:" + dr["principal_descripcion"], "Calentamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                }
                catch (SqlException) { }
            }
        }

        private void lblCalma_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = entrenamientosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int i = 0; i < listSesiones.Items.Count; i++)
                        {
                            if (dr["Id"].Equals(listSesiones.SelectedItem.ToString().Split('-')[0].Trim()))
                            {
                                MessageBox.Show("Tiempo: " + dr["t_calma"] + "\r\nTarea:" + dr["calma_descripcion"], "Calentamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (SqlException) { }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    dt = entrenamientosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        listSesiones.Items.Add(dr["Id"] + " - " + dr["fecha"] + " - " + dr["equipo"] /*Se incluye la categoría*/ + " - " + dr["objetivo"]);
                    }

                }
                catch (SqlException) { }
            }
        }

        private void listSesiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    DataTable dt = entrenamientosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["Id"].Equals(listSesiones.SelectedItem.ToString().Split('-')[0].Trim()))
                        {
                            lblFecha.Text = dr["fecha"].ToString();
                            lblDuracion.Text = dr["duracion"].ToString();
                            lblEquipo.Text = dr["equipo"].ToString().Split('-')[0].Trim();
                            lblCategoria.Text = dr["equipo"].ToString().Split('-')[1].Trim();
                            lblObjectivo.Text = dr["objetivo"].ToString();
                            tbDescripción.Text = dr["descripcion"].ToString();
                        }
                    }
                }
                catch (SqlException) { }
            }
        }
    }
}
