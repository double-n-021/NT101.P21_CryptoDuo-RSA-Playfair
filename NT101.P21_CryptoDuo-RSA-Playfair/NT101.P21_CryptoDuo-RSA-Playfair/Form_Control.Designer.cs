namespace NT101.P21_CryptoDuo_RSA_Playfair
{
    partial class Form_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Control));
            this.btnPlayFair = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayFair
            // 
            this.btnPlayFair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlayFair.Font = new System.Drawing.Font("DejaVu Serif Condensed", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFair.ForeColor = System.Drawing.Color.Black;
            this.btnPlayFair.Location = new System.Drawing.Point(311, 348);
            this.btnPlayFair.Margin = new System.Windows.Forms.Padding(8);
            this.btnPlayFair.Name = "btnPlayFair";
            this.btnPlayFair.Size = new System.Drawing.Size(681, 99);
            this.btnPlayFair.TabIndex = 0;
            this.btnPlayFair.Text = "Playfair";
            this.btnPlayFair.UseVisualStyleBackColor = false;
            this.btnPlayFair.Click += new System.EventHandler(this.btnPlayFair_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Font = new System.Drawing.Font("DejaVu Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSA.ForeColor = System.Drawing.Color.Black;
            this.btnRSA.Location = new System.Drawing.Point(1132, 348);
            this.btnRSA.Margin = new System.Windows.Forms.Padding(8);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(699, 99);
            this.btnRSA.TabIndex = 1;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2123, 823);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(2104, 518);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnPlayFair);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "Form_Control";
            this.Text = "CryptoDuo-RSA-Playfair";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnPlayFair;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

