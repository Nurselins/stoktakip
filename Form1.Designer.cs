namespace Stoktakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.Label();
            this.txtTc = new System.Windows.Forms.Label();
            this.txtTelefon1 = new System.Windows.Forms.TextBox();
            this.txtAdSoyad1 = new System.Windows.Forms.TextBox();
            this.txtTc1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtMiktari = new System.Windows.Forms.TextBox();
            this.txtÜrünAdı = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(294, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(807, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.txtTelefon1);
            this.groupBox1.Controls.Add(this.txtAdSoyad1);
            this.groupBox1.Controls.Add(this.txtTc1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.AutoSize = true;
            this.txtTelefon.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtTelefon.Location = new System.Drawing.Point(6, 111);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(59, 20);
            this.txtTelefon.TabIndex = 5;
            this.txtTelefon.Text = "Telefon";
            this.txtTelefon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.AutoSize = true;
            this.txtAdSoyad.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtAdSoyad.Location = new System.Drawing.Point(6, 82);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(76, 20);
            this.txtAdSoyad.TabIndex = 4;
            this.txtAdSoyad.Text = "Ad-Soyad";
            // 
            // txtTc
            // 
            this.txtTc.AutoSize = true;
            this.txtTc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txtTc.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtTc.Location = new System.Drawing.Point(6, 49);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(82, 20);
            this.txtTc.TabIndex = 3;
            this.txtTc.Text = "Müşteri TC";
            // 
            // txtTelefon1
            // 
            this.txtTelefon1.Location = new System.Drawing.Point(108, 108);
            this.txtTelefon1.Name = "txtTelefon1";
            this.txtTelefon1.Size = new System.Drawing.Size(125, 27);
            this.txtTelefon1.TabIndex = 2;
            this.txtTelefon1.TextChanged += new System.EventHandler(this.txtTelefon1_TextChanged);
            // 
            // txtAdSoyad1
            // 
            this.txtAdSoyad1.Location = new System.Drawing.Point(108, 75);
            this.txtAdSoyad1.Name = "txtAdSoyad1";
            this.txtAdSoyad1.Size = new System.Drawing.Size(125, 27);
            this.txtAdSoyad1.TabIndex = 1;
            this.txtAdSoyad1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTc1
            // 
            this.txtTc1.Location = new System.Drawing.Point(108, 42);
            this.txtTc1.Name = "txtTc1";
            this.txtTc1.Size = new System.Drawing.Size(125, 27);
            this.txtTc1.TabIndex = 0;
            this.txtTc1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.txtSatışFiyatı);
            this.groupBox2.Controls.Add(this.txtMiktari);
            this.groupBox2.Controls.Add(this.txtÜrünAdı);
            this.groupBox2.Controls.Add(this.txtBarkod);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 200);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(6, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Toplam Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Miktarı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Barkod No";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(108, 167);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(125, 27);
            this.txtToplamFiyat.TabIndex = 7;
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(108, 134);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(125, 27);
            this.txtSatışFiyatı.TabIndex = 6;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // txtMiktari
            // 
            this.txtMiktari.Location = new System.Drawing.Point(108, 101);
            this.txtMiktari.Name = "txtMiktari";
            this.txtMiktari.Size = new System.Drawing.Size(125, 27);
            this.txtMiktari.TabIndex = 5;
            this.txtMiktari.Text = "1";
            this.txtMiktari.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktari.TextChanged += new System.EventHandler(this.txtMiktari_TextChanged);
            // 
            // txtÜrünAdı
            // 
            this.txtÜrünAdı.Location = new System.Drawing.Point(108, 68);
            this.txtÜrünAdı.Name = "txtÜrünAdı";
            this.txtÜrünAdı.Size = new System.Drawing.Size(125, 27);
            this.txtÜrünAdı.TabIndex = 4;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(108, 35);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(125, 27);
            this.txtBarkod.TabIndex = 3;
            this.txtBarkod.TextChanged += new System.EventHandler(this.txtBarkod_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnEkle.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(103, 467);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 40);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSil.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(1107, 139);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 29);
            this.btnSil.TabIndex = 13;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSatışİptal.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatışİptal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSatışİptal.Location = new System.Drawing.Point(1107, 174);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(94, 35);
            this.btnSatışİptal.TabIndex = 14;
            this.btnSatışİptal.Text = "Satış İptal";
            this.btnSatışİptal.UseVisualStyleBackColor = false;
            this.btnSatışİptal.Click += new System.EventHandler(this.btnSatışİptal_Click);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnSatışYap.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSatışYap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSatışYap.Location = new System.Drawing.Point(1015, 455);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(86, 29);
            this.btnSatışYap.TabIndex = 15;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = false;
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(692, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Genel Toplam :";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(3, 0);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 20);
            this.lblGenelToplam.TabIndex = 17;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MidnightBlue;
            this.button5.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(18, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 76);
            this.button5.TabIndex = 0;
            this.button5.Text = "Müşteri Ekleme";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.Location = new System.Drawing.Point(278, 26);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 76);
            this.button6.TabIndex = 1;
            this.button6.Text = "Müşteri Listeleme";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MidnightBlue;
            this.button7.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(137, 26);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(124, 76);
            this.button7.TabIndex = 2;
            this.button7.Text = "Ürün Ekleme";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkRed;
            this.button8.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(415, 26);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 76);
            this.button8.TabIndex = 3;
            this.button8.Text = "Ürün Listeleme";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DarkRed;
            this.button9.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(494, 467);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(139, 55);
            this.button9.TabIndex = 4;
            this.button9.Text = "Satış Listeleme";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Stoktakip.Properties.Resources._1;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 102);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1002, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 68);
            this.button2.TabIndex = 6;
            this.button2.Text = "Marka";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("Impact", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(910, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kategori";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::Stoktakip.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(1248, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private Label txtTelefon;
        private Label txtAdSoyad;
        private Label txtTc;
        private TextBox txtTelefon1;
        private TextBox txtAdSoyad1;
        private TextBox txtTc1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtToplamFiyat;
        private TextBox txtSatışFiyatı;
        private TextBox txtMiktari;
        private TextBox txtÜrünAdı;
        private TextBox txtBarkod;
        private Button btnEkle;
        private Button btnSil;
        private Button btnSatışİptal;
        private Button btnSatışYap;
        private Label label9;
        private Label lblGenelToplam;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Panel panel1;
        private Button button2;
        private Button button1;
    }
}