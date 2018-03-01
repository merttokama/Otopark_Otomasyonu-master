using Otopark.BLL;
using Otopark.DAL;
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
    public partial class frmAylikKazanc : Form
    {
        public frmAylikKazanc()
        {
            InitializeComponent();
        }
        DateTime baslangic, bitis;
        AylikRaporBLL abBLl = new AylikRaporBLL();
        private void frmAylikKazanc_Load(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
        }

        private void btnAylikKazanRapor_Click(object sender, EventArgs e)
        {
            Form frm = printPreviewDialog1 as Form;
            printPreviewDialog1.Document = printDocument1;
            frm.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
            printPreviewDialog1.ShowDialog();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.report;
            Image resim = bmp;
            e.Graphics.DrawImage(resim, 25, 25, resim.Width / 5, resim.Height / 5);
            e.Graphics.DrawString($" Tarih: {DateTime.Now}", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(25, 100));
            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 150), new Point(800, 150));
            e.Graphics.DrawString($"Seçilen Yıl ", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(50, 200));
            e.Graphics.DrawString($"Kaçıncı Ay", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(200, 200));
            e.Graphics.DrawString($"Toplam Ciro", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(350, 200));


            e.Graphics.DrawLine(new Pen(Color.Blue, 2), new Point(25, 225), new Point(800, 225));
            Point konumTarih = new Point(50, 235);
            Point konumHasta = new Point(200, 235);
            Point konumCinsiyet = new Point(350, 235);

            Result<List<GirisCikisKayitlariModel>> sonuc;
            string y;
            y = dateTimeRaporTarih.Value.Year + "." + (dateTimeRaporTarih.Value.Month) + ".1";
            string x;
            x = dateTimeRaporTarih.Value.Year + "." + (dateTimeRaporTarih.Value.Month + 1) + ".1";
            bitis = Convert.ToDateTime(x);
            baslangic = Convert.ToDateTime(y);
            sonuc = abBLl.SelectAylikUcretToplami(baslangic, bitis);
            foreach (var item in sonuc.TransactionResult)
            {
                konumTarih = new Point(konumTarih.X, konumTarih.Y + 25);
                e.Graphics.DrawString($"{dateTimeRaporTarih.Value.Year}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumTarih);
                konumHasta = new Point(konumHasta.X, konumHasta.Y + 25);
                e.Graphics.DrawString($"{dateTimeRaporTarih.Value.Month}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumHasta);
                konumCinsiyet = new Point(konumCinsiyet.X, konumCinsiyet.Y + 25);
                e.Graphics.DrawString($"{item.TOPLAM}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumCinsiyet);
            }
        }

    }
}

