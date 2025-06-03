using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT101.P21_CryptoDuo_RSA_Playfair
{
    internal class PlayfairCipher
    {
        private char[,] matrix;
        private Dictionary<char, (int, int)> charPositions;
        private int size;

        public PlayfairCipher(string key, int matrixSize)
        {
            size = matrixSize;
            GenerateMatrix(key);
        }

        private void GenerateMatrix(string key)
        {
            string alphabet = (size == 5) ? "ABCDEFGHIKLMNOPQRSTUVWXYZ" : "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Ma trận 5x5 thì I gộp J
            HashSet<char> usedChars = new HashSet<char>();
            List<char> matrixChars = new List<char>();

            // Xóa khoảng trắng và chuyển key thành chữ hoa
            key = key.ToUpper().Replace(" ", "");

            // Thêm khoá vào ma trận
            foreach (char c in key)
            {
                if (!usedChars.Contains(c) && alphabet.Contains(c))
                {
                    matrixChars.Add(c);
                    usedChars.Add(c);
                }
            }

            // Thêm phần còn lại vào bảng chữ cái
            foreach (char c in alphabet)
            {
                if (!usedChars.Contains(c))
                {
                    matrixChars.Add(c);
                    usedChars.Add(c);
                }
            }

            // Tạo ma trận Playfair
            matrix = new char[size, size];
            charPositions = new Dictionary<char, (int, int)>();
            for (int i = 0, k = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = matrixChars[k];
                    charPositions[matrixChars[k]] = (i, j);
                    k++;
                }
            }
        }

        public void DisplayMatrix(DataGridView dgvMatrix)
        {
            dgvMatrix.Rows.Clear();
            dgvMatrix.Columns.Clear();
            dgvMatrix.ColumnCount = size; // Số cột bằng kích thước ma trận

            for (int i = 0; i < size; i++)
            {
                dgvMatrix.Rows.Add(); // Thêm hàng mới

                for (int j = 0; j < size; j++)
                {
                    dgvMatrix.Rows[i].Cells[j].Value = matrix[i, j]; // Gán giá trị
                }
            }

            // Căn giữa text trong ô
            foreach (DataGridViewColumn column in dgvMatrix.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.Width = 35; // Điều chỉnh độ rộng ô
            }
        }

        private string PrepareText(string text)
        {
            text = text.ToUpper().Replace("J", "I"); // Thay J bằng I nếu dùng ma trận 5x5
            text = Regex.Replace(text, "[^A-Z]", ""); // Xóa ký tự không hợp lệ (chỉ giữ chữ cái)

            StringBuilder preparedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                preparedText.Append(text[i]);

                // Nếu hai ký tự liền nhau giống nhau => chèn 'X' vào giữa
                if (i < text.Length - 1 && text[i] == text[i + 1])
                {
                    preparedText.Append('X');
                }
            }

            // Nếu độ dài lẻ, thêm 'X' vào cuối
            if (preparedText.Length % 2 != 0)
            {
                preparedText.Append('X');
            }

            return preparedText.ToString();
        }

        public string Encrypt(string plaintext)
        {
            plaintext = PrepareText(plaintext);
            StringBuilder ciphertext = new StringBuilder();

            for (int i = 0; i < plaintext.Length; i += 2)
            {
                char a = plaintext[i];
                char b = plaintext[i + 1];

                (int rowA, int colA) = charPositions[a];
                (int rowB, int colB) = charPositions[b];

                if (rowA == rowB) // Cùng hàng
                {
                    colA = (colA + 1) % size;
                    colB = (colB + 1) % size;
                }
                else if (colA == colB) // Cùng cột
                {
                    rowA = (rowA + 1) % size;
                    rowB = (rowB + 1) % size;
                }
                else // Hình chữ nhật
                {
                    (colA, colB) = (colB, colA);
                }

                ciphertext.Append(matrix[rowA, colA]);
                ciphertext.Append(matrix[rowB, colB]);
            }
            return ciphertext.ToString();
        }

        public string Decrypt(string ciphertext)
        {
            ciphertext = Regex.Replace(ciphertext.ToUpper(), "[^A-Z0-9]", ""); // Xóa ký tự không hợp lệ (bao gồm cả xuống dòng)
            StringBuilder plaintext = new StringBuilder();

            for (int i = 0; i < ciphertext.Length; i += 2)
            {
                if (i + 1 >= ciphertext.Length) break; // Đảm bảo không bị lỗi khi độ dài lẻ

                char a = ciphertext[i];
                char b = ciphertext[i + 1];

                if (!charPositions.ContainsKey(a) || !charPositions.ContainsKey(b))
                    continue; // Bỏ qua nếu có ký tự không hợp lệ

                (int rowA, int colA) = charPositions[a];
                (int rowB, int colB) = charPositions[b];

                if (rowA == rowB) // Cùng hàng
                {
                    colA = (colA - 1 + size) % size;
                    colB = (colB - 1 + size) % size;
                }
                else if (colA == colB) // Cùng cột
                {
                    rowA = (rowA - 1 + size) % size;
                    rowB = (rowB - 1 + size) % size;
                }
                else // Hình chữ nhật
                {
                    (colA, colB) = (colB, colA);
                }
                plaintext.Append(matrix[rowA, colA]);
                plaintext.Append(matrix[rowB, colB]);
            }
            return plaintext.ToString().Replace("\n", "").Replace("\r", ""); // Loại bỏ xuống dòng và ký tự 'X' chèn thêm khi mã hóa
        }
    }
}
