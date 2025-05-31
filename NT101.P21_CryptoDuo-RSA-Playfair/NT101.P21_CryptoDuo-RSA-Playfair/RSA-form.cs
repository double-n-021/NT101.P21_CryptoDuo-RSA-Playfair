using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NT101.P21_CryptoDuo_RSA_Playfair
{
    public partial class RSA_form : Form
    {
        public RSA_form()
        {
            InitializeComponent();
        }

        BigInteger P, Q, N, E, D, PhiN;

        private BigInteger ChooseRandomNumber()
        {
            Random rd = new Random();
            return rd.Next(11, 101);
        }

        private bool IsPrime(BigInteger number)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            int i = 5;
            int w = 2;

            while (i * i <= number)
            {
                if (number % i == 0) return false;

                i += w;
                w = 6 - w; // i tăng lần lượt: 5, 7, 11, 13, ...
            }

            return true;
        }


        private void btnGen_Click(object sender, EventArgs e)
        {
            reset();
            P = Q = 0;
            do
            {
                P = ChooseRandomNumber();
                Q = ChooseRandomNumber();
            }
            while (P == Q || !IsPrime(P) || !IsPrime(Q));

            tbNumP.Text = P.ToString();
            tbNumQ.Text = Q.ToString();

            generateKey();  // --> gọi hàm tạo khóa chính

            btnEncrypt.Enabled = true;
            btnDecrypt.Enabled = true;
        }

        private void reset()
        {
            //Mỗi lần gen ra khóa mới thì xóa dữ liệu cũ
            tbNumP.Text = tbNumQ.Text = tbPhiN.Text = tbN.Text = tbE.Text = tbD.Text = string.Empty;
        }

        private void generateKey()
        {
            try
            {
                if (!IsPrime(P) || !IsPrime(Q))
                {
                    MessageBox.Show("P và Q phải là số nguyên tố.", "Lỗi");
                    return;
                }

                N = P * Q;
                PhiN = (P - 1) * (Q - 1);

                tbN.Text = N.ToString();
                tbPhiN.Text = PhiN.ToString();

                //do
                //{
                //    if (tbE.Text == "")
                //    {
                //        E = new Random().Next(2, (int)PhiN);
                //    }
                //    else
                //    {
                //        E = int.Parse(tbE.Text);
                //    }

                //}
                //while (!AreCoprime(E, PhiN));


                //tbE.Text = E.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private bool AreCoprime(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }
            return a == 1;
        }

    }
}
