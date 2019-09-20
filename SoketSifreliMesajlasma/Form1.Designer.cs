namespace SoketSifreliMesajlasma
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.LstbxGenelKonusma = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GelenMesajSifreli = new System.Windows.Forms.TextBox();
            this.GelenMesaj = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnGonder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUzakPort = new System.Windows.Forms.TextBox();
            this.GidenMesajSifreli = new System.Windows.Forms.TextBox();
            this.BtnSifreCoz = new System.Windows.Forms.Button();
            this.BtnSifrele = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnTemizle = new System.Windows.Forms.Button();
            this.TxtBenimPort = new System.Windows.Forms.TextBox();
            this.GidenMesaj = new System.Windows.Forms.TextBox();
            this.TxtUzakIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBaglan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBenimIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstbxGenelKonusma
            // 
            this.LstbxGenelKonusma.DisplayMember = "0";
            this.LstbxGenelKonusma.Enabled = false;
            this.LstbxGenelKonusma.FormattingEnabled = true;
            this.LstbxGenelKonusma.ItemHeight = 16;
            this.LstbxGenelKonusma.Location = new System.Drawing.Point(20, 386);
            this.LstbxGenelKonusma.Name = "LstbxGenelKonusma";
            this.LstbxGenelKonusma.Size = new System.Drawing.Size(462, 132);
            this.LstbxGenelKonusma.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(305, 301);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 17);
            this.label9.TabIndex = 48;
            this.label9.Text = "Gelen Şifrelenmiş Mesaj";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(78, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Gelen Mesaj";
            // 
            // GelenMesajSifreli
            // 
            this.GelenMesajSifreli.Enabled = false;
            this.GelenMesajSifreli.Location = new System.Drawing.Point(281, 321);
            this.GelenMesajSifreli.Multiline = true;
            this.GelenMesajSifreli.Name = "GelenMesajSifreli";
            this.GelenMesajSifreli.Size = new System.Drawing.Size(200, 50);
            this.GelenMesajSifreli.TabIndex = 46;
            // 
            // GelenMesaj
            // 
            this.GelenMesaj.Enabled = false;
            this.GelenMesaj.Location = new System.Drawing.Point(20, 321);
            this.GelenMesaj.Multiline = true;
            this.GelenMesaj.Name = "GelenMesaj";
            this.GelenMesaj.Size = new System.Drawing.Size(200, 50);
            this.GelenMesaj.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Hedef Bilgileri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Benim Bilgilerim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Port";
            // 
            // BtnGonder
            // 
            this.BtnGonder.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnGonder.Enabled = false;
            this.BtnGonder.Location = new System.Drawing.Point(381, 244);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(100, 50);
            this.BtnGonder.TabIndex = 42;
            this.BtnGonder.Text = "Gönder";
            this.BtnGonder.UseVisualStyleBackColor = false;
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(331, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Şifrelenmiş Mesaj";
            // 
            // TxtUzakPort
            // 
            this.TxtUzakPort.Location = new System.Drawing.Point(291, 68);
            this.TxtUzakPort.Name = "TxtUzakPort";
            this.TxtUzakPort.Size = new System.Drawing.Size(143, 22);
            this.TxtUzakPort.TabIndex = 31;
            // 
            // GidenMesajSifreli
            // 
            this.GidenMesajSifreli.Enabled = false;
            this.GidenMesajSifreli.Location = new System.Drawing.Point(281, 188);
            this.GidenMesajSifreli.Multiline = true;
            this.GidenMesajSifreli.Name = "GidenMesajSifreli";
            this.GidenMesajSifreli.Size = new System.Drawing.Size(200, 50);
            this.GidenMesajSifreli.TabIndex = 40;
            // 
            // BtnSifreCoz
            // 
            this.BtnSifreCoz.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnSifreCoz.Enabled = false;
            this.BtnSifreCoz.Location = new System.Drawing.Point(260, 244);
            this.BtnSifreCoz.Name = "BtnSifreCoz";
            this.BtnSifreCoz.Size = new System.Drawing.Size(100, 50);
            this.BtnSifreCoz.TabIndex = 39;
            this.BtnSifreCoz.Text = "Şifreyiz Çöz";
            this.BtnSifreCoz.UseVisualStyleBackColor = false;
            this.BtnSifreCoz.Click += new System.EventHandler(this.BtnSifreCoz_Click);
            // 
            // BtnSifrele
            // 
            this.BtnSifrele.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnSifrele.Enabled = false;
            this.BtnSifrele.Location = new System.Drawing.Point(21, 244);
            this.BtnSifrele.Name = "BtnSifrele";
            this.BtnSifrele.Size = new System.Drawing.Size(100, 50);
            this.BtnSifrele.TabIndex = 38;
            this.BtnSifrele.Text = "Şifrele";
            this.BtnSifrele.UseVisualStyleBackColor = false;
            this.BtnSifrele.Click += new System.EventHandler(this.BtnSifrele_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "IP";
            // 
            // BtnTemizle
            // 
            this.BtnTemizle.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnTemizle.Enabled = false;
            this.BtnTemizle.Location = new System.Drawing.Point(138, 244);
            this.BtnTemizle.Name = "BtnTemizle";
            this.BtnTemizle.Size = new System.Drawing.Size(100, 50);
            this.BtnTemizle.TabIndex = 37;
            this.BtnTemizle.Text = "Temizle";
            this.BtnTemizle.UseVisualStyleBackColor = false;
            this.BtnTemizle.Click += new System.EventHandler(this.BtnTemizle_Click);
            // 
            // TxtBenimPort
            // 
            this.TxtBenimPort.Location = new System.Drawing.Point(83, 70);
            this.TxtBenimPort.Name = "TxtBenimPort";
            this.TxtBenimPort.Size = new System.Drawing.Size(143, 22);
            this.TxtBenimPort.TabIndex = 30;
            // 
            // GidenMesaj
            // 
            this.GidenMesaj.Enabled = false;
            this.GidenMesaj.Location = new System.Drawing.Point(20, 188);
            this.GidenMesaj.Multiline = true;
            this.GidenMesaj.Name = "GidenMesaj";
            this.GidenMesaj.Size = new System.Drawing.Size(200, 50);
            this.GidenMesaj.TabIndex = 35;
            // 
            // TxtUzakIP
            // 
            this.TxtUzakIP.Location = new System.Drawing.Point(291, 36);
            this.TxtUzakIP.Name = "TxtUzakIP";
            this.TxtUzakIP.Size = new System.Drawing.Size(143, 22);
            this.TxtUzakIP.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(93, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 34;
            this.label1.Text = "Mesaj";
            // 
            // BtnBaglan
            // 
            this.BtnBaglan.BackColor = System.Drawing.Color.Aquamarine;
            this.BtnBaglan.Location = new System.Drawing.Point(196, 106);
            this.BtnBaglan.Name = "BtnBaglan";
            this.BtnBaglan.Size = new System.Drawing.Size(113, 52);
            this.BtnBaglan.TabIndex = 36;
            this.BtnBaglan.Text = "Bağlan";
            this.BtnBaglan.UseVisualStyleBackColor = false;
            this.BtnBaglan.Click += new System.EventHandler(this.BtnBaglan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "IP";
            // 
            // TxtBenimIP
            // 
            this.TxtBenimIP.Location = new System.Drawing.Point(83, 38);
            this.TxtBenimIP.Name = "TxtBenimIP";
            this.TxtBenimIP.Size = new System.Drawing.Size(143, 22);
            this.TxtBenimIP.TabIndex = 26;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(502, 553);
            this.Controls.Add(this.LstbxGenelKonusma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GelenMesajSifreli);
            this.Controls.Add(this.GelenMesaj);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUzakPort);
            this.Controls.Add(this.GidenMesajSifreli);
            this.Controls.Add(this.BtnSifreCoz);
            this.Controls.Add(this.BtnSifrele);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnTemizle);
            this.Controls.Add(this.TxtBenimPort);
            this.Controls.Add(this.GidenMesaj);
            this.Controls.Add(this.TxtUzakIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBaglan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBenimIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnaForm";
            this.Text = "Soket İle Şifreli Mesajlaşma";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstbxGenelKonusma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox GelenMesajSifreli;
        private System.Windows.Forms.TextBox GelenMesaj;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnGonder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUzakPort;
        private System.Windows.Forms.TextBox GidenMesajSifreli;
        private System.Windows.Forms.Button BtnSifreCoz;
        private System.Windows.Forms.Button BtnSifrele;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnTemizle;
        private System.Windows.Forms.TextBox TxtBenimPort;
        private System.Windows.Forms.TextBox GidenMesaj;
        private System.Windows.Forms.TextBox TxtUzakIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBaglan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBenimIP;
    }
}

