namespace NT101.P21_CryptoDuo_RSA_Playfair
{
    partial class Playfair_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playfair_form));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.dgvMatrix = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtn5x5 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtText2 = new System.Windows.Forms.RichTextBox();
            this.lbPlainText = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnMakeMT = new System.Windows.Forms.Button();
            this.txtText1 = new System.Windows.Forms.RichTextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lbCipherText = new System.Windows.Forms.Label();
            this.lbKey = new System.Windows.Forms.Label();
            this.rbtDecrypt = new System.Windows.Forms.RadioButton();
            this.rbtEncrypt = new System.Windows.Forms.RadioButton();
            this.lbTask = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1197, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(301, 65);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(1188, 234);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(311, 66);
            this.btnDecrypt.TabIndex = 39;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Visible = false;
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Location = new System.Drawing.Point(304, 525);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.ReadOnly = true;
            this.dgvMatrix.RowHeadersWidth = 102;
            this.dgvMatrix.Size = new System.Drawing.Size(839, 350);
            this.dgvMatrix.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(300, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 111);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(997, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Choose one";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1188, 630);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 36);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "6x6";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // rbtn5x5
            // 
            this.rbtn5x5.AutoSize = true;
            this.rbtn5x5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtn5x5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn5x5.Location = new System.Drawing.Point(1188, 577);
            this.rbtn5x5.Name = "rbtn5x5";
            this.rbtn5x5.Size = new System.Drawing.Size(97, 36);
            this.rbtn5x5.TabIndex = 34;
            this.rbtn5x5.TabStop = true;
            this.rbtn5x5.Text = "5x5";
            this.rbtn5x5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1182, 525);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 33;
            this.label1.Text = "Chọn kích cỡ ma trận";
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(300, 890);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(1204, 302);
            this.txtText2.TabIndex = 32;
            this.txtText2.Text = "";
            // 
            // lbPlainText
            // 
            this.lbPlainText.AutoSize = true;
            this.lbPlainText.BackColor = System.Drawing.Color.GhostWhite;
            this.lbPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlainText.Location = new System.Drawing.Point(82, 234);
            this.lbPlainText.Name = "lbPlainText";
            this.lbPlainText.Size = new System.Drawing.Size(142, 32);
            this.lbPlainText.TabIndex = 31;
            this.lbPlainText.Text = "Plain text";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(1188, 234);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(311, 66);
            this.btnEncrypt.TabIndex = 30;
            this.btnEncrypt.Text = "Mã hoá";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnMakeMT
            // 
            this.btnMakeMT.Location = new System.Drawing.Point(1179, 685);
            this.btnMakeMT.Name = "btnMakeMT";
            this.btnMakeMT.Size = new System.Drawing.Size(302, 69);
            this.btnMakeMT.TabIndex = 29;
            this.btnMakeMT.Text = "Tạo ma trận";
            this.btnMakeMT.UseVisualStyleBackColor = true;
            // 
            // txtText1
            // 
            this.txtText1.Location = new System.Drawing.Point(300, 234);
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(846, 267);
            this.txtText1.TabIndex = 28;
            this.txtText1.Text = "";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(300, 173);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(1199, 38);
            this.txtKey.TabIndex = 27;
            // 
            // lbCipherText
            // 
            this.lbCipherText.AutoSize = true;
            this.lbCipherText.BackColor = System.Drawing.Color.GhostWhite;
            this.lbCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCipherText.Location = new System.Drawing.Point(82, 893);
            this.lbCipherText.Name = "lbCipherText";
            this.lbCipherText.Size = new System.Drawing.Size(162, 32);
            this.lbCipherText.TabIndex = 26;
            this.lbCipherText.Text = "Cipher text";
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.BackColor = System.Drawing.Color.GhostWhite;
            this.lbKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKey.Location = new System.Drawing.Point(82, 173);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(165, 32);
            this.lbKey.TabIndex = 25;
            this.lbKey.Text = "Khoá (Key)";
            // 
            // rbtDecrypt
            // 
            this.rbtDecrypt.AutoSize = true;
            this.rbtDecrypt.BackColor = System.Drawing.Color.AliceBlue;
            this.rbtDecrypt.Location = new System.Drawing.Point(1233, 101);
            this.rbtDecrypt.Name = "rbtDecrypt";
            this.rbtDecrypt.Size = new System.Drawing.Size(271, 36);
            this.rbtDecrypt.TabIndex = 24;
            this.rbtDecrypt.TabStop = true;
            this.rbtDecrypt.Text = "Giải mã (Decrypt)";
            this.rbtDecrypt.UseVisualStyleBackColor = false;
            // 
            // rbtEncrypt
            // 
            this.rbtEncrypt.AutoSize = true;
            this.rbtEncrypt.BackColor = System.Drawing.Color.AliceBlue;
            this.rbtEncrypt.Location = new System.Drawing.Point(1233, 26);
            this.rbtEncrypt.Name = "rbtEncrypt";
            this.rbtEncrypt.Size = new System.Drawing.Size(266, 36);
            this.rbtEncrypt.TabIndex = 23;
            this.rbtEncrypt.TabStop = true;
            this.rbtEncrypt.Text = "Mã hoá (Encrypt)";
            this.rbtEncrypt.UseVisualStyleBackColor = false;
            // 
            // lbTask
            // 
            this.lbTask.AutoSize = true;
            this.lbTask.BackColor = System.Drawing.Color.White;
            this.lbTask.Font = new System.Drawing.Font("Palace Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTask.Location = new System.Drawing.Point(461, 26);
            this.lbTask.Name = "lbTask";
            this.lbTask.Size = new System.Drawing.Size(501, 111);
            this.lbTask.TabIndex = 22;
            this.lbTask.Text = "Playfair cipher";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1535, 1222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Playfair_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 1222);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.dgvMatrix);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbtn5x5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText2);
            this.Controls.Add(this.lbPlainText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnMakeMT);
            this.Controls.Add(this.txtText1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lbCipherText);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.rbtDecrypt);
            this.Controls.Add(this.rbtEncrypt);
            this.Controls.Add(this.lbTask);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Playfair_form";
            this.Text = "Playfair_form";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtn5x5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtText2;
        private System.Windows.Forms.Label lbPlainText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnMakeMT;
        private System.Windows.Forms.RichTextBox txtText1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lbCipherText;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.RadioButton rbtDecrypt;
        private System.Windows.Forms.RadioButton rbtEncrypt;
        private System.Windows.Forms.Label lbTask;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}