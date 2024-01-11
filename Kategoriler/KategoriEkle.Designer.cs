namespace SeSa_Kirtasiye
{
    partial class KategoriEkle
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
            this.kategoriAdiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.kategoriEkleTamam = new System.Windows.Forms.Button();
            this.kategoriEkleIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kategoriAdiTextBox
            // 
            this.kategoriAdiTextBox.Location = new System.Drawing.Point(51, 71);
            this.kategoriAdiTextBox.Name = "kategoriAdiTextBox";
            this.kategoriAdiTextBox.Size = new System.Drawing.Size(236, 20);
            this.kategoriAdiTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kategori Adı";
            // 
            // kategoriEkleTamam
            // 
            this.kategoriEkleTamam.Location = new System.Drawing.Point(180, 128);
            this.kategoriEkleTamam.Name = "kategoriEkleTamam";
            this.kategoriEkleTamam.Size = new System.Drawing.Size(75, 23);
            this.kategoriEkleTamam.TabIndex = 14;
            this.kategoriEkleTamam.Text = "Tamam";
            this.kategoriEkleTamam.UseVisualStyleBackColor = true;
            this.kategoriEkleTamam.Click += new System.EventHandler(this.kategoriEkleTamam_Click);
            // 
            // kategoriEkleIptal
            // 
            this.kategoriEkleIptal.Location = new System.Drawing.Point(261, 128);
            this.kategoriEkleIptal.Name = "kategoriEkleIptal";
            this.kategoriEkleIptal.Size = new System.Drawing.Size(75, 23);
            this.kategoriEkleIptal.TabIndex = 13;
            this.kategoriEkleIptal.Text = "İptal";
            this.kategoriEkleIptal.UseVisualStyleBackColor = true;
            this.kategoriEkleIptal.Click += new System.EventHandler(this.kategoriEkleIptal_Click);
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 180);
            this.Controls.Add(this.kategoriEkleTamam);
            this.Controls.Add(this.kategoriEkleIptal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategoriAdiTextBox);
            this.Name = "KategoriEkle";
            this.Text = "KategoriEkle";
            this.Load += new System.EventHandler(this.KategoriEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kategoriAdiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button kategoriEkleTamam;
        private System.Windows.Forms.Button kategoriEkleIptal;
    }
}