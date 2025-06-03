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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtn5x5 = new System.Windows.Forms.RadioButton();
            this.txtText2 = new System.Windows.Forms.RichTextBox();
            this.lbPlainText = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnMakeMT = new System.Windows.Forms.Button();
            this.txtText1 = new System.Windows.Forms.RichTextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lbCipherText = new System.Windows.Forms.Label();
            this.rbtDecrypt = new System.Windows.Forms.RadioButton();
            this.rbtEncrypt = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1188, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(301, 65);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(1188, 234);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(301, 66);
            this.btnDecrypt.TabIndex = 39;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Visible = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
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
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1161, 634);
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
            this.rbtn5x5.Location = new System.Drawing.Point(1161, 578);
            this.rbtn5x5.Name = "rbtn5x5";
            this.rbtn5x5.Size = new System.Drawing.Size(97, 36);
            this.rbtn5x5.TabIndex = 34;
            this.rbtn5x5.TabStop = true;
            this.rbtn5x5.Text = "5x5";
            this.rbtn5x5.UseVisualStyleBackColor = false;
            // 
            // txtText2
            // 
            this.txtText2.Location = new System.Drawing.Point(300, 890);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(846, 302);
            this.txtText2.TabIndex = 32;
            this.txtText2.Text = "";
            // 
            // lbPlainText
            // 
            this.lbPlainText.AutoSize = true;
            this.lbPlainText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPlainText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlainText.Location = new System.Drawing.Point(139, 234);
            this.lbPlainText.Name = "lbPlainText";
            this.lbPlainText.Size = new System.Drawing.Size(142, 32);
            this.lbPlainText.TabIndex = 31;
            this.lbPlainText.Text = "Plain text";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(1188, 234);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(301, 66);
            this.btnEncrypt.TabIndex = 30;
            this.btnEncrypt.Text = "Mã hoá";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnMakeMT
            // 
            this.btnMakeMT.Location = new System.Drawing.Point(1161, 696);
            this.btnMakeMT.Name = "btnMakeMT";
            this.btnMakeMT.Size = new System.Drawing.Size(328, 69);
            this.btnMakeMT.TabIndex = 29;
            this.btnMakeMT.Text = "Tạo ma trận";
            this.btnMakeMT.UseVisualStyleBackColor = true;
            this.btnMakeMT.Click += new System.EventHandler(this.btnMakeMT_Click);
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
            this.lbCipherText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCipherText.Location = new System.Drawing.Point(119, 893);
            this.lbCipherText.Name = "lbCipherText";
            this.lbCipherText.Size = new System.Drawing.Size(162, 32);
            this.lbCipherText.TabIndex = 26;
            this.lbCipherText.Text = "Cipher text";
            // 
            // rbtDecrypt
            // 
            this.rbtDecrypt.AutoSize = true;
            this.rbtDecrypt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtDecrypt.Location = new System.Drawing.Point(1188, 104);
            this.rbtDecrypt.Name = "rbtDecrypt";
            this.rbtDecrypt.Size = new System.Drawing.Size(271, 36);
            this.rbtDecrypt.TabIndex = 24;
            this.rbtDecrypt.TabStop = true;
            this.rbtDecrypt.Text = "Giải mã (Decrypt)";
            this.rbtDecrypt.UseVisualStyleBackColor = false;
            this.rbtDecrypt.CheckedChanged += new System.EventHandler(this.rbtDecrypt_CheckedChanged);
            // 
            // rbtEncrypt
            // 
            this.rbtEncrypt.AutoSize = true;
            this.rbtEncrypt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtEncrypt.Location = new System.Drawing.Point(1188, 32);
            this.rbtEncrypt.Name = "rbtEncrypt";
            this.rbtEncrypt.Size = new System.Drawing.Size(266, 36);
            this.rbtEncrypt.TabIndex = 23;
            this.rbtEncrypt.TabStop = true;
            this.rbtEncrypt.Text = "Mã hoá (Encrypt)";
            this.rbtEncrypt.UseVisualStyleBackColor = false;
            this.rbtEncrypt.CheckedChanged += new System.EventHandler(this.rbtEncrypt_CheckedChanged);
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
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.rbtn5x5);
            this.Controls.Add(this.txtText2);
            this.Controls.Add(this.lbPlainText);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnMakeMT);
            this.Controls.Add(this.txtText1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lbCipherText);
            this.Controls.Add(this.rbtDecrypt);
            this.Controls.Add(this.rbtEncrypt);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Playfair_form";
            this.Text = "Playfair Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.DataGridView dgvMatrix;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtn5x5;
        private System.Windows.Forms.RichTextBox txtText2;
        private System.Windows.Forms.Label lbPlainText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnMakeMT;
        private System.Windows.Forms.RichTextBox txtText1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lbCipherText;
        private System.Windows.Forms.RadioButton rbtDecrypt;
        private System.Windows.Forms.RadioButton rbtEncrypt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}