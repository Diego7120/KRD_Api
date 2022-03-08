namespace KRD_Api
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rad_cert = new System.Windows.Forms.RadioButton();
            this.rad_login = new System.Windows.Forms.RadioButton();
            this.gr_login = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.bt_spr_firme = new System.Windows.Forms.Button();
            this.br_spr_kons = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tx_numer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tx_results = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gr_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_login);
            this.groupBox1.Controls.Add(this.rad_cert);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metoda logowania";
            // 
            // rad_cert
            // 
            this.rad_cert.AutoSize = true;
            this.rad_cert.Location = new System.Drawing.Point(6, 19);
            this.rad_cert.Name = "rad_cert";
            this.rad_cert.Size = new System.Drawing.Size(69, 17);
            this.rad_cert.TabIndex = 0;
            this.rad_cert.TabStop = true;
            this.rad_cert.Text = "Certyfikat";
            this.rad_cert.UseVisualStyleBackColor = true;
            this.rad_cert.CheckedChanged += new System.EventHandler(this.rad_cert_CheckedChanged);
            // 
            // rad_login
            // 
            this.rad_login.AutoSize = true;
            this.rad_login.Location = new System.Drawing.Point(6, 43);
            this.rad_login.Name = "rad_login";
            this.rad_login.Size = new System.Drawing.Size(88, 17);
            this.rad_login.TabIndex = 1;
            this.rad_login.TabStop = true;
            this.rad_login.Text = "Login i Hasło";
            this.rad_login.UseVisualStyleBackColor = true;
            this.rad_login.CheckedChanged += new System.EventHandler(this.rad_login_CheckedChanged);
            // 
            // gr_login
            // 
            this.gr_login.Controls.Add(this.tb_pass);
            this.gr_login.Controls.Add(this.tb_login);
            this.gr_login.Controls.Add(this.label2);
            this.gr_login.Controls.Add(this.label1);
            this.gr_login.Location = new System.Drawing.Point(142, 12);
            this.gr_login.Name = "gr_login";
            this.gr_login.Size = new System.Drawing.Size(171, 72);
            this.gr_login.TabIndex = 2;
            this.gr_login.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(56, 16);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(100, 20);
            this.tb_login.TabIndex = 2;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(56, 40);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 3;
            // 
            // bt_spr_firme
            // 
            this.bt_spr_firme.Location = new System.Drawing.Point(12, 97);
            this.bt_spr_firme.Name = "bt_spr_firme";
            this.bt_spr_firme.Size = new System.Drawing.Size(123, 60);
            this.bt_spr_firme.TabIndex = 3;
            this.bt_spr_firme.Text = "Sprawdź Firmę";
            this.bt_spr_firme.UseVisualStyleBackColor = true;
            this.bt_spr_firme.Click += new System.EventHandler(this.bt_spr_firme_Click);
            // 
            // br_spr_kons
            // 
            this.br_spr_kons.Location = new System.Drawing.Point(141, 97);
            this.br_spr_kons.Name = "br_spr_kons";
            this.br_spr_kons.Size = new System.Drawing.Size(172, 60);
            this.br_spr_kons.TabIndex = 4;
            this.br_spr_kons.Text = "Sprawdź Konsumenta";
            this.br_spr_kons.UseVisualStyleBackColor = true;
            this.br_spr_kons.Click += new System.EventHandler(this.br_spr_kons_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numer";
            // 
            // tx_numer
            // 
            this.tx_numer.Location = new System.Drawing.Point(69, 168);
            this.tx_numer.Name = "tx_numer";
            this.tx_numer.Size = new System.Drawing.Size(243, 20);
            this.tx_numer.TabIndex = 6;
            this.tx_numer.Text = "1234567890";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data autoryzacji";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(29, 227);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // tx_results
            // 
            this.tx_results.Location = new System.Drawing.Point(320, 13);
            this.tx_results.Multiline = true;
            this.tx_results.Name = "tx_results";
            this.tx_results.Size = new System.Drawing.Size(658, 376);
            this.tx_results.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 401);
            this.Controls.Add(this.tx_results);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tx_numer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.br_spr_kons);
            this.Controls.Add(this.bt_spr_firme);
            this.Controls.Add(this.gr_login);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gr_login.ResumeLayout(false);
            this.gr_login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rad_login;
        private System.Windows.Forms.RadioButton rad_cert;
        private System.Windows.Forms.GroupBox gr_login;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button bt_spr_firme;
        private System.Windows.Forms.Button br_spr_kons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_numer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox tx_results;
    }
}

