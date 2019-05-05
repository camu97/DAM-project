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
        const int TRES =3;
        bool usuario_error;
        int cont_fallos;
        Principal form1;
        public Seguridad(Principal f)
        {
            form1 = f;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cont_fallos = 0;
            string language = CultureInfo.InstalledUICulture.IetfLanguageTag;
            if (language.Equals("es"))
            {
                form1.language = "es";
                lblPassword.Text = "Contraseña";
                lblUsuario.Text = "Usuario";
            }
            else
            {
                form1.language = "en";
                lblPassword.Text = "Password";
                lblUsuario.Text = "User";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader srUsuario = new StreamReader("usuarios.txt"))
                {
                    string usuario_leer = srUsuario.ReadLine();
                    string contraseña_leer;
                    int x = 0;
                    while (usuario_leer != null)
                    {
                        if (usuario_leer.Equals(tbUsuario.Text))
                        {
                            using (StreamReader srContraseña = new StreamReader("contraseñas.txt"))
                            {
                                for (int i = 0; i < x; i++)
                                {
                                    srContraseña.ReadLine();
                                }
                                contraseña_leer = srContraseña.ReadLine();
                                if (contraseña_leer != null && tbContraseña.Equals(contraseña_leer))
                                {
                                    usuario_error = false;
                                }
                                else
                                {
                                    usuario_error = true;
                                }
                            }
                        }
                        else
                        {
                            usuario_error = true;
                        }
                        x++;
                        usuario_leer = srUsuario.ReadLine();
                    }
                }
            }
            catch (IOException) { }

            if (usuario_error)
            {
                cont_fallos++;
                if (cont_fallos == 3)
                {
                    form1.Close();
                }
                if (form1.language.Equals("es"))
                {
                    lblError.Text = (TRES - cont_fallos) + " intentos";
                }
                else
                {
                    lblError.Text = (TRES - cont_fallos) + " attemps";
                }
            }
        }
    }
}
