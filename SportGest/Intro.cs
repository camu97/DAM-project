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
    public partial class Intro : Form
    {
        private int cont = 0;
        public Intro()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            cont++;
            if (cont % 2 == 0)
            {
                pbIntro.Location = new Point(pbIntro.Location.X, pbIntro.Location.Y + 30);
            }
            else
            {
                pbIntro.Location = new Point(pbIntro.Location.X, pbIntro.Location.Y - 30);
            }
        }
    }
}
