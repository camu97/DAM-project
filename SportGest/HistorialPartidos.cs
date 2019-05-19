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
    public partial class HistorialPartidos : Form
    {
        string sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";
        string titulares = "";
        public HistorialPartidos()
        {
            InitializeComponent();
        }

        private void lblTitulares_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int i = 0; i < listPartidos.Items.Count; i++)
                        {
                            if (dr["Id"].Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                            {
                                string[] tit = dr["titulares"].ToString().Split('|');
                                for (int j = 0; j < tit.Length; j++)
                                {
                                    titulares += tit[j] + ",";
                                }
                                MessageBox.Show(titulares.Substring(0, titulares.Length - 1) + "\r\n" + dr["suplentes"].ToString(), "Equipo");
                            }
                        }
                    }
                }
                catch (SqlException) { }
            }
        }

        private void HistorialPartidos_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        cbEquipo.Items.Add(dr["equipo"]);
                    }

                }
                catch (SqlException) { }
            }
        }

        private void lblEstilo_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int i = 0; i < listPartidos.Items.Count; i++)
                        {
                            if (dr["Id"].Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                            {
                                MessageBox.Show("Ataque: " + dr["estilo_atq"] + "\r\nDefensa: " + dr["estilo_def"].ToString(), "Estilo de juego");
                            }
                        }
                    }
                }
                catch (SqlException) { }
            }
        }

        private void lblPosicionamiento_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        for (int i = 0; i < listPartidos.Items.Count; i++)
                        {
                            if (dr["Id"].Equals(listPartidos.SelectedItem.ToString().Split('-')[0].Trim()))
                            {
                                MessageBox.Show("Ataque: " + dr["posicion_atq"] + "\r\nDefensa: " + dr["posicion_def"].ToString(), "Posicionamiento");
                            }
                        }
                    }
                }
                catch (SqlException) { }
            }
        }

        private void cbEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                try
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    dt = partidosAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (cbEquipo.SelectedItem.ToString().Equals(dr["equipo"]))
                        {
                            listPartidos.Items.Add(dr["Id"] + " - " + dr["fecha"] + " - " + dr["rival"] + " - " + dr["competicion"]);
                        }
                    }

                }
                catch (SqlException) { }
            }
        }

        private void volverAlMenúPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
