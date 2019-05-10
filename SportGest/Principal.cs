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

            string sSel = "SELECT * FROM Notas";

            SqlDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                da = new SqlDataAdapter(sSel, sCnn);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    ListaMensajes.Items.Add(dr["fecha"].ToString() + " - " + dr["nota"].ToString());
                }
            }
            catch (Exception ex)
            {
            }

        }

        private void btnAñadirNota_Click(object sender, EventArgs e)
        {
            if (tbNuevaNota.Text.Length != 0)
            {
                //if (tbNuevaNota.Text.Length > 20)
                //{
                //    ListaMensajes.Items.Add(tbNuevaNota.Text.Substring(0, 20));
                //}
                //else
                //{
                ListaMensajes.Items.Add(tbNuevaNota.Text);
                //}
                string sCnn;
                sCnn = "Data Source = (localdb)\\mssqllocaldb; Initial Catalog = SportGest; Integrated Security = True; Pooling = False";
                SqlDataAdapter da;
                DataTable dt = new DataTable();

                string s_cmd = "INSERT INTO Notas values(datetime(now()),'" + tbNuevaNota.Text + "')";


                SqlConnection connection = new SqlConnection(sCnn);
                connection.Open();


                try
                {
                    
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    connection.Close();
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

        }

        private void btnGestionEquipo_Click(object sender, EventArgs e)
        {
            GestionEquipo ge = new GestionEquipo();
            ge.ShowDialog();
        }

        private void ListaMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbLeerNotas.Text = ListaMensajes.SelectedItem.ToString();
        }

        private void itemSobre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SpotGest\nDesarrollador: Javier Cameselle", "Sobre...", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
