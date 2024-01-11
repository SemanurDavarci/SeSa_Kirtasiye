namespace SeSa_Kirtasiye
{
    partial class MusteriDuzenle
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
            this.adiTextBox = new System.Windows.Forms.TextBox();
            this.soyadiTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adresTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.musteriDuzenleTamam = new System.Windows.Forms.Button();
            this.musteriDuzenleIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adiTextBox
            // 
            this.adiTextBox.Location = new System.Drawing.Point(61, 79);
            this.adiTextBox.Name = "adiTextBox";
            this.adiTextBox.Size = new System.Drawing.Size(236, 20);
            this.adiTextBox.TabIndex = 1;
            // 
            // soyadiTextBox
            // 
            this.soyadiTextBox.Location = new System.Drawing.Point(61, 124);
            this.soyadiTextBox.Name = "soyadiTextBox";
            this.soyadiTextBox.Size = new System.Drawing.Size(236, 20);
            this.soyadiTextBox.TabIndex = 2;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.Location = new System.Drawing.Point(61, 163);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(236, 20);
            this.telefonTextBox.TabIndex = 3;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(61, 209);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(236, 20);
            this.mailTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ad";
            // 
            // adresTextBox
            // 
            this.adresTextBox.Location = new System.Drawing.Point(61, 253);
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(236, 95);
            this.adresTextBox.TabIndex = 8;
            this.adresTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Adres";
            // 
            // musteriDuzenleTamam
            // 
            this.musteriDuzenleTamam.Location = new System.Drawing.Point(191, 407);
            this.musteriDuzenleTamam.Name = "musteriDuzenleTamam";
            this.musteriDuzenleTamam.Size = new System.Drawing.Size(75, 23);
            this.musteriDuzenleTamam.TabIndex = 13;
            this.musteriDuzenleTamam.Text = "Tamam";
            this.musteriDuzenleTamam.UseVisualStyleBackColor = true;
            this.musteriDuzenleTamam.Click += new System.EventHandler(this.musteriEkleTamam_Click);
            // 
            // musteriDuzenleIptal
            // 
            this.musteriDuzenleIptal.Location = new System.Drawing.Point(272, 407);
            this.musteriDuzenleIptal.Name = "musteriDuzenleIptal";
            this.musteriDuzenleIptal.Size = new System.Drawing.Size(75, 23);
            this.musteriDuzenleIptal.TabIndex = 14;
            this.musteriDuzenleIptal.Text = "İptal";
            this.musteriDuzenleIptal.UseVisualStyleBackColor = true;
            this.musteriDuzenleIptal.Click += new System.EventHandler(this.musteriEkleIptal_Click);
            // 
            // MusteriDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 451);
            this.Controls.Add(this.musteriDuzenleIptal);
            this.Controls.Add(this.musteriDuzenleTamam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.telefonTextBox);
            this.Controls.Add(this.soyadiTextBox);
            this.Controls.Add(this.adiTextBox);
            this.Name = "MusteriDuzenle";
            this.Text = "MusteriDuzenle";
            this.Load += new System.EventHandler(this.MusteriDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adiTextBox;
        private System.Windows.Forms.TextBox soyadiTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox adresTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button musteriDuzenleTamam;
        private System.Windows.Forms.Button musteriDuzenleIptal;
    }
}