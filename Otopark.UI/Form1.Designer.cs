namespace Otopark.UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboneBilgisiTanımlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abonelikOlusturToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifeİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otoparkİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracGirisiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aracCikisiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anlikOtoparktaBulunanAracRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aktifAboneRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aylikOtoparkKazancRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentOtoparktakiAraclar = new System.Drawing.Printing.PrintDocument();
            this.printDocumentAktifAbone = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboneBilgisiTanımlaToolStripMenuItem,
            this.tarifeİşlemleriToolStripMenuItem,
            this.otoparkİşlemleriToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboneBilgisiTanımlaToolStripMenuItem
            // 
            this.aboneBilgisiTanımlaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem,
            this.abonelikOlusturToolStripMenuItem1});
            this.aboneBilgisiTanımlaToolStripMenuItem.Name = "aboneBilgisiTanımlaToolStripMenuItem";
            this.aboneBilgisiTanımlaToolStripMenuItem.Size = new System.Drawing.Size(146, 25);
            this.aboneBilgisiTanımlaToolStripMenuItem.Text = "Abonelik İşlemleri";
            // 
            // aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem
            // 
            this.aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem.Name = "aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem";
            this.aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem.Size = new System.Drawing.Size(354, 26);
            this.aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem.Text = "Abone Bilgisi Oluştur (Kullanıcı Oluştur)";
            this.aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem.Click += new System.EventHandler(this.aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem_Click);
            // 
            // abonelikOlusturToolStripMenuItem1
            // 
            this.abonelikOlusturToolStripMenuItem1.Name = "abonelikOlusturToolStripMenuItem1";
            this.abonelikOlusturToolStripMenuItem1.Size = new System.Drawing.Size(354, 26);
            this.abonelikOlusturToolStripMenuItem1.Text = "Abonelik Oluştur";
            this.abonelikOlusturToolStripMenuItem1.Click += new System.EventHandler(this.abonelikOlusturToolStripMenuItem1_Click);
            // 
            // tarifeİşlemleriToolStripMenuItem
            // 
            this.tarifeİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarifeEkleToolStripMenuItem});
            this.tarifeİşlemleriToolStripMenuItem.Name = "tarifeİşlemleriToolStripMenuItem";
            this.tarifeİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(122, 25);
            this.tarifeİşlemleriToolStripMenuItem.Text = "Tarife İşlemleri";
            // 
            // tarifeEkleToolStripMenuItem
            // 
            this.tarifeEkleToolStripMenuItem.Name = "tarifeEkleToolStripMenuItem";
            this.tarifeEkleToolStripMenuItem.Size = new System.Drawing.Size(149, 26);
            this.tarifeEkleToolStripMenuItem.Text = "Tarife Ekle";
            this.tarifeEkleToolStripMenuItem.Click += new System.EventHandler(this.tarifeEkleToolStripMenuItem_Click);
            // 
            // otoparkİşlemleriToolStripMenuItem
            // 
            this.otoparkİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aracGirisiEkleToolStripMenuItem,
            this.aracCikisiEkleToolStripMenuItem});
            this.otoparkİşlemleriToolStripMenuItem.Name = "otoparkİşlemleriToolStripMenuItem";
            this.otoparkİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(142, 25);
            this.otoparkİşlemleriToolStripMenuItem.Text = "Otopark İşlemleri";
            // 
            // aracGirisiEkleToolStripMenuItem
            // 
            this.aracGirisiEkleToolStripMenuItem.Name = "aracGirisiEkleToolStripMenuItem";
            this.aracGirisiEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.aracGirisiEkleToolStripMenuItem.Text = "Araç Girişi Ekle";
            this.aracGirisiEkleToolStripMenuItem.Click += new System.EventHandler(this.aracGirisiEkleToolStripMenuItem_Click);
            // 
            // aracCikisiEkleToolStripMenuItem
            // 
            this.aracCikisiEkleToolStripMenuItem.Name = "aracCikisiEkleToolStripMenuItem";
            this.aracCikisiEkleToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.aracCikisiEkleToolStripMenuItem.Text = "Araç Çıkışı Ekle";
            this.aracCikisiEkleToolStripMenuItem.Click += new System.EventHandler(this.aracCikisiEkleToolStripMenuItem_Click);
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem,
            this.anlikOtoparktaBulunanAracRaporuToolStripMenuItem,
            this.aktifAboneRaporuToolStripMenuItem,
            this.aylikOtoparkKazancRaporuToolStripMenuItem});
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            // 
            // birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem
            // 
            this.birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem.Name = "birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem";
            this.birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem.Text = "Bir Plakaya Ait Giriş Çıkış Hareketleri Raporu";
            this.birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem.Click += new System.EventHandler(this.birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem_Click);
            // 
            // anlikOtoparktaBulunanAracRaporuToolStripMenuItem
            // 
            this.anlikOtoparktaBulunanAracRaporuToolStripMenuItem.Name = "anlikOtoparktaBulunanAracRaporuToolStripMenuItem";
            this.anlikOtoparktaBulunanAracRaporuToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.anlikOtoparktaBulunanAracRaporuToolStripMenuItem.Text = "Anlık Otoparkta Bulunan Araç Raporu";
            this.anlikOtoparktaBulunanAracRaporuToolStripMenuItem.Click += new System.EventHandler(this.anlikOtoparktaBulunanAracRaporuToolStripMenuItem_Click);
            // 
            // aktifAboneRaporuToolStripMenuItem
            // 
            this.aktifAboneRaporuToolStripMenuItem.Name = "aktifAboneRaporuToolStripMenuItem";
            this.aktifAboneRaporuToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.aktifAboneRaporuToolStripMenuItem.Text = "Aktif Abone Raporu";
            this.aktifAboneRaporuToolStripMenuItem.Click += new System.EventHandler(this.aktifAboneRaporuToolStripMenuItem_Click);
            // 
            // aylikOtoparkKazancRaporuToolStripMenuItem
            // 
            this.aylikOtoparkKazancRaporuToolStripMenuItem.Name = "aylikOtoparkKazancRaporuToolStripMenuItem";
            this.aylikOtoparkKazancRaporuToolStripMenuItem.Size = new System.Drawing.Size(387, 26);
            this.aylikOtoparkKazancRaporuToolStripMenuItem.Text = "Aylık Otopark Kazanç Raporu";
            this.aylikOtoparkKazancRaporuToolStripMenuItem.Click += new System.EventHandler(this.aylikOtoparkKazancRaporuToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocumentOtoparktakiAraclar
            // 
            this.printDocumentOtoparktakiAraclar.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentOtoparktakiAraclar_PrintPage);
            // 
            // printDocumentAktifAbone
            // 
            this.printDocumentAktifAbone.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentAktifAbone_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Otopark.UI.Properties.Resources.otopark_arkaplan;
            this.ClientSize = new System.Drawing.Size(860, 614);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otopark Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboneBilgisiTanımlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abonelikOlusturToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tarifeİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otoparkİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracGirisiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aracCikisiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anlikOtoparktaBulunanAracRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aktifAboneRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aylikOtoparkKazancRaporuToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocumentOtoparktakiAraclar;
        private System.Drawing.Printing.PrintDocument printDocumentAktifAbone;
    }
}

