using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGest
{
    public partial class Principal : Form
    {
        string sCnn = Properties.Settings.Default.SportGestConnection;
        public Principal()
        {
            InitializeComponent();
        }

        private void btnNuevoEntrenamiento_Click(object sender, EventArgs e)
        {
            Entrenamiento ent = new Entrenamiento();
            ent.ShowDialog();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show
                ("¿Deseas abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                e.Cancel = true;
            }
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            //intro.ShowDialog();

            using (SqlConnection connection = new SqlConnection(sCnn))
            {

                DataTable dt = new DataTable();

                try
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Notas;", connection);
                    cmd.CommandType = CommandType.Text;

                    connection.Open();
                    SqlDataReader r = cmd.ExecuteReader();
                    while (r.Read())
                    {
                        ListaMensajes.Items.Add(r["id"].ToString() + " - " + r["fecha"].ToString().Split(' ')[0] + " - " + r["nota"].ToString());
                    }

                    //dt = notasTableAdapter1.GetData();
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    ListaMensajes.Items.Add(dr["id"].ToString() + " - " + dr["fecha"].ToString().Split(' ')[0] + " - " + dr["nota"].ToString());
                    //}

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        private void btnAñadirNota_Click(object sender, EventArgs e)
        {
            if (tbNuevaNota.Text.Length != 0)
            {
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO Notas(fecha,nota) values(" + DateTime.Now.ToString() + ",\'" + tbNuevaNota.Text + "\');", connection);
                        cmd.CommandType = CommandType.Text;
                        connection.Open();
                        int fa = cmd.ExecuteNonQuery();
                        MessageBox.Show(fa.ToString());
                        //notasTableAdapter1.Insert(DateTime.Now.Date, tbNuevaNota.Text);

                        //dt = notasTableAdapter1.GetData();
                        foreach (DataRow dr in dt.Rows)
                        {
                            MessageBox.Show(dr["id"].ToString() + " - " + dr["fecha"].ToString().Split(' ')[0] + " - " + dr["nota"].ToString());
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    try
                    {
                        tbNuevaNota.Clear();
                        ListaMensajes.Items.Clear();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Notas;", connection);
                        cmd.CommandType = CommandType.Text;

                        connection.Open();
                        SqlDataReader r = cmd.ExecuteReader();
                        while (r.Read())
                        {
                            ListaMensajes.Items.Add(r["id"].ToString() + " - " + r["fecha"].ToString().Split(' ')[0] + " - " + r["nota"].ToString());
                        }
                        ListaMensajes.Refresh();
                    }
                    catch (SqlException) { }
                }
            }
        }
        private void btnNuevoPartido_Click(object sender, EventArgs e)
        {
            Partido p = new Partido();
            p.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            HistorialEntrenamientos he = new HistorialEntrenamientos();
            he.ShowDialog();

        }

        private void btnGestionEquipo_Click(object sender, EventArgs e)
        {
            GestionEquipo ge = new GestionEquipo();
            ge.ShowDialog();
        }

        private void ListaMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] nota_mostrar = ListaMensajes.SelectedItem.ToString().Split('-');
                tbLeerNotas.Text = nota_mostrar[0] + " - " + nota_mostrar[1] + "\r\n" + nota_mostrar[2];
            }
            catch (NullReferenceException) { }
        }

        private void itemSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SpotGest\nDesarrollador: Javier Cameselle", "Sobre...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminarNota_Click(object sender, EventArgs e)
        {
            //notasTableAdapter1.Delete(int.Parse(ListaMensajes.SelectedItem.ToString().Split('-')[0]));
            ListaMensajes.Items.Remove(ListaMensajes.SelectedItem);
            ListaMensajes.Refresh();
            ListaMensajes.SelectedItem = null;
            tbLeerNotas.Clear();
        }

        private void btnHistorialPartidos_Click(object sender, EventArgs e)
        {
            HistorialPartidos hp = new HistorialPartidos();
            hp.ShowDialog();
        }



        //private void tbNuevaNota_Enter(object sender, EventArgs e)
        //{
        //    foco_nueva_nota = true;
        //}

        //private void tbNuevaNota_Leave(object sender, EventArgs e)
        //{
        //    foco_nueva_nota = false;
        //}
    }
}
