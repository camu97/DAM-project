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
    public partial class Entrenamiento : Form
    {
        bool seleccionado = false;
        public Entrenamiento()
        {
            InitializeComponent();
        }

        private void cbCalentamiento_CheckedChanged(object sender, EventArgs e)
        {
            btnIzqCalentamiento.Visible = !btnIzqCalentamiento.Visible;
            btnDerCalentamiento.Visible = !btnDerCalentamiento.Visible;
        }

        private void cbPrincipal_CheckedChanged(object sender, EventArgs e)
        {
            btnIzqPrincipal.Visible = !btnIzqPrincipal.Visible;
            btnDerPrincipal.Visible = !btnDerPrincipal.Visible;
        }

        private void cbCalma_CheckedChanged(object sender, EventArgs e)
        {
            btnIzqCalma.Visible = !btnIzqCalma.Visible;
            btnDerCalma.Visible = !btnDerCalma.Visible;
        }

        private void imgConoRojo_Click(object sender, EventArgs e)
        {
            
        }

        private void imgConoAzul_Click(object sender, EventArgs e)
        {

        }

        private void imgJugador_Click(object sender, EventArgs e)
        {

        }

        private void imgBalon_Click(object sender, EventArgs e)
        {

        }
    }
}
