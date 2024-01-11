namespace SeSa_Kirtasiye
{
    partial class SatısYap
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
            this.satisYapTamam = new System.Windows.Forms.Button();
            this.satisYapIptal = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.satisFiyatiTextBox = new System.Windows.Forms.TextBox();
            this.urunAdiTextBox = new System.Windows.Forms.TextBox();
            this.musteriAdiTextBox = new System.Windows.Forms.TextBox();
            this.tarihPicker = new System.Windows.Forms.DateTimePicker();
            this.satisAdetiTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adetFiyatiTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.musteriSec = new System.Windows.Forms.Button();
            this.urunSec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // satisYapTamam
            // 
            this.satisYapTamam.Location = new System.Drawing.Point(315, 378);
            this.satisYapTamam.Name = "satisYapTamam";
            this.satisYapTamam.Size = new System.Drawing.Size(75, 23);
            this.satisYapTamam.TabIndex = 24;
            this.satisYapTamam.Text = "Tamam";
            this.satisYapTamam.UseVisualStyleBackColor = true;
            this.satisYapTamam.Click += new System.EventHandler(this.satisYapTamam_Click);
            // 
            // satisYapIptal
            // 
            this.satisYapIptal.Location = new System.Drawing.Point(396, 378);
            this.satisYapIptal.Name = "satisYapIptal";
            this.satisYapIptal.Size = new System.Drawing.Size(75, 23);
            this.satisYapIptal.TabIndex = 23;
            this.satisYapIptal.Text = "İptal";
            this.satisYapIptal.UseVisualStyleBackColor = true;
            this.satisYapIptal.Click += new System.EventHandler(this.satisYapIptal_Click);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(83, 175);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(29, 13);
            this.S.TabIndex = 21;
            this.S.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ürün";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Müşteri";
            // 
            // satisFiyatiTextBox
            // 
            this.satisFiyatiTextBox.Location = new System.Drawing.Point(118, 262);
            this.satisFiyatiTextBox.Name = "satisFiyatiTextBox";
            this.satisFiyatiTextBox.ReadOnly = true;
            this.satisFiyatiTextBox.Size = new System.Drawing.Size(236, 20);
            this.satisFiyatiTextBox.TabIndex = 16;
            this.satisFiyatiTextBox.TextChanged += new System.EventHandler(this.satisFiyatiTextBox_TextChanged);
            // 
            // urunAdiTextBox
            // 
            this.urunAdiTextBox.Location = new System.Drawing.Point(118, 96);
            this.urunAdiTextBox.Name = "urunAdiTextBox";
            this.urunAdiTextBox.ReadOnly = true;
            this.urunAdiTextBox.Size = new System.Drawing.Size(236, 20);
            this.urunAdiTextBox.TabIndex = 14;
            // 
            // musteriAdiTextBox
            // 
            this.musteriAdiTextBox.Location = new System.Drawing.Point(118, 50);
            this.musteriAdiTextBox.Name = "musteriAdiTextBox";
            this.musteriAdiTextBox.ReadOnly = true;
            this.musteriAdiTextBox.Size = new System.Drawing.Size(236, 20);
            this.musteriAdiTextBox.TabIndex = 13;
            // 
            // tarihPicker
            // 
            this.tarihPicker.Location = new System.Drawing.Point(118, 134);
            this.tarihPicker.Name = "tarihPicker";
            this.tarihPicker.Size = new System.Drawing.Size(200, 20);
            this.tarihPicker.TabIndex = 25;
            // 
            // satisAdetiTextBox
            // 
            this.satisAdetiTextBox.Location = new System.Drawing.Point(118, 172);
            this.satisAdetiTextBox.Name = "satisAdetiTextBox";
            this.satisAdetiTextBox.Size = new System.Drawing.Size(236, 20);
            this.satisAdetiTextBox.TabIndex = 26;
            this.satisAdetiTextBox.TextChanged += new System.EventHandler(this.satisAdetiTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fiyat";
            // 
            // adetFiyatiTextBox
            // 
            this.adetFiyatiTextBox.Location = new System.Drawing.Point(118, 216);
            this.adetFiyatiTextBox.Name = "adetFiyatiTextBox";
            this.adetFiyatiTextBox.ReadOnly = true;
            this.adetFiyatiTextBox.Size = new System.Drawing.Size(236, 20);
            this.adetFiyatiTextBox.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Adet Fiyatı";
            // 
            // musteriSec
            // 
            this.musteriSec.Location = new System.Drawing.Point(396, 50);
            this.musteriSec.Name = "musteriSec";
            this.musteriSec.Size = new System.Drawing.Size(75, 23);
            this.musteriSec.TabIndex = 30;
            this.musteriSec.Text = "Müşteri Seç";
            this.musteriSec.UseVisualStyleBackColor = true;
            this.musteriSec.Click += new System.EventHandler(this.musteriSec_Click);
            // 
            // urunSec
            // 
            this.urunSec.Location = new System.Drawing.Point(396, 96);
            this.urunSec.Name = "urunSec";
            this.urunSec.Size = new System.Drawing.Size(75, 23);
            this.urunSec.TabIndex = 31;
            this.urunSec.Text = "Ürün Seç";
            this.urunSec.UseVisualStyleBackColor = true;
            this.urunSec.Click += new System.EventHandler(this.urunSec_Click);
            // 
            // SatısYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 451);
            this.Controls.Add(this.urunSec);
            this.Controls.Add(this.musteriSec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adetFiyatiTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.satisAdetiTextBox);
            this.Controls.Add(this.tarihPicker);
            this.Controls.Add(this.satisYapTamam);
            this.Controls.Add(this.satisYapIptal);
            this.Controls.Add(this.S);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.satisFiyatiTextBox);
            this.Controls.Add(this.urunAdiTextBox);
            this.Controls.Add(this.musteriAdiTextBox);
            this.Name = "SatısYap";
            this.Text = "SatısYap";
            this.Load += new System.EventHandler(this.SatısYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button satisYapTamam;
        private System.Windows.Forms.Button satisYapIptal;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox satisFiyatiTextBox;
        private System.Windows.Forms.TextBox urunAdiTextBox;
        private System.Windows.Forms.TextBox musteriAdiTextBox;
        private System.Windows.Forms.DateTimePicker tarihPicker;
        private System.Windows.Forms.TextBox satisAdetiTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adetFiyatiTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button musteriSec;
        private System.Windows.Forms.Button urunSec;
    }
}