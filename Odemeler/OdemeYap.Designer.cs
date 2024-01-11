namespace SeSa_Kirtasiye
{
    partial class OdemeYap
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
            this.musteriSec = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.odemeTuruTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.odemeTutariTextBox = new System.Windows.Forms.TextBox();
            this.tarihPicker = new System.Windows.Forms.DateTimePicker();
            this.odemeYapTamam = new System.Windows.Forms.Button();
            this.odemeYapIptal = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musteriAdiTextBox = new System.Windows.Forms.TextBox();
            this.aciklamaTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // musteriSec
            // 
            this.musteriSec.Location = new System.Drawing.Point(396, 50);
            this.musteriSec.Name = "musteriSec";
            this.musteriSec.Size = new System.Drawing.Size(75, 23);
            this.musteriSec.TabIndex = 46;
            this.musteriSec.Text = "Müşteri Seç";
            this.musteriSec.UseVisualStyleBackColor = true;
            this.musteriSec.Click += new System.EventHandler(this.musteriSec_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Ödeme Türü";
            // 
            // odemeTuruTextBox
            // 
            this.odemeTuruTextBox.Location = new System.Drawing.Point(118, 172);
            this.odemeTuruTextBox.Name = "odemeTuruTextBox";
            this.odemeTuruTextBox.Size = new System.Drawing.Size(236, 20);
            this.odemeTuruTextBox.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Açıklama";
            // 
            // odemeTutariTextBox
            // 
            this.odemeTutariTextBox.Location = new System.Drawing.Point(118, 134);
            this.odemeTutariTextBox.Name = "odemeTutariTextBox";
            this.odemeTutariTextBox.Size = new System.Drawing.Size(236, 20);
            this.odemeTutariTextBox.TabIndex = 42;
            // 
            // tarihPicker
            // 
            this.tarihPicker.Location = new System.Drawing.Point(118, 96);
            this.tarihPicker.Name = "tarihPicker";
            this.tarihPicker.Size = new System.Drawing.Size(200, 20);
            this.tarihPicker.TabIndex = 41;
            // 
            // odemeYapTamam
            // 
            this.odemeYapTamam.Location = new System.Drawing.Point(315, 378);
            this.odemeYapTamam.Name = "odemeYapTamam";
            this.odemeYapTamam.Size = new System.Drawing.Size(75, 23);
            this.odemeYapTamam.TabIndex = 40;
            this.odemeYapTamam.Text = "Tamam";
            this.odemeYapTamam.UseVisualStyleBackColor = true;
            this.odemeYapTamam.Click += new System.EventHandler(this.odemeYapTamam_Click);
            // 
            // odemeYapIptal
            // 
            this.odemeYapIptal.Location = new System.Drawing.Point(396, 378);
            this.odemeYapIptal.Name = "odemeYapIptal";
            this.odemeYapIptal.Size = new System.Drawing.Size(75, 23);
            this.odemeYapIptal.TabIndex = 39;
            this.odemeYapIptal.Text = "İptal";
            this.odemeYapIptal.UseVisualStyleBackColor = true;
            this.odemeYapIptal.Click += new System.EventHandler(this.odemeYapIptal_Click);
            // 
            // S
            // 
            this.S.AutoSize = true;
            this.S.Location = new System.Drawing.Point(80, 137);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(32, 13);
            this.S.TabIndex = 38;
            this.S.Text = "Tutar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Müşteri";
            // 
            // musteriAdiTextBox
            // 
            this.musteriAdiTextBox.Location = new System.Drawing.Point(118, 50);
            this.musteriAdiTextBox.Name = "musteriAdiTextBox";
            this.musteriAdiTextBox.ReadOnly = true;
            this.musteriAdiTextBox.Size = new System.Drawing.Size(236, 20);
            this.musteriAdiTextBox.TabIndex = 32;
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.Location = new System.Drawing.Point(118, 216);
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(236, 96);
            this.aciklamaTextBox.TabIndex = 47;
            this.aciklamaTextBox.Text = "";
            // 
            // OdemeYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 451);
            this.Controls.Add(this.aciklamaTextBox);
            this.Controls.Add(this.musteriSec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.odemeTuruTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odemeTutariTextBox);
            this.Controls.Add(this.tarihPicker);
            this.Controls.Add(this.odemeYapTamam);
            this.Controls.Add(this.odemeYapIptal);
            this.Controls.Add(this.S);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.musteriAdiTextBox);
            this.Name = "OdemeYap";
            this.Text = "OdemeYap";
            this.Load += new System.EventHandler(this.OdemeYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button musteriSec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox odemeTuruTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox odemeTutariTextBox;
        private System.Windows.Forms.DateTimePicker tarihPicker;
        private System.Windows.Forms.Button odemeYapTamam;
        private System.Windows.Forms.Button odemeYapIptal;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox musteriAdiTextBox;
        private System.Windows.Forms.RichTextBox aciklamaTextBox;
    }
}