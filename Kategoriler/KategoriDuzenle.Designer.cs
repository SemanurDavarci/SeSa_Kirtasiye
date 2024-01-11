namespace SeSa_Kirtasiye
{
    partial class KategoriDuzenle
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
            this.label1 = new System.Windows.Forms.Label();
            this.kategoriAdiTextBox = new System.Windows.Forms.TextBox();
            this.kategoriDuzenleTamam = new System.Windows.Forms.Button();
            this.kategoriDuzenleIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kategori Adı";
            // 
            // kategoriAdiTextBox
            // 
            this.kategoriAdiTextBox.Location = new System.Drawing.Point(51, 71);
            this.kategoriAdiTextBox.Name = "kategoriAdiTextBox";
            this.kategoriAdiTextBox.Size = new System.Drawing.Size(236, 20);
            this.kategoriAdiTextBox.TabIndex = 8;
            // 
            // kategoriDuzenleTamam
            // 
            this.kategoriDuzenleTamam.Location = new System.Drawing.Point(180, 128);
            this.kategoriDuzenleTamam.Name = "kategoriDuzenleTamam";
            this.kategoriDuzenleTamam.Size = new System.Drawing.Size(75, 23);
            this.kategoriDuzenleTamam.TabIndex = 16;
            this.kategoriDuzenleTamam.Text = "Tamam";
            this.kategoriDuzenleTamam.UseVisualStyleBackColor = true;
            this.kategoriDuzenleTamam.Click += new System.EventHandler(this.kategoriDuzenleTamam_Click);
            // 
            // kategoriDuzenleIptal
            // 
            this.kategoriDuzenleIptal.Location = new System.Drawing.Point(261, 128);
            this.kategoriDuzenleIptal.Name = "kategoriDuzenleIptal";
            this.kategoriDuzenleIptal.Size = new System.Drawing.Size(75, 23);
            this.kategoriDuzenleIptal.TabIndex = 15;
            this.kategoriDuzenleIptal.Text = "İptal";
            this.kategoriDuzenleIptal.UseVisualStyleBackColor = true;
            this.kategoriDuzenleIptal.Click += new System.EventHandler(this.kategoriDuzenleIptal_Click);
            // 
            // KategoriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 180);
            this.Controls.Add(this.kategoriDuzenleTamam);
            this.Controls.Add(this.kategoriDuzenleIptal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kategoriAdiTextBox);
            this.Name = "KategoriDuzenle";
            this.Text = "KategoriDuzenle";
            this.Load += new System.EventHandler(this.KategoriDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kategoriAdiTextBox;
        private System.Windows.Forms.Button kategoriDuzenleTamam;
        private System.Windows.Forms.Button kategoriDuzenleIptal;
    }
}