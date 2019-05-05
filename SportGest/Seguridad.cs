using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGest
{
    public partial class Seguridad : Form
    {
        const int FALLOS_POSIBLES = 3;
        bool pinCorrecto = false;
        int cont_fallos = 0;
        Principal form1;
        public Seguridad(Principal f)
        {
            InitializeComponent();
            form1 = f;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cont_fallos = 0;
            //string language = cultureinfo.installeduiculture.ietflanguagetag;
            //if (language.equals("es"))
            //{
            //    form1.language = "es";
            //    lblpassword.text = "contraseña";
            //    lblusuario.text = "usuario";
            //}
            //else
            //{
            //    form1.language = "en";
            //    lblpassword.text = "password";
            //    lblusuario.text = "user";
            //}
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbPin.Equals("0000"))
            {
                pinCorrecto = true;
                this.Dispose();
            }
            else
            {
                cont_fallos++;
                if (cont_fallos == 3)
                {
                    form1.Close();
                }
                //if (form1.language.Equals("es"))
                //{
                lblError.Text = (FALLOS_POSIBLES - cont_fallos) + " intentos";
                //}
                //else
                //{
                //    lblError.Text = (TRES - cont_fallos) + " attemps";
                //}
            }
            tbPin.Clear();
        }

        private void Seguridad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cont_fallos != 3)
            {
                if (DialogResult.No == MessageBox.Show
                    ("¿Deseas abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question))
                {
                    e.Cancel = true;
                }
                else
                {
                    form1.salir_login = true;
                    form1.Close();
                }
            }
        }
    }
}
