namespace VoyageFramework.UI
{
    partial class frmDrivers
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
            this.components = new System.ComponentModel.Container();
            this.dtgvDrivers = new System.Windows.Forms.DataGridView();
            this.ctxDriver = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.mtbTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.chbKadin = new System.Windows.Forms.CheckBox();
            this.chbErkek = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLicencetype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDrivers
            // 
            this.dtgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDrivers.ContextMenuStrip = this.ctxDriver;
            this.dtgvDrivers.Location = new System.Drawing.Point(27, 340);
            this.dtgvDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDrivers.Name = "dtgvDrivers";
            this.dtgvDrivers.Size = new System.Drawing.Size(552, 263);
            this.dtgvDrivers.TabIndex = 22;
            // 
            // ctxDriver
            // 
            this.ctxDriver.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxDriver.Name = "ctxDriver";
            this.ctxDriver.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "TC KİMLİK NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "SOYADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "DOĞUM TARİHİ";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(444, 24);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(135, 69);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "ŞOFÖR EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(444, 176);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(135, 69);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "ŞOFÖR SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(444, 100);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 69);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "ŞOFÖR GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(185, 217);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(237, 30);
            this.dtpDogumTarihi.TabIndex = 28;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(188, 121);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(234, 30);
            this.txtSoyadi.TabIndex = 25;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(188, 71);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(234, 30);
            this.txtAdi.TabIndex = 24;
            // 
            // mtbTcKimlik
            // 
            this.mtbTcKimlik.Location = new System.Drawing.Point(188, 21);
            this.mtbTcKimlik.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTcKimlik.Name = "mtbTcKimlik";
            this.mtbTcKimlik.Size = new System.Drawing.Size(234, 30);
            this.mtbTcKimlik.TabIndex = 23;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(444, 252);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(135, 69);
            this.btnAnaMenu.TabIndex = 85;
            this.btnAnaMenu.Text = "ANA MENÜ";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 284);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 86;
            this.label3.Text = "CİNSİYET";
            // 
            // chbKadin
            // 
            this.chbKadin.AutoSize = true;
            this.chbKadin.Location = new System.Drawing.Point(345, 284);
            this.chbKadin.Margin = new System.Windows.Forms.Padding(4);
            this.chbKadin.Name = "chbKadin";
            this.chbKadin.Size = new System.Drawing.Size(77, 27);
            this.chbKadin.TabIndex = 88;
            this.chbKadin.Text = "KADIN";
            this.chbKadin.UseVisualStyleBackColor = true;
            // 
            // chbErkek
            // 
            this.chbErkek.AutoSize = true;
            this.chbErkek.Location = new System.Drawing.Point(188, 283);
            this.chbErkek.Margin = new System.Windows.Forms.Padding(4);
            this.chbErkek.Name = "chbErkek";
            this.chbErkek.Size = new System.Drawing.Size(78, 27);
            this.chbErkek.TabIndex = 87;
            this.chbErkek.Text = "ERKEK";
            this.chbErkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 89;
            this.label1.Text = "Licencetype";
            // 
            // cmbLicencetype
            // 
            this.cmbLicencetype.FormattingEnabled = true;
            this.cmbLicencetype.Location = new System.Drawing.Point(188, 173);
            this.cmbLicencetype.Name = "cmbLicencetype";
            this.cmbLicencetype.Size = new System.Drawing.Size(234, 30);
            this.cmbLicencetype.TabIndex = 90;
            // 
            // frmDrivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 618);
            this.Controls.Add(this.cmbLicencetype);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbKadin);
            this.Controls.Add(this.chbErkek);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.dtgvDrivers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.mtbTcKimlik);
            this.Font = new System.Drawing.Font("Impact", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDrivers";
            this.Text = "DRIVER";
            this.Load += new System.EventHandler(this.frmDrivers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDrivers;
        private System.Windows.Forms.ContextMenuStrip ctxDriver;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.MaskedTextBox mtbTcKimlik;
        private System.Windows.Forms.Button btnAnaMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbKadin;
        private System.Windows.Forms.CheckBox chbErkek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLicencetype;
    }
}