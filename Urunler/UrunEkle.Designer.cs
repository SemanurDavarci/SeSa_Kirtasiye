namespace SeSa_Kirtasiye
{
    partial class UrunEkle
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
            this.urunEkleTamam = new System.Windows.Forms.Button();
            this.urunEkleIptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detayTextBox = new System.Windows.Forms.RichTextBox();
            this.stokMiktariTextBox = new System.Windows.Forms.TextBox();
            this.birimFiyatTextBox = new System.Windows.Forms.TextBox();
            this.kategoriTextBox = new System.Windows.Forms.TextBox();
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.kategoriSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // urunEkleTamam
            // 
            this.urunEkleTamam.Location = new System.Drawing.Point(300, 377);
            this.urunEkleTamam.Name = "urunEkleTamam";
            this.urunEkleTamam.Size = new System.Drawing.Size(75, 23);
            this.urunEkleTamam.TabIndex = 24;
            this.urunEkleTamam.Text = "Tamam";
            this.urunEkleTamam.UseVisualStyleBackColor = true;
            this.urunEkleTamam.Click += new System.EventHandler(this.urunEkleTamam_Click);
            // 
            // urunEkleIptal
            // 
            this.urunEkleIptal.Location = new System.Drawing.Point(381, 377);
            this.urunEkleIptal.Name = "urunEkleIptal";
            this.urunEkleIptal.Size = new System.Drawing.Size(75, 23);
            this.urunEkleIptal.TabIndex = 23;
            this.urunEkleIptal.Text = "İptal";
            this.urunEkleIptal.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Detay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Stok Miktarı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Birim Fiyat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Ürün Adı";
            // 
            // detayTextBox
            // 
            this.detayTextBox.Location = new System.Drawing.Point(91, 227);
            this.detayTextBox.Name = "detayTextBox";
            this.detayTextBox.Size = new System.Drawing.Size(236, 95);
            this.detayTextBox.TabIndex = 17;
            this.detayTextBox.Text = "";
            // 
            // stokMiktariTextBox
            // 
            this.stokMiktariTextBox.Location = new System.Drawing.Point(91, 180);
            this.stokMiktariTextBox.Name = "stokMiktariTextBox";
            this.stokMiktariTextBox.Size = new System.Drawing.Size(236, 20);
            this.stokMiktariTextBox.TabIndex = 16;
            // 
            // birimFiyatTextBox
            // 
            this.birimFiyatTextBox.Location = new System.Drawing.Point(91, 134);
            this.birimFiyatTextBox.Name = "birimFiyatTextBox";
            this.birimFiyatTextBox.Size = new System.Drawing.Size(236, 20);
            this.birimFiyatTextBox.TabIndex = 15;
            // 
            // kategoriTextBox
            // 
            this.kategoriTextBox.Location = new System.Drawing.Point(91, 93);
            this.kategoriTextBox.Name = "kategoriTextBox";
            this.kategoriTextBox.ReadOnly = true;
            this.kategoriTextBox.Size = new System.Drawing.Size(236, 20);
            this.kategoriTextBox.TabIndex = 14;
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.Location = new System.Drawing.Point(91, 50);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.Size = new System.Drawing.Size(236, 20);
            this.urunAdiTextBox.TabIndex = 13;
            // 
            // kategoriSec
            // 
            this.kategoriSec.Location = new System.Drawing.Point(340, 91);
            this.kategoriSec.Name = "kategoriSec";
            this.kategoriSec.Size = new System.Drawing.Size(116, 23);
            this.kategoriSec.TabIndex = 25;
            this.kategoriSec.Text = "Kategori Seç";
            this.kategoriSec.UseVisualStyleBackColor = true;
            this.kategoriSec.Click += new System.EventHandler(this.kategoriSec_Click);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 451);
            this.Controls.Add(this.kategoriSec);
            this.Controls.Add(this.urunEkleTamam);
            this.Controls.Add(this.urunEkleIptal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detayTextBox);
            this.Controls.Add(this.stokMiktariTextBox);
            this.Controls.Add(this.birimFiyatTextBox);
            this.Controls.Add(this.kategoriTextBox);
            this.Controls.Add(this.urunAdiTextBox);
            this.Name = "UrunEkle";
            this.Text = "UrunEkle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button urunEkleTamam;
        private System.Windows.Forms.Button urunEkleIptal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox detayTextBox;
        private System.Windows.Forms.TextBox stokMiktariTextBox;
        private System.Windows.Forms.TextBox birimFiyatTextBox;
        private System.Windows.Forms.TextBox kategoriTextBox;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.Button kategoriSec;
    }
}