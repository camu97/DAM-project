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
        bool user_error;
        int fail_counter;
        Principal form1;
        public Seguridad(Principal f)
        {
            form1 = f;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fail_counter = 0;
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
                using (StreamReader srUser = new StreamReader("users.txt"))
                {
                    string user_read = srUser.ReadLine();
                    string pass_read;
                    int x = 0;
                    while (user_read != null)
                    {
                        if (user_read.Equals(tbUser.Text))
                        {
                            using (StreamReader srPass = new StreamReader("passwords.txt"))
                            {
                                for (int i = 0; i < x; i++)
                                {
                                    srPass.ReadLine();
                                }
                                pass_read = srPass.ReadLine();
                                if (pass_read != null && tbPassword.Equals(pass_read))
                                {
                                    user_error = false;
                                }
                                else
                                {
                                    user_error = true;
                                }
                            }
                        }
                        else
                        {
                            user_error = true;
                        }
                        x++;
                        user_read = srUser.ReadLine();
                    }
                }
            }
            catch (IOException) { }

            if (user_error)
            {
                fail_counter++;
                if (fail_counter == 3)
                {
                    this.Close();
                    form1.Close();
                }
                if (form1.language.Equals("es"))
                {
                    lblError.Text = "Tiene " + (3 - fail_counter) + " intentos";
                }
                else
                {
                    lblError.Text = "You have " + (3 - fail_counter) + " attemps";
                }
            }
        }
    }
}
