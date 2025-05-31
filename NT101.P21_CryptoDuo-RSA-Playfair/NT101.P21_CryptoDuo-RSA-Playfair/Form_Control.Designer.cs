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
            this.btnPlayFair = new System.Windows.Forms.Button();
            this.btnRSA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlayFair
            // 
            this.btnPlayFair.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFair.ForeColor = System.Drawing.Color.Turquoise;
            this.btnPlayFair.Location = new System.Drawing.Point(189, 167);
            this.btnPlayFair.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlayFair.Name = "btnPlayFair";
            this.btnPlayFair.Size = new System.Drawing.Size(277, 68);
            this.btnPlayFair.TabIndex = 0;
            this.btnPlayFair.Text = "PLAYFAIR";
            this.btnPlayFair.UseVisualStyleBackColor = true;
            this.btnPlayFair.Click += new System.EventHandler(this.btnPlayFair_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSA.ForeColor = System.Drawing.Color.Turquoise;
            this.btnRSA.Location = new System.Drawing.Point(540, 167);
            this.btnRSA.Margin = new System.Windows.Forms.Padding(4);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(277, 68);
            this.btnRSA.TabIndex = 1;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "CryptoDuo-RSA-Playfair";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(842, 58);
            this.label2.TabIndex = 3;
            this.label2.Text = "NT101.P21 - NETWORK SECURITY";
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1018, 285);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnPlayFair);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Control";
            this.Text = "CryptoDuo-RSA-Playfair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Button btnPlayFair;
        private System.Windows.Forms.Button btnRSA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

