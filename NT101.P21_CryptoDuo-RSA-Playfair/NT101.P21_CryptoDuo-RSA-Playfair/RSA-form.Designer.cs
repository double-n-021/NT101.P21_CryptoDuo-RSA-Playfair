namespace NT101.P21_CryptoDuo_RSA_Playfair
{
    partial class RSA_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCipherText = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tbDecryptedText = new System.Windows.Forms.RichTextBox();
            this.tbPlainText = new System.Windows.Forms.RichTextBox();
            this.tbCipherInput = new System.Windows.Forms.RichTextBox();
            this.grbDecrypt = new System.Windows.Forms.GroupBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.grbPQpiN = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.tbPhiN = new System.Windows.Forms.TextBox();
            this.tbNumQ = new System.Windows.Forms.TextBox();
            this.tbNumP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbE = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.grbPubKey = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbPriKey = new System.Windows.Forms.GroupBox();
            this.grbGenerate = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbEncrypt = new System.Windows.Forms.GroupBox();
            this.grbDecrypt.SuspendLayout();
            this.grbPQpiN.SuspendLayout();
            this.grbPubKey.SuspendLayout();
            this.grbPriKey.SuspendLayout();
            this.grbGenerate.SuspendLayout();
            this.grbEncrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCipherText
            // 
            this.tbCipherText.Location = new System.Drawing.Point(24, 175);
            this.tbCipherText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCipherText.Name = "tbCipherText";
            this.tbCipherText.Size = new System.Drawing.Size(559, 102);
            this.tbCipherText.TabIndex = 5;
            this.tbCipherText.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Enabled = false;
            this.btnEncrypt.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(471, 18);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(113, 26);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "ENCRYPT";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tbDecryptedText
            // 
            this.tbDecryptedText.Location = new System.Drawing.Point(27, 175);
            this.tbDecryptedText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDecryptedText.Name = "tbDecryptedText";
            this.tbDecryptedText.Size = new System.Drawing.Size(552, 102);
            this.tbDecryptedText.TabIndex = 3;
            this.tbDecryptedText.Text = "";
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(24, 49);
            this.tbPlainText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(559, 102);
            this.tbPlainText.TabIndex = 2;
            this.tbPlainText.Text = "";
            // 
            // tbCipherInput
            // 
            this.tbCipherInput.Location = new System.Drawing.Point(27, 49);
            this.tbCipherInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCipherInput.Name = "tbCipherInput";
            this.tbCipherInput.Size = new System.Drawing.Size(552, 102);
            this.tbCipherInput.TabIndex = 0;
            this.tbCipherInput.Text = "";
            // 
            // grbDecrypt
            // 
            this.grbDecrypt.Controls.Add(this.tbDecryptedText);
            this.grbDecrypt.Controls.Add(this.btnDecrypt);
            this.grbDecrypt.Controls.Add(this.tbCipherInput);
            this.grbDecrypt.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDecrypt.Location = new System.Drawing.Point(672, 330);
            this.grbDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDecrypt.Name = "grbDecrypt";
            this.grbDecrypt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbDecrypt.Size = new System.Drawing.Size(609, 300);
            this.grbDecrypt.TabIndex = 3;
            this.grbDecrypt.TabStop = false;
            this.grbDecrypt.Text = "DECRYPT";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Enabled = false;
            this.btnDecrypt.Location = new System.Drawing.Point(472, 17);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(107, 27);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "DECRYPT";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // grbPQpiN
            // 
            this.grbPQpiN.Controls.Add(this.btnCalculate);
            this.grbPQpiN.Controls.Add(this.label1);
            this.grbPQpiN.Controls.Add(this.label7);
            this.grbPQpiN.Controls.Add(this.btnGen);
            this.grbPQpiN.Controls.Add(this.tbPhiN);
            this.grbPQpiN.Controls.Add(this.tbNumQ);
            this.grbPQpiN.Controls.Add(this.tbNumP);
            this.grbPQpiN.Controls.Add(this.label3);
            this.grbPQpiN.Location = new System.Drawing.Point(16, 19);
            this.grbPQpiN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPQpiN.Name = "grbPQpiN";
            this.grbPQpiN.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPQpiN.Size = new System.Drawing.Size(408, 245);
            this.grbPQpiN.TabIndex = 0;
            this.grbPQpiN.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(204, 19);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(144, 52);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "P";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Q";
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(26, 19);
            this.btnGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(145, 52);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "GENERATE KEY";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // tbPhiN
            // 
            this.tbPhiN.Location = new System.Drawing.Point(61, 159);
            this.tbPhiN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPhiN.Name = "tbPhiN";
            this.tbPhiN.Size = new System.Drawing.Size(287, 22);
            this.tbPhiN.TabIndex = 1;
            // 
            // tbNumQ
            // 
            this.tbNumQ.Location = new System.Drawing.Point(61, 125);
            this.tbNumQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumQ.Name = "tbNumQ";
            this.tbNumQ.Size = new System.Drawing.Size(287, 22);
            this.tbNumQ.TabIndex = 1;
            // 
            // tbNumP
            // 
            this.tbNumP.Location = new System.Drawing.Point(61, 88);
            this.tbNumP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNumP.Name = "tbNumP";
            this.tbNumP.Size = new System.Drawing.Size(287, 22);
            this.tbNumP.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "ΦN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "N";
            // 
            // tbE
            // 
            this.tbE.Location = new System.Drawing.Point(58, 88);
            this.tbE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbE.Name = "tbE";
            this.tbE.Size = new System.Drawing.Size(297, 22);
            this.tbE.TabIndex = 1;
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(57, 43);
            this.tbN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(299, 22);
            this.tbN.TabIndex = 1;
            // 
            // grbPubKey
            // 
            this.grbPubKey.Controls.Add(this.tbE);
            this.grbPubKey.Controls.Add(this.tbN);
            this.grbPubKey.Controls.Add(this.label5);
            this.grbPubKey.Controls.Add(this.label4);
            this.grbPubKey.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPubKey.Location = new System.Drawing.Point(430, 19);
            this.grbPubKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPubKey.Name = "grbPubKey";
            this.grbPubKey.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPubKey.Size = new System.Drawing.Size(377, 145);
            this.grbPubKey.TabIndex = 1;
            this.grbPubKey.TabStop = false;
            this.grbPubKey.Text = "PUBLIC KEY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "E";
            // 
            // tbD
            // 
            this.tbD.Location = new System.Drawing.Point(58, 32);
            this.tbD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbD.Name = "tbD";
            this.tbD.Size = new System.Drawing.Size(298, 22);
            this.tbD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "D";
            // 
            // grbPriKey
            // 
            this.grbPriKey.Controls.Add(this.tbD);
            this.grbPriKey.Controls.Add(this.label6);
            this.grbPriKey.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPriKey.Location = new System.Drawing.Point(430, 187);
            this.grbPriKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPriKey.Name = "grbPriKey";
            this.grbPriKey.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbPriKey.Size = new System.Drawing.Size(377, 77);
            this.grbPriKey.TabIndex = 1;
            this.grbPriKey.TabStop = false;
            this.grbPriKey.Text = "PRIVATE KEY";
            // 
            // grbGenerate
            // 
            this.grbGenerate.Controls.Add(this.label9);
            this.grbGenerate.Controls.Add(this.label8);
            this.grbGenerate.Controls.Add(this.grbPubKey);
            this.grbGenerate.Controls.Add(this.label2);
            this.grbGenerate.Controls.Add(this.grbPriKey);
            this.grbGenerate.Controls.Add(this.grbPQpiN);
            this.grbGenerate.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGenerate.Location = new System.Drawing.Point(12, 25);
            this.grbGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGenerate.Name = "grbGenerate";
            this.grbGenerate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbGenerate.Size = new System.Drawing.Size(1269, 287);
            this.grbGenerate.TabIndex = 2;
            this.grbGenerate.TabStop = false;
            this.grbGenerate.Text = "CREATE KEY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(827, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(379, 27);
            this.label9.TabIndex = 4;
            this.label9.Text = "23521040 - Le Nhat Trinh Nguyen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(827, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(387, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "23520168 - Doan Ngoc Minh Chau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(827, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "23521037 - Bui Dang Nhat Nguyen";
            // 
            // grbEncrypt
            // 
            this.grbEncrypt.Controls.Add(this.tbPlainText);
            this.grbEncrypt.Controls.Add(this.tbCipherText);
            this.grbEncrypt.Controls.Add(this.btnEncrypt);
            this.grbEncrypt.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEncrypt.Location = new System.Drawing.Point(12, 330);
            this.grbEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbEncrypt.Name = "grbEncrypt";
            this.grbEncrypt.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbEncrypt.Size = new System.Drawing.Size(620, 300);
            this.grbEncrypt.TabIndex = 4;
            this.grbEncrypt.TabStop = false;
            this.grbEncrypt.Text = "ENCRYPT";
            // 
            // RSA_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 660);
            this.Controls.Add(this.grbDecrypt);
            this.Controls.Add(this.grbEncrypt);
            this.Controls.Add(this.grbGenerate);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RSA_form";
            this.Text = "RSA CRYPTOOL";
            this.grbDecrypt.ResumeLayout(false);
            this.grbPQpiN.ResumeLayout(false);
            this.grbPQpiN.PerformLayout();
            this.grbPubKey.ResumeLayout(false);
            this.grbPubKey.PerformLayout();
            this.grbPriKey.ResumeLayout(false);
            this.grbPriKey.PerformLayout();
            this.grbGenerate.ResumeLayout(false);
            this.grbGenerate.PerformLayout();
            this.grbEncrypt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbCipherText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.RichTextBox tbDecryptedText;
        private System.Windows.Forms.RichTextBox tbPlainText;
        private System.Windows.Forms.RichTextBox tbCipherInput;
        private System.Windows.Forms.GroupBox grbDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.GroupBox grbPQpiN;
        private System.Windows.Forms.TextBox tbPhiN;
        private System.Windows.Forms.TextBox tbNumQ;
        private System.Windows.Forms.TextBox tbNumP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbE;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.GroupBox grbPubKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.GroupBox grbPriKey;
        private System.Windows.Forms.GroupBox grbGenerate;
        private System.Windows.Forms.GroupBox grbEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCalculate;
    }
}