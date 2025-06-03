using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT101.P21_CryptoDuo_RSA_Playfair
{
    public partial class Playfair_form : Form
    {
        private PlayfairCipher playfair;

        public Playfair_form()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (playfair == null) return;
            txtText2.Text = playfair.Decrypt(txtText1.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtText1.Text = string.Empty;
            txtKey.Text = string.Empty;
            txtText2.Text = string.Empty;
            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();
        }

        private void btnMakeMT_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text;
            int matrixSize = rbtn5x5.Checked ? 5 : 6;
            playfair = new PlayfairCipher(key, matrixSize);
            playfair.DisplayMatrix(dgvMatrix); // Hiển thị ma trận trong DataGridView
        }

        private void rbtEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEncrypt.Checked)
            {
                lbCipherText.Text = "Cipher Text";
                lbPlainText.Text = "Plain Text";
                btnEncrypt.Visible = true;
                btnDecrypt.Visible = false;  // Ẩn nút Giải mã
            }
            else if (rbtDecrypt.Checked)
            {
                lbCipherText.Text = "Plain Text";
                lbPlainText.Text = "Cipher Text";
                btnDecrypt.Visible = true;
                btnEncrypt.Visible = false;
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (playfair == null) return;
            txtText2.Text = playfair.Encrypt(txtText1.Text);
        }
    }
}
