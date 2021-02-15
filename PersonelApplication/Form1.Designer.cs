namespace PersonelApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbPersonel = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.cbUnvan = new System.Windows.Forms.ComboBox();
            this.dtpİseGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAdres = new System.Windows.Forms.TextBox();
            this.tbEMail = new System.Windows.Forms.TextBox();
            this.tbSoyad = new System.Windows.Forms.TextBox();
            this.tbAd = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.mtbTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtbTCKNo = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvTCKNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvİseGirisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvTelefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvEMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPersonel
            // 
            this.gbPersonel.Controls.Add(this.btnSil);
            this.gbPersonel.Controls.Add(this.btnGuncelle);
            this.gbPersonel.Controls.Add(this.btnEkle);
            this.gbPersonel.Controls.Add(this.btnResimSec);
            this.gbPersonel.Controls.Add(this.cbUnvan);
            this.gbPersonel.Controls.Add(this.dtpİseGirisTarihi);
            this.gbPersonel.Controls.Add(this.pbResim);
            this.gbPersonel.Controls.Add(this.label9);
            this.gbPersonel.Controls.Add(this.label8);
            this.gbPersonel.Controls.Add(this.tbAdres);
            this.gbPersonel.Controls.Add(this.tbEMail);
            this.gbPersonel.Controls.Add(this.tbSoyad);
            this.gbPersonel.Controls.Add(this.tbAd);
            this.gbPersonel.Controls.Add(this.dtpDogumTarihi);
            this.gbPersonel.Controls.Add(this.mtbTelefon);
            this.gbPersonel.Controls.Add(this.mtbTCKNo);
            this.gbPersonel.Controls.Add(this.label7);
            this.gbPersonel.Controls.Add(this.label6);
            this.gbPersonel.Controls.Add(this.label5);
            this.gbPersonel.Controls.Add(this.label4);
            this.gbPersonel.Controls.Add(this.label3);
            this.gbPersonel.Controls.Add(this.label2);
            this.gbPersonel.Controls.Add(this.label1);
            this.gbPersonel.Location = new System.Drawing.Point(12, 12);
            this.gbPersonel.Name = "gbPersonel";
            this.gbPersonel.Size = new System.Drawing.Size(882, 369);
            this.gbPersonel.TabIndex = 0;
            this.gbPersonel.TabStop = false;
            this.gbPersonel.Text = "Personel Bilgileri";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(617, 294);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(251, 55);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(617, 230);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(251, 58);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(617, 168);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(251, 56);
            this.btnEkle.TabIndex = 20;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(617, 104);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(251, 58);
            this.btnResimSec.TabIndex = 19;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // cbUnvan
            // 
            this.cbUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnvan.FormattingEnabled = true;
            this.cbUnvan.Location = new System.Drawing.Point(539, 70);
            this.cbUnvan.Name = "cbUnvan";
            this.cbUnvan.Size = new System.Drawing.Size(329, 28);
            this.cbUnvan.TabIndex = 18;
            // 
            // dtpİseGirisTarihi
            // 
            this.dtpİseGirisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpİseGirisTarihi.Location = new System.Drawing.Point(539, 28);
            this.dtpİseGirisTarihi.Name = "dtpİseGirisTarihi";
            this.dtpİseGirisTarihi.Size = new System.Drawing.Size(329, 26);
            this.dtpİseGirisTarihi.TabIndex = 17;
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbResim.Location = new System.Drawing.Point(399, 104);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(196, 245);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 16;
            this.pbResim.TabStop = false;
            this.pbResim.WaitOnLoad = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ünvan :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(395, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "İşe Giriş Tarihi :";
            // 
            // tbAdres
            // 
            this.tbAdres.Location = new System.Drawing.Point(145, 291);
            this.tbAdres.Name = "tbAdres";
            this.tbAdres.Size = new System.Drawing.Size(221, 26);
            this.tbAdres.TabIndex = 13;
            // 
            // tbEMail
            // 
            this.tbEMail.Location = new System.Drawing.Point(145, 246);
            this.tbEMail.Name = "tbEMail";
            this.tbEMail.Size = new System.Drawing.Size(221, 26);
            this.tbEMail.TabIndex = 12;
            this.tbEMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEMail_KeyPress);
            // 
            // tbSoyad
            // 
            this.tbSoyad.Location = new System.Drawing.Point(145, 115);
            this.tbSoyad.Name = "tbSoyad";
            this.tbSoyad.Size = new System.Drawing.Size(221, 26);
            this.tbSoyad.TabIndex = 11;
            this.tbSoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSoyad_KeyPress);
            // 
            // tbAd
            // 
            this.tbAd.Location = new System.Drawing.Point(145, 72);
            this.tbAd.Name = "tbAd";
            this.tbAd.Size = new System.Drawing.Size(221, 26);
            this.tbAd.TabIndex = 10;
            this.tbAd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAd_KeyPress);
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(145, 158);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(221, 26);
            this.dtpDogumTarihi.TabIndex = 9;
            // 
            // mtbTelefon
            // 
            this.mtbTelefon.Location = new System.Drawing.Point(145, 204);
            this.mtbTelefon.Mask = "(999) 000-0000";
            this.mtbTelefon.Name = "mtbTelefon";
            this.mtbTelefon.Size = new System.Drawing.Size(221, 26);
            this.mtbTelefon.TabIndex = 8;
            // 
            // mtbTCKNo
            // 
            this.mtbTCKNo.BeepOnError = true;
            this.mtbTCKNo.Location = new System.Drawing.Point(145, 28);
            this.mtbTCKNo.Mask = "00000000000";
            this.mtbTCKNo.Name = "mtbTCKNo";
            this.mtbTCKNo.Size = new System.Drawing.Size(221, 26);
            this.mtbTCKNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Adres :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-Mail :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefon :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kmlik No :";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvTCKNo,
            this.lvAd,
            this.lvSoyad,
            this.lvİseGirisTarihi,
            this.lvTelefon,
            this.lvEMail});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 387);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(882, 299);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // lvTCKNo
            // 
            this.lvTCKNo.Text = "TC Kimlik No";
            this.lvTCKNo.Width = 148;
            // 
            // lvAd
            // 
            this.lvAd.Text = "Ad";
            this.lvAd.Width = 107;
            // 
            // lvSoyad
            // 
            this.lvSoyad.Text = "Soyad";
            this.lvSoyad.Width = 119;
            // 
            // lvİseGirisTarihi
            // 
            this.lvİseGirisTarihi.Text = "İşe Giriş Tarihi";
            this.lvİseGirisTarihi.Width = 178;
            // 
            // lvTelefon
            // 
            this.lvTelefon.Text = "Telefon";
            this.lvTelefon.Width = 138;
            // 
            // lvEMail
            // 
            this.lvEMail.Text = "E-Mail";
            this.lvEMail.Width = 560;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 702);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.gbPersonel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbPersonel.ResumeLayout(false);
            this.gbPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonel;
        private System.Windows.Forms.TextBox tbAdres;
        private System.Windows.Forms.TextBox tbEMail;
        private System.Windows.Forms.TextBox tbSoyad;
        private System.Windows.Forms.TextBox tbAd;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.MaskedTextBox mtbTelefon;
        private System.Windows.Forms.MaskedTextBox mtbTCKNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUnvan;
        private System.Windows.Forms.DateTimePicker dtpİseGirisTarihi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader lvTCKNo;
        private System.Windows.Forms.ColumnHeader lvAd;
        private System.Windows.Forms.ColumnHeader lvSoyad;
        private System.Windows.Forms.ColumnHeader lvİseGirisTarihi;
        private System.Windows.Forms.ColumnHeader lvTelefon;
        private System.Windows.Forms.ColumnHeader lvEMail;
        public System.Windows.Forms.PictureBox pbResim;
    }
}

