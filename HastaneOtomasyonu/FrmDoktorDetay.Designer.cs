namespace HastaneOtomasyonu
{
    partial class FrmDoktorDetay
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
            System.Windows.Forms.GroupBox randevuDetay;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.rchSikayet = new System.Windows.Forms.RichTextBox();
            this.doktorBilgi = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.randevuListesi = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hizliErisim = new System.Windows.Forms.GroupBox();
            this.btnDuyurular = new System.Windows.Forms.Button();
            this.btnBilgiDüzenle = new System.Windows.Forms.Button();
            randevuDetay = new System.Windows.Forms.GroupBox();
            randevuDetay.SuspendLayout();
            this.doktorBilgi.SuspendLayout();
            this.randevuListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.hizliErisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // randevuDetay
            // 
            randevuDetay.BackColor = System.Drawing.Color.DarkCyan;
            randevuDetay.Controls.Add(this.rchSikayet);
            randevuDetay.ForeColor = System.Drawing.SystemColors.Window;
            randevuDetay.Location = new System.Drawing.Point(12, 191);
            randevuDetay.Name = "randevuDetay";
            randevuDetay.Size = new System.Drawing.Size(320, 452);
            randevuDetay.TabIndex = 1;
            randevuDetay.TabStop = false;
            randevuDetay.Text = "Randevu Detay";
            // 
            // rchSikayet
            // 
            this.rchSikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchSikayet.Location = new System.Drawing.Point(3, 30);
            this.rchSikayet.Name = "rchSikayet";
            this.rchSikayet.Size = new System.Drawing.Size(314, 419);
            this.rchSikayet.TabIndex = 19;
            this.rchSikayet.Text = "";
            // 
            // doktorBilgi
            // 
            this.doktorBilgi.BackColor = System.Drawing.Color.DarkCyan;
            this.doktorBilgi.Controls.Add(this.lblAdSoyad);
            this.doktorBilgi.Controls.Add(this.label11);
            this.doktorBilgi.Controls.Add(this.lblTC);
            this.doktorBilgi.Controls.Add(this.label10);
            this.doktorBilgi.ForeColor = System.Drawing.SystemColors.Window;
            this.doktorBilgi.Location = new System.Drawing.Point(12, 7);
            this.doktorBilgi.Name = "doktorBilgi";
            this.doktorBilgi.Size = new System.Drawing.Size(320, 178);
            this.doktorBilgi.TabIndex = 0;
            this.doktorBilgi.TabStop = false;
            this.doktorBilgi.Text = "Doktor Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(156, 89);
            this.lblAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(105, 29);
            this.lblAdSoyad.TabIndex = 17;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 29);
            this.label11.TabIndex = 16;
            this.label11.Text = "Ad - Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(109, 47);
            this.lblTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(156, 29);
            this.lblTC.TabIndex = 15;
            this.lblTC.Text = "00000000000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 47);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "TC No:";
            // 
            // randevuListesi
            // 
            this.randevuListesi.BackColor = System.Drawing.Color.DarkCyan;
            this.randevuListesi.Controls.Add(this.dataGridView1);
            this.randevuListesi.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.randevuListesi.Location = new System.Drawing.Point(338, 7);
            this.randevuListesi.Name = "randevuListesi";
            this.randevuListesi.Size = new System.Drawing.Size(1197, 781);
            this.randevuListesi.TabIndex = 2;
            this.randevuListesi.TabStop = false;
            this.randevuListesi.Text = "Randevu Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 748);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hizliErisim
            // 
            this.hizliErisim.BackColor = System.Drawing.Color.DarkCyan;
            this.hizliErisim.Controls.Add(this.btnDuyurular);
            this.hizliErisim.Controls.Add(this.btnBilgiDüzenle);
            this.hizliErisim.ForeColor = System.Drawing.SystemColors.Window;
            this.hizliErisim.Location = new System.Drawing.Point(12, 649);
            this.hizliErisim.Name = "hizliErisim";
            this.hizliErisim.Size = new System.Drawing.Size(317, 136);
            this.hizliErisim.TabIndex = 3;
            this.hizliErisim.TabStop = false;
            this.hizliErisim.Text = "Hızlı Erişim";
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnDuyurular.Location = new System.Drawing.Point(6, 80);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(305, 41);
            this.btnDuyurular.TabIndex = 1;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.UseVisualStyleBackColor = true;
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // btnBilgiDüzenle
            // 
            this.btnBilgiDüzenle.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btnBilgiDüzenle.Location = new System.Drawing.Point(6, 33);
            this.btnBilgiDüzenle.Name = "btnBilgiDüzenle";
            this.btnBilgiDüzenle.Size = new System.Drawing.Size(305, 41);
            this.btnBilgiDüzenle.TabIndex = 0;
            this.btnBilgiDüzenle.Text = "Bilgi Düzenle";
            this.btnBilgiDüzenle.UseVisualStyleBackColor = true;
            this.btnBilgiDüzenle.Click += new System.EventHandler(this.btnBilgiDüzenle_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1547, 1033);
            this.Controls.Add(this.hizliErisim);
            this.Controls.Add(this.randevuListesi);
            this.Controls.Add(randevuDetay);
            this.Controls.Add(this.doktorBilgi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmDoktorDetay";
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            randevuDetay.ResumeLayout(false);
            this.doktorBilgi.ResumeLayout(false);
            this.doktorBilgi.PerformLayout();
            this.randevuListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.hizliErisim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox doktorBilgi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox randevuListesi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rchSikayet;
        private System.Windows.Forms.GroupBox hizliErisim;
        private System.Windows.Forms.Button btnDuyurular;
        private System.Windows.Forms.Button btnBilgiDüzenle;
    }
}