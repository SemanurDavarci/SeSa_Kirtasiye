namespace SeSa_Kirtasiye
{
    partial class Urunler
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
            this.urunlerGridView = new System.Windows.Forms.DataGridView();
            this.urunAra = new System.Windows.Forms.Button();
            this.aranacakUrun = new System.Windows.Forms.TextBox();
            this.urunSil = new System.Windows.Forms.Button();
            this.urunDuzenle = new System.Windows.Forms.Button();
            this.urunEkle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.müsterilerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerGridView)).BeginInit();
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
            this.müsterilerTabPage.Controls.Add(this.urunlerGridView);
            this.müsterilerTabPage.Controls.Add(this.urunAra);
            this.müsterilerTabPage.Controls.Add(this.aranacakUrun);
            this.müsterilerTabPage.Controls.Add(this.urunSil);
            this.müsterilerTabPage.Controls.Add(this.urunDuzenle);
            this.müsterilerTabPage.Controls.Add(this.urunEkle);
            this.müsterilerTabPage.Location = new System.Drawing.Point(4, 22);
            this.müsterilerTabPage.Name = "müsterilerTabPage";
            this.müsterilerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.müsterilerTabPage.Size = new System.Drawing.Size(768, 400);
            this.müsterilerTabPage.TabIndex = 1;
            this.müsterilerTabPage.Text = "ÜRÜNLER";
            this.müsterilerTabPage.UseVisualStyleBackColor = true;
            // 
            // urunlerGridView
            // 
            this.urunlerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerGridView.Location = new System.Drawing.Point(6, 36);
            this.urunlerGridView.Name = "urunlerGridView";
            this.urunlerGridView.Size = new System.Drawing.Size(755, 358);
            this.urunlerGridView.TabIndex = 7;
            // 
            // urunAra
            // 
            this.urunAra.Location = new System.Drawing.Point(687, 7);
            this.urunAra.Name = "urunAra";
            this.urunAra.Size = new System.Drawing.Size(75, 23);
            this.urunAra.TabIndex = 5;
            this.urunAra.Text = "Ürün Ara";
            this.urunAra.UseVisualStyleBackColor = true;
            this.urunAra.Click += new System.EventHandler(this.urunAra_Click);
            // 
            // aranacakUrun
            // 
            this.aranacakUrun.Location = new System.Drawing.Point(581, 7);
            this.aranacakUrun.Name = "aranacakUrun";
            this.aranacakUrun.Size = new System.Drawing.Size(100, 20);
            this.aranacakUrun.TabIndex = 4;
            // 
            // urunSil
            // 
            this.urunSil.Location = new System.Drawing.Point(167, 7);
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(75, 23);
            this.urunSil.TabIndex = 3;
            this.urunSil.Text = "Sil";
            this.urunSil.UseVisualStyleBackColor = true;
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // urunDuzenle
            // 
            this.urunDuzenle.Location = new System.Drawing.Point(87, 7);
            this.urunDuzenle.Name = "urunDuzenle";
            this.urunDuzenle.Size = new System.Drawing.Size(75, 23);
            this.urunDuzenle.TabIndex = 2;
            this.urunDuzenle.Text = "Düzenle";
            this.urunDuzenle.UseVisualStyleBackColor = true;
            this.urunDuzenle.Click += new System.EventHandler(this.urunDuzenle_Click);
            // 
            // urunEkle
            // 
            this.urunEkle.Location = new System.Drawing.Point(7, 7);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(75, 23);
            this.urunEkle.TabIndex = 1;
            this.urunEkle.Text = "Ekle";
            this.urunEkle.UseVisualStyleBackColor = true;
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            this.tabControl1.ResumeLayout(false);
            this.müsterilerTabPage.ResumeLayout(false);
            this.müsterilerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage müsterilerTabPage;
        private System.Windows.Forms.DataGridView urunlerGridView;
        private System.Windows.Forms.Button urunAra;
        private System.Windows.Forms.TextBox aranacakUrun;
        private System.Windows.Forms.Button urunSil;
        private System.Windows.Forms.Button urunDuzenle;
        private System.Windows.Forms.Button urunEkle;
    }
}