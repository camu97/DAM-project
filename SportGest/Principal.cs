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
        public string language = "";
        public bool salir_login = false;
        public const string PIN = "0000";
        private bool foco_nueva_nota = false;
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
            if (!salir_login)
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
            Seguridad securityForm = new Seguridad(this);
            //securityForm.ShowDialog();

            string sCnn;
            sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";

            using (SqlConnection connection = new SqlConnection(sCnn))
            {
                connection.Open();
                DataTable dt = new DataTable();

                try
                {
                    dt = notasTableAdapter.GetData();
                    foreach (DataRow dr in dt.Rows)
                    {
                        ListaMensajes.Items.Add(dr["id"].ToString() + " - " + dr["fecha"].ToString().Split(' ')[0] + " - " + dr["nota"].ToString());
                    }
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
                string sCnn;
                sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";
                DataTable dt = new DataTable();

                using (SqlConnection connection = new SqlConnection(sCnn))
                {
                    connection.Open();
                    try
                    {
                        notasTableAdapter.Insert(DateTime.Now.Date, tbNuevaNota.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                tbNuevaNota.Clear();
                ListaMensajes.Items.Clear();
                dt = notasTableAdapter.GetData();
                foreach (DataRow dr in dt.Rows)
                {
                    ListaMensajes.Items.Add(dr["id"].ToString() + " - " + dr["fecha"].ToString().Split(' ')[0] + " - " + dr["nota"].ToString());
                }
                ListaMensajes.Refresh();

            }
        }
        private void btnNuevoPartido_Click(object sender, EventArgs e)
        {
            Partido p = new Partido();
            p.ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Historial h = new Historial();
            h.ShowDialog();

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
            notasTableAdapter.Delete(int.Parse(ListaMensajes.SelectedItem.ToString().Split('-')[0]));
            ListaMensajes.Items.Remove(ListaMensajes.SelectedItem);
            ListaMensajes.Refresh();
            ListaMensajes.SelectedItem = null;
            tbLeerNotas.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Opciones op = new Opciones();
            op.Show();
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
