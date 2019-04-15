using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Seguridad securityForm = new Seguridad(this);
            //securityForm.ShowDialog();
        }
    }
}
