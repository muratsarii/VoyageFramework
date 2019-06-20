namespace VoyageFramework.UI
{
    partial class frmHosts
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
            this.ctxHost = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.brnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.chbKadin = new System.Windows.Forms.CheckBox();
            this.chbErkek = new System.Windows.Forms.CheckBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.mtbTcKimlik = new System.Windows.Forms.MaskedTextBox();
            this.btnAnaMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDrivers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDrivers
            // 
            this.dtgvDrivers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDrivers.ContextMenuStrip = this.ctxHost;
            this.dtgvDrivers.Location = new System.Drawing.Point(27, 343);
            this.dtgvDrivers.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDrivers.Name = "dtgvDrivers";
            this.dtgvDrivers.Size = new System.Drawing.Size(554, 263);
            this.dtgvDrivers.TabIndex = 37;
            // 
            // ctxHost
            // 
            this.ctxHost.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxHost.Name = "ctxDriver";
            this.ctxHost.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "TC KİMLİK NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "SOYADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "CİNSİYET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "DOĞUM TARİHİ";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(446, 24);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(135, 69);
            this.btnEkle.TabIndex = 31;
            this.btnEkle.Text = "HOST EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // brnSil
            // 
            this.brnSil.Location = new System.Drawing.Point(446, 178);
            this.brnSil.Margin = new System.Windows.Forms.Padding(4);
            this.brnSil.Name = "brnSil";
            this.brnSil.Size = new System.Drawing.Size(135, 69);
            this.brnSil.TabIndex = 45;
            this.brnSil.Text = "HOST SİL";
            this.brnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(446, 101);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(135, 69);
            this.btnGuncelle.TabIndex = 44;
            this.btnGuncelle.Text = "HOST GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(184, 285);
            this.dtpDogumTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(237, 30);
            this.dtpDogumTarihi.TabIndex = 43;
            // 
            // chbKadin
            // 
            this.chbKadin.AutoSize = true;
            this.chbKadin.Location = new System.Drawing.Point(338, 224);
            this.chbKadin.Margin = new System.Windows.Forms.Padding(4);
            this.chbKadin.Name = "chbKadin";
            this.chbKadin.Size = new System.Drawing.Size(77, 27);
            this.chbKadin.TabIndex = 42;
            this.chbKadin.Text = "KADIN";
            this.chbKadin.UseVisualStyleBackColor = true;
            // 
            // chbErkek
            // 
            this.chbErkek.AutoSize = true;
            this.chbErkek.Location = new System.Drawing.Point(185, 224);
            this.chbErkek.Margin = new System.Windows.Forms.Padding(4);
            this.chbErkek.Name = "chbErkek";
            this.chbErkek.Size = new System.Drawing.Size(78, 27);
            this.chbErkek.TabIndex = 41;
            this.chbErkek.Text = "ERKEK";
            this.chbErkek.UseVisualStyleBackColor = true;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(185, 156);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(234, 30);
            this.txtSoyadi.TabIndex = 40;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(185, 90);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(234, 30);
            this.txtAdi.TabIndex = 39;
            // 
            // mtbTcKimlik
            // 
            this.mtbTcKimlik.Location = new System.Drawing.Point(185, 24);
            this.mtbTcKimlik.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTcKimlik.Name = "mtbTcKimlik";
            this.mtbTcKimlik.Size = new System.Drawing.Size(234, 30);
            this.mtbTcKimlik.TabIndex = 38;
            // 
            // btnAnaMenu
            // 
            this.btnAnaMenu.Location = new System.Drawing.Point(446, 255);
            this.btnAnaMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnaMenu.Name = "btnAnaMenu";
            this.btnAnaMenu.Size = new System.Drawing.Size(135, 69);
            this.btnAnaMenu.TabIndex = 85;
            this.btnAnaMenu.Text = "ANA MENÜ";
            this.btnAnaMenu.UseVisualStyleBackColor = true;
            this.btnAnaMenu.Click += new System.EventHandler(this.btnAnaMenu_Click);
            // 
            // frmHosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 618);
            this.Controls.Add(this.btnAnaMenu);
            this.Controls.Add(this.dtgvDrivers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.brnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.chbKadin);
            this.Controls.Add(this.chbErkek);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.mtbTcKimlik);
            this.Font = new System.Drawing.Font("Impact", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHosts";
            this.Text = "HOST";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDrivers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDrivers;
        private System.Windows.Forms.ContextMenuStrip ctxHost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button brnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.CheckBox chbKadin;
        private System.Windows.Forms.CheckBox chbErkek;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.MaskedTextBox mtbTcKimlik;
        private System.Windows.Forms.Button btnAnaMenu;
    }
}