using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportGest
{
    public partial class Form2 : Form
    {
        bool user_error;
        int fail_counter = 0;
        Form1 form1;
        public Form2(Form1 f)
        {
            form1 = form1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string language = CultureInfo.InstalledUICulture.IetfLanguageTag;
            if (language.Equals("es"))
            {
                form1.language = "es";
            }
            else
            {
                form1.language = "en";
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //CODE SQL connection and comprove that user is into database

            if (user_error)
            {
                fail_counter++;
                if (fail_counter == 3)
                {
                    this.Close();
                    form1.Close();
                }
            }
        }
    }
}
