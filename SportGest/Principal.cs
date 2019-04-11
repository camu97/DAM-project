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
        bool end = false, error_ = false;
        public Principal()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (DialogResult == MessageBox.Show
                ("¿Do you want to exit?", "Exit", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Seguridad securityForm = new Seguridad(this);
            securityForm.ShowDialog();
        }
    }
}
