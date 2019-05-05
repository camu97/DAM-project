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
    public partial class GestionEquipo : Form
    {
        public GestionEquipo()
        {
            InitializeComponent();
        }

        private void nuevoEquipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoEquipo ne = new NuevoEquipo();
            ne.ShowDialog();
        }

        private void nuevoJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoJugador nj = new NuevoJugador();
            nj.ShowDialog();
        }
    }
}
