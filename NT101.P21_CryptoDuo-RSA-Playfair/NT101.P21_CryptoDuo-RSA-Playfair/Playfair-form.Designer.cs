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
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1224, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(301, 65);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.White;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecrypt.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(1222, 234);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(301, 66);
            this.btnDecrypt.TabIndex = 39;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Visible = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // dgvMatrix
            // 
            this.dgvMatrix.BackgroundColor = System.Drawing.Color.White;
            this.dgvMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatrix.Location = new System.Drawing.Point(331, 534);
            this.dgvMatrix.Name = "dgvMatrix";
            this.dgvMatrix.ReadOnly = true;
            this.dgvMatrix.RowHeadersWidth = 102;
            this.dgvMatrix.Size = new System.Drawing.Size(810, 350);
            this.dgvMatrix.TabIndex = 38;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(1163, 630);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 37);
            this.radioButton2.TabIndex = 35;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "6x6";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // rbtn5x5
            // 
            this.rbtn5x5.AutoSize = true;
            this.rbtn5x5.BackColor = System.Drawing.Color.Transparent;
            this.rbtn5x5.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn5x5.Location = new System.Drawing.Point(1163, 576);
            this.rbtn5x5.Name = "rbtn5x5";
            this.rbtn5x5.Size = new System.Drawing.Size(107, 37);
            this.rbtn5x5.TabIndex = 34;
            this.rbtn5x5.TabStop = true;
            this.rbtn5x5.Text = "5x5";
            this.rbtn5x5.UseVisualStyleBackColor = false;
            // 
            // txtText2
            // 
            this.txtText2.BackColor = System.Drawing.Color.White;
            this.txtText2.Location = new System.Drawing.Point(331, 908);
            this.txtText2.Name = "txtText2";
            this.txtText2.Size = new System.Drawing.Size(810, 302);
            this.txtText2.TabIndex = 32;
            this.txtText2.Text = "";
            // 
            // lbPlainText
            // 
            this.lbPlainText.AutoSize = true;
            this.lbPlainText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPlainText.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlainText.Location = new System.Drawing.Point(112, 237);
            this.lbPlainText.Name = "lbPlainText";
            this.lbPlainText.Size = new System.Drawing.Size(167, 33);
            this.lbPlainText.TabIndex = 31;
            this.lbPlainText.Text = "Plain text";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(1222, 234);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(301, 66);
            this.btnEncrypt.TabIndex = 30;
            this.btnEncrypt.Text = "Mã hoá";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnMakeMT
            // 
            this.btnMakeMT.BackColor = System.Drawing.Color.White;
            this.btnMakeMT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMakeMT.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeMT.Location = new System.Drawing.Point(1163, 692);
            this.btnMakeMT.Name = "btnMakeMT";
            this.btnMakeMT.Size = new System.Drawing.Size(360, 69);
            this.btnMakeMT.TabIndex = 29;
            this.btnMakeMT.Text = "Tạo ma trận";
            this.btnMakeMT.UseVisualStyleBackColor = false;
            this.btnMakeMT.Click += new System.EventHandler(this.btnMakeMT_Click);
            // 
            // txtText1
            // 
            this.txtText1.BackColor = System.Drawing.Color.White;
            this.txtText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText1.Location = new System.Drawing.Point(324, 234);
            this.txtText1.Name = "txtText1";
            this.txtText1.Size = new System.Drawing.Size(817, 267);
            this.txtText1.TabIndex = 28;
            this.txtText1.Text = "";
            // 
            // txtKey
            // 
            this.txtKey.BackColor = System.Drawing.Color.White;
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Location = new System.Drawing.Point(324, 171);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(817, 38);
            this.txtKey.TabIndex = 27;
            // 
            // lbCipherText
            // 
            this.lbCipherText.AutoSize = true;
            this.lbCipherText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbCipherText.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCipherText.Location = new System.Drawing.Point(87, 897);
            this.lbCipherText.Name = "lbCipherText";
            this.lbCipherText.Size = new System.Drawing.Size(192, 33);
            this.lbCipherText.TabIndex = 26;
            this.lbCipherText.Text = "Cipher text";
            // 
            // rbtDecrypt
            // 
            this.rbtDecrypt.AutoSize = true;
            this.rbtDecrypt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rbtDecrypt.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDecrypt.Location = new System.Drawing.Point(1224, 101);
            this.rbtDecrypt.Name = "rbtDecrypt";
            this.rbtDecrypt.Size = new System.Drawing.Size(333, 37);
            this.rbtDecrypt.TabIndex = 24;
            this.rbtDecrypt.TabStop = true;
            this.rbtDecrypt.Text = "Giải mã (Decrypt)";
            this.rbtDecrypt.UseVisualStyleBackColor = false;
            this.rbtDecrypt.CheckedChanged += new System.EventHandler(this.rbtDecrypt_CheckedChanged);
            // 
            // rbtEncrypt
            // 
            this.rbtEncrypt.AutoSize = true;
            this.rbtEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.rbtEncrypt.Font = new System.Drawing.Font("DejaVu Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtEncrypt.Location = new System.Drawing.Point(1224, 33);
            this.rbtEncrypt.Name = "rbtEncrypt";
            this.rbtEncrypt.Size = new System.Drawing.Size(326, 37);
            this.rbtEncrypt.TabIndex = 23;
            this.rbtEncrypt.TabStop = true;
            this.rbtEncrypt.Text = "Mã hoá (Encrypt)";
            this.rbtEncrypt.UseVisualStyleBackColor = false;
            this.rbtEncrypt.CheckedChanged += new System.EventHandler(this.rbtEncrypt_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1586, 1229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // Playfair_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1588, 1222);
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