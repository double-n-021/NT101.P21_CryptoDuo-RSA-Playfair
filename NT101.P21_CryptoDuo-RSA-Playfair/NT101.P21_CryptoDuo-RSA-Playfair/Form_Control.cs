using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT101.P21_CryptoDuo_RSA_Playfair
{
    public partial class Form_Control : Form
    {
        public Form_Control()
        {
            InitializeComponent();
        }

        private void btnPlayFair_Click(object sender, EventArgs e)
        {
            Playfair_form playfair_Form = new Playfair_form();
            playfair_Form.Show();
        }

        private void btnRSA_Click(object sender, EventArgs e)
        {
            RSA_form rsa = new RSA_form();
            rsa.Show();
        }
    }
}
