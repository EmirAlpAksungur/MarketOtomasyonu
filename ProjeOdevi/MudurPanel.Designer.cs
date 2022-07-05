namespace ProjeOdevi
{
    partial class MudurPanel
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.indirimMarketList = new System.Windows.Forms.CheckedListBox();
            this.KodileIndirimYap = new System.Windows.Forms.Button();
            this.indirimMiktarıtxt = new System.Windows.Forms.TextBox();
            this.urunKodutxt = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.Cikis = new System.Windows.Forms.Button();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel8.Controls.Add(this.Cikis);
            this.panel8.Controls.Add(this.label31);
            this.panel8.Controls.Add(this.indirimMarketList);
            this.panel8.Controls.Add(this.KodileIndirimYap);
            this.panel8.Controls.Add(this.indirimMiktarıtxt);
            this.panel8.Controls.Add(this.urunKodutxt);
            this.panel8.Controls.Add(this.label34);
            this.panel8.Controls.Add(this.label35);
            this.panel8.Controls.Add(this.label36);
            this.panel8.Location = new System.Drawing.Point(169, 21);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(406, 481);
            this.panel8.TabIndex = 7;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(38, 143);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(254, 17);
            this.label31.TabIndex = 60;
            this.label31.Text = "Hangi Marketlerde İndirim Uygulanıcak:";
            // 
            // indirimMarketList
            // 
            this.indirimMarketList.CheckOnClick = true;
            this.indirimMarketList.FormattingEnabled = true;
            this.indirimMarketList.Location = new System.Drawing.Point(143, 164);
            this.indirimMarketList.Name = "indirimMarketList";
            this.indirimMarketList.Size = new System.Drawing.Size(216, 89);
            this.indirimMarketList.TabIndex = 59;
            // 
            // KodileIndirimYap
            // 
            this.KodileIndirimYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.KodileIndirimYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.KodileIndirimYap.ForeColor = System.Drawing.Color.White;
            this.KodileIndirimYap.Location = new System.Drawing.Point(163, 271);
            this.KodileIndirimYap.Name = "KodileIndirimYap";
            this.KodileIndirimYap.Size = new System.Drawing.Size(160, 44);
            this.KodileIndirimYap.TabIndex = 58;
            this.KodileIndirimYap.Text = "İndirim Yap";
            this.KodileIndirimYap.UseVisualStyleBackColor = false;
            this.KodileIndirimYap.Click += new System.EventHandler(this.KodileIndirimYap_Click);
            // 
            // indirimMiktarıtxt
            // 
            this.indirimMiktarıtxt.Location = new System.Drawing.Point(142, 115);
            this.indirimMiktarıtxt.Name = "indirimMiktarıtxt";
            this.indirimMiktarıtxt.Size = new System.Drawing.Size(217, 22);
            this.indirimMiktarıtxt.TabIndex = 51;
            // 
            // urunKodutxt
            // 
            this.urunKodutxt.Location = new System.Drawing.Point(142, 87);
            this.urunKodutxt.Name = "urunKodutxt";
            this.urunKodutxt.Size = new System.Drawing.Size(217, 22);
            this.urunKodutxt.TabIndex = 50;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(38, 117);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(98, 17);
            this.label34.TabIndex = 47;
            this.label34.Text = "İndirim Miktarı:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(56, 92);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(80, 17);
            this.label35.TabIndex = 46;
            this.label35.Text = "Ürün Kodu:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(39, 10);
            this.label36.Name = "label36";
            this.label36.Padding = new System.Windows.Forms.Padding(10);
            this.label36.Size = new System.Drawing.Size(320, 49);
            this.label36.TabIndex = 45;
            this.label36.Text = "Ürün Kodu İle İndirim Yap";
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(112)))), ((int)(((byte)(123)))));
            this.Cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cikis.ForeColor = System.Drawing.Color.White;
            this.Cikis.Location = new System.Drawing.Point(142, 359);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(122, 44);
            this.Cikis.TabIndex = 44;
            this.Cikis.Text = "Çıkış";
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // MudurPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 541);
            this.Controls.Add(this.panel8);
            this.Name = "MudurPanel";
            this.Text = "MudurPanel";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.CheckedListBox indirimMarketList;
        private System.Windows.Forms.Button KodileIndirimYap;
        private System.Windows.Forms.TextBox indirimMiktarıtxt;
        private System.Windows.Forms.TextBox urunKodutxt;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Button Cikis;
    }
}