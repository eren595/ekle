namespace ekle
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
            this.lbSayi = new System.Windows.Forms.ListBox();
            this.lbMetin = new System.Windows.Forms.ListBox();
            this.lbNesne = new System.Windows.Forms.ListBox();
            this.btnEkleSayi = new System.Windows.Forms.Button();
            this.btnEkleMetin = new System.Windows.Forms.Button();
            this.btnEkleNesne = new System.Windows.Forms.Button();
            this.txtAdSoyadN = new System.Windows.Forms.TextBox();
            this.txtNumaraN = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSayi
            // 
            this.lbSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayi.FormattingEnabled = true;
            this.lbSayi.ItemHeight = 20;
            this.lbSayi.Location = new System.Drawing.Point(166, 272);
            this.lbSayi.Name = "lbSayi";
            this.lbSayi.Size = new System.Drawing.Size(120, 84);
            this.lbSayi.TabIndex = 0;
            // 
            // lbMetin
            // 
            this.lbMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbMetin.FormattingEnabled = true;
            this.lbMetin.ItemHeight = 20;
            this.lbMetin.Location = new System.Drawing.Point(307, 272);
            this.lbMetin.Name = "lbMetin";
            this.lbMetin.Size = new System.Drawing.Size(120, 84);
            this.lbMetin.TabIndex = 1;
            // 
            // lbNesne
            // 
            this.lbNesne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbNesne.FormattingEnabled = true;
            this.lbNesne.ItemHeight = 20;
            this.lbNesne.Location = new System.Drawing.Point(451, 272);
            this.lbNesne.Name = "lbNesne";
            this.lbNesne.Size = new System.Drawing.Size(120, 84);
            this.lbNesne.TabIndex = 2;
            // 
            // btnEkleSayi
            // 
            this.btnEkleSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleSayi.Location = new System.Drawing.Point(424, 52);
            this.btnEkleSayi.Name = "btnEkleSayi";
            this.btnEkleSayi.Size = new System.Drawing.Size(75, 27);
            this.btnEkleSayi.TabIndex = 3;
            this.btnEkleSayi.Text = "Sayı Ekle";
            this.btnEkleSayi.UseVisualStyleBackColor = true;
            this.btnEkleSayi.Click += new System.EventHandler(this.btnEkleSayi_Click);
            // 
            // btnEkleMetin
            // 
            this.btnEkleMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleMetin.Location = new System.Drawing.Point(424, 78);
            this.btnEkleMetin.Name = "btnEkleMetin";
            this.btnEkleMetin.Size = new System.Drawing.Size(75, 29);
            this.btnEkleMetin.TabIndex = 4;
            this.btnEkleMetin.Text = "Metin Ekle";
            this.btnEkleMetin.UseVisualStyleBackColor = true;
            this.btnEkleMetin.Click += new System.EventHandler(this.btnEkleMetin_Click);
            // 
            // btnEkleNesne
            // 
            this.btnEkleNesne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleNesne.Location = new System.Drawing.Point(424, 113);
            this.btnEkleNesne.Name = "btnEkleNesne";
            this.btnEkleNesne.Size = new System.Drawing.Size(75, 29);
            this.btnEkleNesne.TabIndex = 5;
            this.btnEkleNesne.Text = "Nesne Ekle";
            this.btnEkleNesne.UseVisualStyleBackColor = true;
            this.btnEkleNesne.Click += new System.EventHandler(this.btnEkleNesne_Click);
            // 
            // txtAdSoyadN
            // 
            this.txtAdSoyadN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyadN.Location = new System.Drawing.Point(307, 130);
            this.txtAdSoyadN.Name = "txtAdSoyadN";
            this.txtAdSoyadN.Size = new System.Drawing.Size(100, 26);
            this.txtAdSoyadN.TabIndex = 6;
            // 
            // txtNumaraN
            // 
            this.txtNumaraN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumaraN.Location = new System.Drawing.Point(307, 104);
            this.txtNumaraN.Name = "txtNumaraN";
            this.txtNumaraN.Size = new System.Drawing.Size(100, 26);
            this.txtNumaraN.TabIndex = 7;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdSoyad.Location = new System.Drawing.Point(307, 78);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtAdSoyad.TabIndex = 8;
            // 
            // txtNumara
            // 
            this.txtNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNumara.Location = new System.Drawing.Point(307, 52);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(100, 26);
            this.txtNumara.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(213, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Numara:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(213, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ad Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(213, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Numara:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(213, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ad Soyad:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtNumaraN);
            this.Controls.Add(this.txtAdSoyadN);
            this.Controls.Add(this.btnEkleNesne);
            this.Controls.Add(this.btnEkleMetin);
            this.Controls.Add(this.btnEkleSayi);
            this.Controls.Add(this.lbNesne);
            this.Controls.Add(this.lbMetin);
            this.Controls.Add(this.lbSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayi;
        private System.Windows.Forms.ListBox lbMetin;
        private System.Windows.Forms.ListBox lbNesne;
        private System.Windows.Forms.Button btnEkleSayi;
        private System.Windows.Forms.Button btnEkleMetin;
        private System.Windows.Forms.Button btnEkleNesne;
        private System.Windows.Forms.TextBox txtAdSoyadN;
        private System.Windows.Forms.TextBox txtNumaraN;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtNumara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

