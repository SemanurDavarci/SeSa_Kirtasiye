namespace SeSa_Kirtasiye
{
    partial class Main
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
            this.mainTabPage = new System.Windows.Forms.TabControl();
            this.satislarTabPage = new System.Windows.Forms.TabPage();
            this.satisAra = new System.Windows.Forms.Button();
            this.aranacakSatis = new System.Windows.Forms.TextBox();
            this.satislarSilButton = new System.Windows.Forms.Button();
            this.satislarDuzenleButton = new System.Windows.Forms.Button();
            this.satislarDataGrid = new System.Windows.Forms.DataGridView();
            this.odemelerTabPage = new System.Windows.Forms.TabPage();
            this.odemeAra = new System.Windows.Forms.Button();
            this.odemeSil = new System.Windows.Forms.Button();
            this.odemeDuzenle = new System.Windows.Forms.Button();
            this.aranacakOdeme = new System.Windows.Forms.TextBox();
            this.odemelerDataGrid = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.urunlerGirisButton = new System.Windows.Forms.Button();
            this.satisyapGirisButton = new System.Windows.Forms.Button();
            this.odemeyapGirisButton = new System.Windows.Forms.Button();
            this.kategorilerGirisButton = new System.Windows.Forms.Button();
            this.musterilerGirisButton = new System.Windows.Forms.Button();
            this.mainTabPage.SuspendLayout();
            this.satislarTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satislarDataGrid)).BeginInit();
            this.odemelerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabPage
            // 
            this.mainTabPage.Controls.Add(this.satislarTabPage);
            this.mainTabPage.Controls.Add(this.odemelerTabPage);
            this.mainTabPage.Location = new System.Drawing.Point(5, 67);
            this.mainTabPage.Name = "mainTabPage";
            this.mainTabPage.SelectedIndex = 0;
            this.mainTabPage.Size = new System.Drawing.Size(1061, 447);
            this.mainTabPage.TabIndex = 1;
            this.mainTabPage.SelectedIndexChanged += new System.EventHandler(this.mainTabPage_SelectedIndexChanged);
            // 
            // satislarTabPage
            // 
            this.satislarTabPage.Controls.Add(this.satisAra);
            this.satislarTabPage.Controls.Add(this.aranacakSatis);
            this.satislarTabPage.Controls.Add(this.satislarSilButton);
            this.satislarTabPage.Controls.Add(this.satislarDuzenleButton);
            this.satislarTabPage.Controls.Add(this.satislarDataGrid);
            this.satislarTabPage.Location = new System.Drawing.Point(4, 22);
            this.satislarTabPage.Name = "satislarTabPage";
            this.satislarTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.satislarTabPage.Size = new System.Drawing.Size(1053, 421);
            this.satislarTabPage.TabIndex = 0;
            this.satislarTabPage.Text = "SATIŞLAR";
            this.satislarTabPage.UseVisualStyleBackColor = true;
            // 
            // satisAra
            // 
            this.satisAra.Location = new System.Drawing.Point(972, 7);
            this.satisAra.Name = "satisAra";
            this.satisAra.Size = new System.Drawing.Size(75, 22);
            this.satisAra.TabIndex = 6;
            this.satisAra.Text = "Satış Ara";
            this.satisAra.UseVisualStyleBackColor = true;
            this.satisAra.Click += new System.EventHandler(this.satisAra_Click);
            // 
            // aranacakSatis
            // 
            this.aranacakSatis.Location = new System.Drawing.Point(866, 9);
            this.aranacakSatis.Name = "aranacakSatis";
            this.aranacakSatis.Size = new System.Drawing.Size(100, 20);
            this.aranacakSatis.TabIndex = 4;
            // 
            // satislarSilButton
            // 
            this.satislarSilButton.Location = new System.Drawing.Point(100, 5);
            this.satislarSilButton.Name = "satislarSilButton";
            this.satislarSilButton.Size = new System.Drawing.Size(96, 27);
            this.satislarSilButton.TabIndex = 3;
            this.satislarSilButton.Text = "SİL";
            this.satislarSilButton.UseVisualStyleBackColor = true;
            this.satislarSilButton.Click += new System.EventHandler(this.satislarSilButton_Click);
            // 
            // satislarDuzenleButton
            // 
            this.satislarDuzenleButton.Location = new System.Drawing.Point(5, 5);
            this.satislarDuzenleButton.Name = "satislarDuzenleButton";
            this.satislarDuzenleButton.Size = new System.Drawing.Size(96, 27);
            this.satislarDuzenleButton.TabIndex = 2;
            this.satislarDuzenleButton.Text = "DÜZENLE";
            this.satislarDuzenleButton.UseVisualStyleBackColor = true;
            this.satislarDuzenleButton.Click += new System.EventHandler(this.satislarDuzenleButton_Click);
            // 
            // satislarDataGrid
            // 
            this.satislarDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.satislarDataGrid.Location = new System.Drawing.Point(6, 47);
            this.satislarDataGrid.Name = "satislarDataGrid";
            this.satislarDataGrid.Size = new System.Drawing.Size(1041, 368);
            this.satislarDataGrid.TabIndex = 0;
            this.satislarDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.satislarDataGrid_CellContentClick);
            // 
            // odemelerTabPage
            // 
            this.odemelerTabPage.Controls.Add(this.odemeAra);
            this.odemelerTabPage.Controls.Add(this.odemeSil);
            this.odemelerTabPage.Controls.Add(this.odemeDuzenle);
            this.odemelerTabPage.Controls.Add(this.aranacakOdeme);
            this.odemelerTabPage.Controls.Add(this.odemelerDataGrid);
            this.odemelerTabPage.Location = new System.Drawing.Point(4, 29);
            this.odemelerTabPage.Name = "odemelerTabPage";
            this.odemelerTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.odemelerTabPage.Size = new System.Drawing.Size(1053, 414);
            this.odemelerTabPage.TabIndex = 1;
            this.odemelerTabPage.Text = "ÖDEMELER";
            this.odemelerTabPage.UseVisualStyleBackColor = true;
            // 
            // odemeAra
            // 
            this.odemeAra.Location = new System.Drawing.Point(972, 7);
            this.odemeAra.Name = "odemeAra";
            this.odemeAra.Size = new System.Drawing.Size(75, 22);
            this.odemeAra.TabIndex = 9;
            this.odemeAra.Text = "Ödeme Bul";
            this.odemeAra.UseVisualStyleBackColor = true;
            this.odemeAra.Click += new System.EventHandler(this.odemeAra_Click);
            // 
            // odemeSil
            // 
            this.odemeSil.Location = new System.Drawing.Point(100, 5);
            this.odemeSil.Name = "odemeSil";
            this.odemeSil.Size = new System.Drawing.Size(96, 27);
            this.odemeSil.TabIndex = 4;
            this.odemeSil.Text = "SİL";
            this.odemeSil.UseVisualStyleBackColor = true;
            this.odemeSil.Click += new System.EventHandler(this.odemeSil_Click);
            // 
            // odemeDuzenle
            // 
            this.odemeDuzenle.Location = new System.Drawing.Point(5, 5);
            this.odemeDuzenle.Name = "odemeDuzenle";
            this.odemeDuzenle.Size = new System.Drawing.Size(96, 27);
            this.odemeDuzenle.TabIndex = 3;
            this.odemeDuzenle.Text = "DÜZENLE";
            this.odemeDuzenle.UseVisualStyleBackColor = true;
            this.odemeDuzenle.Click += new System.EventHandler(this.odemeDuzenle_Click);
            // 
            // aranacakOdeme
            // 
            this.aranacakOdeme.Location = new System.Drawing.Point(866, 9);
            this.aranacakOdeme.Name = "aranacakOdeme";
            this.aranacakOdeme.Size = new System.Drawing.Size(100, 20);
            this.aranacakOdeme.TabIndex = 7;
            // 
            // odemelerDataGrid
            // 
            this.odemelerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odemelerDataGrid.Location = new System.Drawing.Point(6, 47);
            this.odemelerDataGrid.Name = "odemelerDataGrid";
            this.odemelerDataGrid.Size = new System.Drawing.Size(1041, 368);
            this.odemelerDataGrid.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, -5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(105, 51);
            this.button7.TabIndex = 0;
            this.button7.Text = "MÜŞTERİLER";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // urunlerGirisButton
            // 
            this.urunlerGirisButton.Location = new System.Drawing.Point(110, 0);
            this.urunlerGirisButton.Name = "urunlerGirisButton";
            this.urunlerGirisButton.Size = new System.Drawing.Size(105, 51);
            this.urunlerGirisButton.TabIndex = 10;
            this.urunlerGirisButton.Text = "ÜRÜNLER";
            this.urunlerGirisButton.UseVisualStyleBackColor = true;
            this.urunlerGirisButton.Click += new System.EventHandler(this.urunlerGirisButton_Click);
            // 
            // satisyapGirisButton
            // 
            this.satisyapGirisButton.Location = new System.Drawing.Point(215, 0);
            this.satisyapGirisButton.Name = "satisyapGirisButton";
            this.satisyapGirisButton.Size = new System.Drawing.Size(105, 51);
            this.satisyapGirisButton.TabIndex = 11;
            this.satisyapGirisButton.Text = "SATIŞ YAP";
            this.satisyapGirisButton.UseVisualStyleBackColor = true;
            this.satisyapGirisButton.Click += new System.EventHandler(this.satısyapGirisButton_Click);
            // 
            // odemeyapGirisButton
            // 
            this.odemeyapGirisButton.Location = new System.Drawing.Point(320, 0);
            this.odemeyapGirisButton.Name = "odemeyapGirisButton";
            this.odemeyapGirisButton.Size = new System.Drawing.Size(105, 51);
            this.odemeyapGirisButton.TabIndex = 12;
            this.odemeyapGirisButton.Text = "ÖDEME YAP";
            this.odemeyapGirisButton.UseVisualStyleBackColor = true;
            this.odemeyapGirisButton.Click += new System.EventHandler(this.odemeyapGirisButton_Click);
            // 
            // kategorilerGirisButton
            // 
            this.kategorilerGirisButton.Location = new System.Drawing.Point(961, 0);
            this.kategorilerGirisButton.Name = "kategorilerGirisButton";
            this.kategorilerGirisButton.Size = new System.Drawing.Size(105, 51);
            this.kategorilerGirisButton.TabIndex = 12;
            this.kategorilerGirisButton.Text = "KATEGORİLER";
            this.kategorilerGirisButton.UseVisualStyleBackColor = true;
            this.kategorilerGirisButton.Click += new System.EventHandler(this.kategorilerGirisButton_Click);
            // 
            // musterilerGirisButton
            // 
            this.musterilerGirisButton.Location = new System.Drawing.Point(5, 0);
            this.musterilerGirisButton.Name = "musterilerGirisButton";
            this.musterilerGirisButton.Size = new System.Drawing.Size(105, 51);
            this.musterilerGirisButton.TabIndex = 0;
            this.musterilerGirisButton.Text = "MÜŞTERİLER";
            this.musterilerGirisButton.UseVisualStyleBackColor = true;
            this.musterilerGirisButton.Click += new System.EventHandler(this.musterilerGirisButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 526);
            this.Controls.Add(this.kategorilerGirisButton);
            this.Controls.Add(this.mainTabPage);
            this.Controls.Add(this.odemeyapGirisButton);
            this.Controls.Add(this.satisyapGirisButton);
            this.Controls.Add(this.musterilerGirisButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.urunlerGirisButton);
            this.Name = "Main";
            this.Text = "Sesa Kırtasiye";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainTabPage.ResumeLayout(false);
            this.satislarTabPage.ResumeLayout(false);
            this.satislarTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.satislarDataGrid)).EndInit();
            this.odemelerTabPage.ResumeLayout(false);
            this.odemelerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odemelerDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabPage;
        private System.Windows.Forms.TabPage satislarTabPage;
        private System.Windows.Forms.TabPage odemelerTabPage;
        private System.Windows.Forms.DataGridView satislarDataGrid;
        private System.Windows.Forms.DataGridView odemelerDataGrid;
        private System.Windows.Forms.TextBox aranacakSatis;
        private System.Windows.Forms.Button satislarSilButton;
        private System.Windows.Forms.Button satislarDuzenleButton;
        private System.Windows.Forms.Button odemeSil;
        private System.Windows.Forms.Button odemeDuzenle;
        private System.Windows.Forms.Button satisAra;
        private System.Windows.Forms.Button odemeAra;
        private System.Windows.Forms.TextBox aranacakOdeme;
        private System.Windows.Forms.Button kategorilerGirisButton;
        private System.Windows.Forms.Button odemeyapGirisButton;
        private System.Windows.Forms.Button satisyapGirisButton;
        private System.Windows.Forms.Button urunlerGirisButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button musterilerGirisButton;
    }
}

