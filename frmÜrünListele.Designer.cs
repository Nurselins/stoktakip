namespace Stoktakip
{
    partial class frmÜrünListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SatışFiyatıTxt = new System.Windows.Forms.TextBox();
            this.AlışFiyatıTxt = new System.Windows.Forms.TextBox();
            this.MiktarıTxt = new System.Windows.Forms.TextBox();
            this.ÜrünAdıTxt = new System.Windows.Forms.TextBox();
            this.MarkaTxt = new System.Windows.Forms.TextBox();
            this.KategoriTxt = new System.Windows.Forms.TextBox();
            this.BarkodNoTxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMarkaGüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(273, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 314);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGüncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGüncelle.Location = new System.Drawing.Point(147, 415);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(94, 41);
            this.btnGüncelle.TabIndex = 44;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(30, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 21);
            this.label8.TabIndex = 43;
            this.label8.Text = "Satış Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(30, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Alış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(34, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 21);
            this.label10.TabIndex = 41;
            this.label10.Text = "Miktarı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(30, 230);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(34, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "Marka";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(30, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 21);
            this.label13.TabIndex = 38;
            this.label13.Text = "Kategori";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(30, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 21);
            this.label14.TabIndex = 37;
            this.label14.Text = "Barkod No";
            // 
            // SatışFiyatıTxt
            // 
            this.SatışFiyatıTxt.Location = new System.Drawing.Point(116, 371);
            this.SatışFiyatıTxt.Name = "SatışFiyatıTxt";
            this.SatışFiyatıTxt.Size = new System.Drawing.Size(125, 28);
            this.SatışFiyatıTxt.TabIndex = 36;
            // 
            // AlışFiyatıTxt
            // 
            this.AlışFiyatıTxt.Location = new System.Drawing.Point(116, 324);
            this.AlışFiyatıTxt.Name = "AlışFiyatıTxt";
            this.AlışFiyatıTxt.Size = new System.Drawing.Size(125, 28);
            this.AlışFiyatıTxt.TabIndex = 35;
            // 
            // MiktarıTxt
            // 
            this.MiktarıTxt.Location = new System.Drawing.Point(116, 280);
            this.MiktarıTxt.Name = "MiktarıTxt";
            this.MiktarıTxt.Size = new System.Drawing.Size(125, 28);
            this.MiktarıTxt.TabIndex = 34;
            // 
            // ÜrünAdıTxt
            // 
            this.ÜrünAdıTxt.Location = new System.Drawing.Point(116, 223);
            this.ÜrünAdıTxt.Name = "ÜrünAdıTxt";
            this.ÜrünAdıTxt.Size = new System.Drawing.Size(125, 28);
            this.ÜrünAdıTxt.TabIndex = 33;
            // 
            // MarkaTxt
            // 
            this.MarkaTxt.Location = new System.Drawing.Point(116, 173);
            this.MarkaTxt.Name = "MarkaTxt";
            this.MarkaTxt.ReadOnly = true;
            this.MarkaTxt.Size = new System.Drawing.Size(125, 28);
            this.MarkaTxt.TabIndex = 32;
            // 
            // KategoriTxt
            // 
            this.KategoriTxt.Location = new System.Drawing.Point(116, 129);
            this.KategoriTxt.Name = "KategoriTxt";
            this.KategoriTxt.ReadOnly = true;
            this.KategoriTxt.Size = new System.Drawing.Size(125, 28);
            this.KategoriTxt.TabIndex = 31;
            // 
            // BarkodNoTxt
            // 
            this.BarkodNoTxt.Location = new System.Drawing.Point(116, 85);
            this.BarkodNoTxt.Name = "BarkodNoTxt";
            this.BarkodNoTxt.Size = new System.Drawing.Size(125, 28);
            this.BarkodNoTxt.TabIndex = 30;
            this.BarkodNoTxt.TextChanged += new System.EventHandler(this.BarkodNoTxt_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(1191, 413);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 30);
            this.btnSil.TabIndex = 45;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(743, 37);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(125, 28);
            this.txtBarkodNoAra.TabIndex = 46;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(512, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "BarkodNo ya Göre Arama";
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(622, 415);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(151, 29);
            this.comboKategori.TabIndex = 48;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(622, 457);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(151, 29);
            this.comboMarka.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(522, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(522, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "Kategori";
            // 
            // btnMarkaGüncelle
            // 
            this.btnMarkaGüncelle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMarkaGüncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMarkaGüncelle.Location = new System.Drawing.Point(801, 413);
            this.btnMarkaGüncelle.Name = "btnMarkaGüncelle";
            this.btnMarkaGüncelle.Size = new System.Drawing.Size(116, 56);
            this.btnMarkaGüncelle.TabIndex = 52;
            this.btnMarkaGüncelle.Text = "Marka Güncelle";
            this.btnMarkaGüncelle.UseVisualStyleBackColor = false;
            this.btnMarkaGüncelle.Click += new System.EventHandler(this.btnMarkaGüncelle_Click);
            // 
            // frmÜrünListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1297, 550);
            this.Controls.Add(this.btnMarkaGüncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.SatışFiyatıTxt);
            this.Controls.Add(this.AlışFiyatıTxt);
            this.Controls.Add(this.MiktarıTxt);
            this.Controls.Add(this.ÜrünAdıTxt);
            this.Controls.Add(this.MarkaTxt);
            this.Controls.Add(this.KategoriTxt);
            this.Controls.Add(this.BarkodNoTxt);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmÜrünListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmÜrünListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGüncelle;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox SatışFiyatıTxt;
        private TextBox AlışFiyatıTxt;
        private TextBox MiktarıTxt;
        private TextBox ÜrünAdıTxt;
        private TextBox MarkaTxt;
        private TextBox KategoriTxt;
        private TextBox BarkodNoTxt;
        private Button btnSil;
        private TextBox txtBarkodNoAra;
        private Label label1;
        private ComboBox comboKategori;
        private ComboBox comboMarka;
        private Label label2;
        private Label label3;
        private Button btnMarkaGüncelle;
    }
}