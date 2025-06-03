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
            this.SuspendLayout();
            // 
            // btnPlayFair
            // 
            this.btnPlayFair.BackColor = System.Drawing.Color.AliceBlue;
            this.btnPlayFair.Font = new System.Drawing.Font("DejaVu Serif Condensed", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayFair.ForeColor = System.Drawing.Color.Black;
            this.btnPlayFair.Location = new System.Drawing.Point(332, 301);
            this.btnPlayFair.Margin = new System.Windows.Forms.Padding(8);
            this.btnPlayFair.Name = "btnPlayFair";
            this.btnPlayFair.Size = new System.Drawing.Size(391, 122);
            this.btnPlayFair.TabIndex = 0;
            this.btnPlayFair.Text = "Playfair";
            this.btnPlayFair.UseVisualStyleBackColor = false;
            this.btnPlayFair.Click += new System.EventHandler(this.btnPlayFair_Click);
            // 
            // btnRSA
            // 
            this.btnRSA.Font = new System.Drawing.Font("DejaVu Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRSA.ForeColor = System.Drawing.Color.Black;
            this.btnRSA.Location = new System.Drawing.Point(879, 301);
            this.btnRSA.Margin = new System.Windows.Forms.Padding(8);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(394, 122);
            this.btnRSA.TabIndex = 1;
            this.btnRSA.Text = "RSA";
            this.btnRSA.UseVisualStyleBackColor = true;
            this.btnRSA.Click += new System.EventHandler(this.btnRSA_Click);
            // 
            // Form_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1601, 507);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnPlayFair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form_Control";
            this.Text = "CryptoDuo-RSA-Playfair";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btnPlayFair;
        private System.Windows.Forms.Button btnRSA;
    }
}

