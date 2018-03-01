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
    public partial class frmPlaka : Form
    {
        public frmPlaka()
        {
            InitializeComponent();
        }

        AracGirisiBLL ab = new AracGirisiBLL();
        GirisCikisKayitlariModel GirisCikisKayitlari = new GirisCikisKayitlariModel();
        List<GirisCikisKayitlariModel> plakayaAitListe = new List<GirisCikisKayitlariModel>();

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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

            foreach (var item in plakayaAitListe)
            {
                if (item != null)
                {
                    konumTarih = new Point(konumTarih.X, konumTarih.Y + 25);
                    e.Graphics.DrawString($"{item.ARAC_PLAKA}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumTarih);
                    konumHasta = new Point(konumHasta.X, konumHasta.Y + 25);
                    e.Graphics.DrawString($"{item.GIRIS_TARIHI.ToString()}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumHasta);
                    konumCinsiyet = new Point(konumCinsiyet.X, konumCinsiyet.Y + 25);
                    e.Graphics.DrawString($"{item.CIKIS_TARIHI.ToString()}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumCinsiyet);
                    konumYas = new Point(konumYas.X, konumYas.Y + 25);
                    e.Graphics.DrawString($"{item.SURE_DAKIKA.ToString()}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumYas);
                    konumxyz = new Point(konumxyz.X, konumxyz.Y + 25);
                    e.Graphics.DrawString($"{item.UCRET.ToString()}", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, konumxyz);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboBox1.SelectedValue);
            string plaka = null;

            Result<List<GirisCikisKayitlariModel>> tumliste = ab.SelectGirisCikisKayitlari();
            foreach (GirisCikisKayitlariModel item in tumliste.TransactionResult)
            {
                if (item.ID == id)
                {
                    plaka = item.ARAC_PLAKA;
                    break;
                }
            }
            foreach (GirisCikisKayitlariModel item in tumliste.TransactionResult)
            {
                if (item.ARAC_PLAKA == plaka)
                {
                    plakayaAitListe.Add(item);
                }
            }
            Form frm = printPreviewDialog1 as Form;
            printPreviewDialog1.Document = printDocument1;
            frm.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1.0;
            printPreviewDialog1.ShowDialog();
        }

        private void frmPlaka_Load(object sender, EventArgs e)
        {
            getAbone();

            printPreviewDialog1.Document = printDocument1;
        }
        private void getAbone()
        {
            Result<List<GirisCikisKayitlariModel>> abList = ab.SelectGirisCikisKayitlari();
            comboBox1.DataSource = abList.TransactionResult;
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "ARAC_PLAKA";
        }

        private void comboBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            //Class called AboneBilgileriModel , and Firstname & Lastname are the fields
            string plaka = ((GirisCikisKayitlariModel)e.ListItem).ARAC_PLAKA;
            e.Value = plaka;
        }
    }
}
