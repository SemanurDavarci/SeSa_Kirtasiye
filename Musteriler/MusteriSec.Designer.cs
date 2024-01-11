namespace SeSa_Kirtasiye
{
    partial class MusteriSec
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.müsterilerTabPage = new System.Windows.Forms.TabPage();
            this.musteriAra = new System.Windows.Forms.Button();
            this.aranacakMusteri = new System.Windows.Forms.TextBox();
            this.musterilerGridView = new System.Windows.Forms.DataGridView();
            this.musteriSil = new System.Windows.Forms.Button();
            this.musteriDuzenle = new System.Windows.Forms.Button();
            this.musteriEkle = new System.Windows.Forms.Button();
            this.musteriSecTamam = new System.Windows.Forms.Button();
            this.musteriSecIptal = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.müsterilerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.müsterilerTabPage);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // müsterilerTabPage
            // 
            this.müsterilerTabPage.Controls.Add(this.musteriAra);
            this.müsterilerTabPage.Controls.Add(this.aranacakMusteri);
            this.müsterilerTabPage.Controls.Add(this.musterilerGridView);
            this.müsterilerTabPage.Controls.Add(this.musteriSil);
            this.müsterilerTabPage.Controls.Add(this.musteriDuzenle);
            this.müsterilerTabPage.Controls.Add(this.musteriEkle);
            this.müsterilerTabPage.Location = new System.Drawing.Point(4, 22);
            this.müsterilerTabPage.Name = "müsterilerTabPage";
            this.müsterilerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.müsterilerTabPage.Size = new System.Drawing.Size(768, 400);
            this.müsterilerTabPage.TabIndex = 1;
            this.müsterilerTabPage.Text = "MÜŞTERİLER";
            this.müsterilerTabPage.UseVisualStyleBackColor = true;
            this.müsterilerTabPage.Click += new System.EventHandler(this.müsterilerTabPage_Click);
            // 
            // musteriAra
            // 
            this.musteriAra.Location = new System.Drawing.Point(686, 7);
            this.musteriAra.Name = "musteriAra";
            this.musteriAra.Size = new System.Drawing.Size(75, 23);
            this.musteriAra.TabIndex = 9;
            this.musteriAra.Text = "Müşteri Ara";
            this.musteriAra.UseVisualStyleBackColor = true;
            this.musteriAra.Click += new System.EventHandler(this.musteriAra_Click);
            // 
            // aranacakMusteri
            // 
            this.aranacakMusteri.Location = new System.Drawing.Point(581, 7);
            this.aranacakMusteri.Name = "aranacakMusteri";
            this.aranacakMusteri.Size = new System.Drawing.Size(100, 20);
            this.aranacakMusteri.TabIndex = 8;
            // 
            // musterilerGridView
            // 
            this.musterilerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilerGridView.Location = new System.Drawing.Point(6, 36);
            this.musterilerGridView.Name = "musterilerGridView";
            this.musterilerGridView.Size = new System.Drawing.Size(755, 358);
            this.musterilerGridView.TabIndex = 7;
            // 
            // musteriSil
            // 
            this.musteriSil.Location = new System.Drawing.Point(167, 7);
            this.musteriSil.Name = "musteriSil";
            this.musteriSil.Size = new System.Drawing.Size(75, 23);
            this.musteriSil.TabIndex = 3;
            this.musteriSil.Text = "Sil";
            this.musteriSil.UseVisualStyleBackColor = true;
            this.musteriSil.Click += new System.EventHandler(this.musteriSil_Click);
            // 
            // musteriDuzenle
            // 
            this.musteriDuzenle.Location = new System.Drawing.Point(87, 7);
            this.musteriDuzenle.Name = "musteriDuzenle";
            this.musteriDuzenle.Size = new System.Drawing.Size(75, 23);
            this.musteriDuzenle.TabIndex = 2;
            this.musteriDuzenle.Text = "Düzenle";
            this.musteriDuzenle.UseVisualStyleBackColor = true;
            this.musteriDuzenle.Click += new System.EventHandler(this.müsteriDuzenle_Click);
            // 
            // musteriEkle
            // 
            this.musteriEkle.Location = new System.Drawing.Point(7, 7);
            this.musteriEkle.Name = "musteriEkle";
            this.musteriEkle.Size = new System.Drawing.Size(75, 23);
            this.musteriEkle.TabIndex = 1;
            this.musteriEkle.Text = "Ekle";
            this.musteriEkle.UseVisualStyleBackColor = true;
            this.musteriEkle.Click += new System.EventHandler(this.müsteriEkle_Click);
            // 
            // musteriSecTamam
            // 
            this.musteriSecTamam.Location = new System.Drawing.Point(621, 444);
            this.musteriSecTamam.Name = "musteriSecTamam";
            this.musteriSecTamam.Size = new System.Drawing.Size(75, 23);
            this.musteriSecTamam.TabIndex = 26;
            this.musteriSecTamam.Text = "Tamam";
            this.musteriSecTamam.UseVisualStyleBackColor = true;
            this.musteriSecTamam.Click += new System.EventHandler(this.satisYapTamam_Click);
            // 
            // musteriSecIptal
            // 
            this.musteriSecIptal.Location = new System.Drawing.Point(702, 444);
            this.musteriSecIptal.Name = "musteriSecIptal";
            this.musteriSecIptal.Size = new System.Drawing.Size(75, 23);
            this.musteriSecIptal.TabIndex = 25;
            this.musteriSecIptal.Text = "İptal";
            this.musteriSecIptal.UseVisualStyleBackColor = true;
            this.musteriSecIptal.Click += new System.EventHandler(this.satisYapIptal_Click);
            // 
            // MusteriSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.musteriSecTamam);
            this.Controls.Add(this.musteriSecIptal);
            this.Controls.Add(this.tabControl1);
            this.Name = "MusteriSec";
            this.Text = "MusteriSec";
            this.Load += new System.EventHandler(this.MusteriSec_Load);
            this.tabControl1.ResumeLayout(false);
            this.müsterilerTabPage.ResumeLayout(false);
            this.müsterilerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage müsterilerTabPage;
        private System.Windows.Forms.DataGridView musterilerGridView;
        private System.Windows.Forms.Button musteriSil;
        private System.Windows.Forms.Button musteriDuzenle;
        private System.Windows.Forms.Button musteriEkle;
        private System.Windows.Forms.Button musteriSecTamam;
        private System.Windows.Forms.Button musteriSecIptal;
        private System.Windows.Forms.Button musteriAra;
        private System.Windows.Forms.TextBox aranacakMusteri;
    }
}