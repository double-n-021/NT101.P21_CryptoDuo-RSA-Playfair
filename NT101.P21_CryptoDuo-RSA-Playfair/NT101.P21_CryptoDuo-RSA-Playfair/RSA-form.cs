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

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {

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

            btnDecrypt.Enabled = true;
            btnEncrypt.Enabled = true;
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
                N = P * Q;
                PhiN = (P - 1) * (Q - 1);

                tbN.Text = N.ToString();
                tbPhiN.Text = PhiN.ToString();

                //Chọn E thõa mãn điều kiện
                do
                {
                    if (tbE.Text == "")
                    {
                        E = new Random().Next(2, (int)PhiN); //Chọn ngẫu nhiên E từ 2 đến phiN
                    }
                    else
                    {
                        E = int.Parse(tbE.Text); //Nhập thủ công E
                    }

                }

                while (!AreCoprime(E, PhiN));
                tbE.Text = E.ToString();

                //Tìm số D (nghịch đảo modular của E theo modulo PhiN
                var result = ExtendedEuclid((int)E, (int)PhiN);
                BigInteger gcd = result.gcd;
                BigInteger x = result.x;
                //BigInteger y = result.y; // không dùng

                if (gcd != 1)
                {
                    MessageBox.Show("Không tìm được khóa d vì gcd(E, PhiN) != 1", "Lỗi");
                    return;
                }

                D = x % PhiN;
                if (D < 0) D += PhiN; //Đảm bảo d > 0

                tbD.Text = D.ToString();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //Thuật toán Euclid để kiểm tra gcd(a, b) == 1. Tức là kiểm tra 2 số nguyên tố cùng nhau
        private bool AreCoprime(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                (a, b) = (b, a % b);
            }

            return a == 1;
        }

        //Hàm Euclid mở rộng để tìm D
        private (BigInteger gcd, BigInteger x, BigInteger y) ExtendedEuclid(BigInteger a, BigInteger b)
        {
            if (b == 0)
                return (a, 1, 0);

            var (gcd, x1, y1) = ExtendedEuclid(b, a % b); //Đệ quy đổi vai trò a và b, tìm nghiệm b.x1 + (a mod b).y1 = gcd(b, a mod b)

            //Quy đổi nghiệm ngược lại từ thuật toán Euclid mở rộng
            BigInteger x = y1;
            BigInteger y = x1 - (a / b) * y1;

            return (gcd, x, y);
        }

        //private (BigInteger gcd, BigInteger x, BigInteger y) ExtendedEuclid2(BigInteger a, BigInteger b)
        //{
        //    BigInteger x0 = 1, y0 = 0;
        //    BigInteger x1 = 0, y1 = 1;

        //    while (b != 0)
        //    {
        //        BigInteger q = a / b;
        //        BigInteger r = a % b;

        //        // Cập nhật a và b
        //        a = b;
        //        b = r;

        //        // Cập nhật x và y
        //        BigInteger xTmp = x1;
        //        x1 = x0 - q * x1;
        //        x0 = xTmp;

        //        BigInteger yTmp = y1;
        //        y1 = y0 - q * y1;
        //        y0 = yTmp;
        //    }

        //    return (a, x0, y0);
        //}

    }
}
