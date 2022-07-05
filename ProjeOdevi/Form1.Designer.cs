namespace ProjeOdevi
{
    partial class Form1
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
            this.yanlisIdSifre = new System.Windows.Forms.Label();
            this.giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // yanlisIdSifre
            // 
            this.yanlisIdSifre.AutoSize = true;
            this.yanlisIdSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yanlisIdSifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(112)))), ((int)(((byte)(123)))));
            this.yanlisIdSifre.Location = new System.Drawing.Point(88, 241);
            this.yanlisIdSifre.Name = "yanlisIdSifre";
            this.yanlisIdSifre.Size = new System.Drawing.Size(0, 25);
            this.yanlisIdSifre.TabIndex = 20;
            // 
            // giris
            // 
            this.giris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.giris.ForeColor = System.Drawing.Color.White;
            this.giris.Location = new System.Drawing.Point(416, 256);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(188, 86);
            this.giris.TabIndex = 19;
            this.giris.Text = "Giriş Yap";
            this.giris.UseVisualStyleBackColor = false;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(928, 592);
            this.Controls.Add(this.giris);
            this.Controls.Add(this.yanlisIdSifre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yanlisIdSifre;
        private System.Windows.Forms.Button giris;
    }
}

