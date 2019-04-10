using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGest
{
    public partial class Form1 : Form
    {
        public string language = "";
        bool end = false, error_ = false;
        public Form1()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 securityForm = new Form2(this);
            securityForm.ShowDialog();
        }
    }
}
