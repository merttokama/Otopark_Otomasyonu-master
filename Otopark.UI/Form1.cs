using Otopark.BLL;
using Otopark.DAL;
using Otopark.Entity;
using Otopark.Entity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
            frmAracGiris frm = new frmAracGiris();
            frm.MdiParent = this;
            frm.Show();

            printPreviewDialog1.Document = printDocumentAktifAbone;
        }

        #region METHODLAR 
        private void AciklariKapa()
        {
            List<Form> fm = this.MdiChildren.ToList();
            if (fm != null && fm.Count > 0)
            {
                foreach (Form lfm in fm)
                {
                    lfm.Close();
                }
            }
        }

        #endregion

        private void aracGirisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AciklariKapa();
            frmAracGiris frm = new frmAracGiris();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aracCikisiEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AciklariKapa();
            frmAracCikisi frm = new frmAracCikisi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tarifeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AciklariKapa();
            frmTarifeler frm = new frmTarifeler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboneBilgisiOlusturKullaniciOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AciklariKapa();
            frmAboneBilgisi frm = new frmAboneBilgisi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void abonelikOlusturToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AciklariKapa();
            frmAbonelikler frm = new frmAbonelikler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void birPlakayaAitGirisCikisHareketleriRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AciklariKapa();
            frmPlaka frm = new frmPlaka();
            frm.MdiParent = this;
            frm.Show();
        }

        private void anlikOtoparktaBulunanAracRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = printPreviewDialog1 as Form;
            printPreviewDialog1.Document = printDocumentOtoparktakiAraclar;
            frm.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
            printPreviewDialog1.ShowDialog();
        }

        private void aktifAboneRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = printPreviewDialog1 as Form;
            printPreviewDialog1.Document = printDocumentAktifAbone;
            frm.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
            printPreviewDialog1.ShowDialog();
        }

        private void aylikOtoparkKazancRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AciklariKapa();
            frmAylikKazanc frm = new frmAylikKazanc();
            frm.MdiParent = this;
            frm.Show();
        }

        private void printDocumentPlaka_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.report;
            Image resim = bmp;
            e.Graphics.DrawImage(resim, 25, 25, resim.Width / 5, resim.Height / 5);
            e.Graphics.DrawString($" Tarih: {DateTime.Now}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));
            e.Graphics.DrawString($"Aracın Plakası ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString($"Giriş Saati", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString($"Çıkış Saati", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(350, 200));
            e.Graphics.DrawString($"Sure", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString($"Ucret", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(650, 200));


            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));
            Point konumTarih = new Point(50, 235);
            Point konumHasta = new Point(200, 235);
            Point konumCinsiyet = new Point(350, 235);
            Point konumYas = new Point(500, 235);
            Point konumxyz = new Point(650, 235);



            konumTarih = new Point(konumTarih.X, konumTarih.Y + 25);
            e.Graphics.DrawString($"1", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumTarih);
            konumHasta = new Point(konumHasta.X, konumHasta.Y + 25);
            e.Graphics.DrawString($"2", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumHasta);
            konumCinsiyet = new Point(konumCinsiyet.X, konumCinsiyet.Y + 25);
            e.Graphics.DrawString($"3", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumCinsiyet);
            konumYas = new Point(konumYas.X, konumYas.Y + 25);
            e.Graphics.DrawString($"4", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumYas);
            konumxyz = new Point(konumxyz.X, konumxyz.Y + 25);
            e.Graphics.DrawString($"4", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumxyz);
        }

        private void printDocumentOtoparktakiAraclar_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.arac;
            Image resim = bmp;
            e.Graphics.DrawImage(resim, 25, 25, resim.Width / 8, resim.Height / 8);
            e.Graphics.DrawString($" Tarih: {DateTime.Now}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));
            e.Graphics.DrawString($"Aracın Plakası ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString($"Giriş Saati", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));

            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));
            Point konumplaka = new Point(50, 235);
            Point konumgirissaat = new Point(200, 235);



            AracCikisiBLL ab = new AracCikisiBLL();
            Result<List<GirisCikisKayitlariModel>> abList = ab.selectOtoparktakiAraclar();
            foreach (var item in abList.TransactionResult)
            {
                if (item != null)
                {
                    konumplaka = new Point(konumplaka.X, konumplaka.Y + 25);
                    e.Graphics.DrawString($"{item.ARAC_PLAKA}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumplaka);
                    konumgirissaat = new Point(konumgirissaat.X, konumgirissaat.Y + 25);
                    e.Graphics.DrawString($"{item.GIRIS_TARIHI}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumgirissaat);
                }
            }
        }

        private void printDocumentAktifAbone_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.user;
            Image resim = bmp;
            e.Graphics.DrawImage(resim, 25, 25, resim.Width / 8, resim.Height / 8);
            e.Graphics.DrawString($" Tarih: {DateTime.Now}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));
            e.Graphics.DrawString($"Adı", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString($"Soyadı", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString($"İl", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(350, 200));
            e.Graphics.DrawString($"İlçe", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString($"Telefon", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(650, 200));


            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));
            Point konumad = new Point(50, 235);
            Point konumsoyad = new Point(200, 235);
            Point konumil = new Point(350, 235);
            Point konumilce = new Point(500, 235);
            Point konumTelefon = new Point(650, 235);

            AktifAbonelerBLL ab = new AktifAbonelerBLL();
            Result<List<AktifAbonelerModel>> abList = ab.SelectAktifAboneler();
            foreach (var item in abList.TransactionResult)
            {
                if (item != null)
                {
                    konumad = new Point(konumad.X, konumad.Y + 25);
                    e.Graphics.DrawString($"{item.AD}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumad);
                    konumsoyad = new Point(konumsoyad.X, konumsoyad.Y + 25);
                    e.Graphics.DrawString($"{item.SOYAD}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumsoyad);
                    konumil = new Point(konumil.X, konumil.Y + 25);
                    e.Graphics.DrawString($"{item.IL}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumil);
                    konumilce = new Point(konumilce.X, konumilce.Y + 25);
                    e.Graphics.DrawString($"{item.ILCE}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumilce);
                    konumTelefon = new Point(konumTelefon.X, konumTelefon.Y + 25);
                    e.Graphics.DrawString($"{item.TELEFON}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumTelefon);
                }
            }
        }

        private void printDocumentAylıkKazanc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.report;
            Image resim = bmp;
            e.Graphics.DrawImage(resim, 25, 25, resim.Width / 5, resim.Height / 5);
            e.Graphics.DrawString($" Tarih: {DateTime.Now}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));
            e.Graphics.DrawString($"Aracın Plakası ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString($"Giriş Saati", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString($"Çıkış Saati", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(350, 200));
            e.Graphics.DrawString($"Sure", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(500, 200));
            e.Graphics.DrawString($"Ucret", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(650, 200));


            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));
            Point konumTarih = new Point(50, 235);
            Point konumHasta = new Point(200, 235);
            Point konumCinsiyet = new Point(350, 235);
            Point konumYas = new Point(500, 235);
            Point konumxyz = new Point(650, 235);

            AktifAbonelerBLL ab = new AktifAbonelerBLL();
            Result<List<AktifAbonelerModel>> abList = ab.SelectAktifAboneler();
            foreach (var item in abList.TransactionResult)
            {
                if (item != null)
                {

                    konumTarih = new Point(konumTarih.X, konumTarih.Y + 25);
                    e.Graphics.DrawString($"1", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumTarih);
                    konumHasta = new Point(konumHasta.X, konumHasta.Y + 25);
                    e.Graphics.DrawString($"2", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumHasta);
                    konumCinsiyet = new Point(konumCinsiyet.X, konumCinsiyet.Y + 25);
                    e.Graphics.DrawString($"3", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumCinsiyet);
                    konumYas = new Point(konumYas.X, konumYas.Y + 25);
                    e.Graphics.DrawString($"4", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumYas);
                    konumxyz = new Point(konumxyz.X, konumxyz.Y + 25);
                    e.Graphics.DrawString($"4", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumxyz);
                }
            }
        }
    }
}
