using Otopark.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otopark.DAL;
using Otopark.Entity;
using Otopark.Entity.Models;

namespace Otopark.UI
{
    public partial class frmAracGiris : Form
    {
        public frmAracGiris()
        {
            InitializeComponent();
        }
        AboneBilgileriBLL ab = new AboneBilgileriBLL();
        GirisCikisKayitlariModel GirisCikisKayitlari = new GirisCikisKayitlariModel();

        private void frmAracGiris_Load(object sender, EventArgs e)
        {
            getAbone();
        }

        private void getAbone()
        {
            Result<List<AboneBilgileriModel>> abList = ab.SelectAboneBilgileri();
            
                cbAboneler.DataSource = abList.TransactionResult;
                cbAboneler.ValueMember ="ABONE_ID";
                cbAboneler.DisplayMember = "AD" ;
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AracGirisiBLL aGBLL = new AracGirisiBLL();
            GirisCikisKayitlari.ABONE_ID = int.Parse(cbAboneler.SelectedValue.ToString());
            GirisCikisKayitlari.ARAC_PLAKA = txtPlaka.Text;
            GirisCikisKayitlari.UCRET = 0;
            if (aGBLL.AddAracGiris(GirisCikisKayitlari).IsSucceded)
            {
                txtPlaka.Text = "";
                MessageBox.Show("Araç Giriş Kaydı Oluşturuldu");
            }
            else
            {
                MessageBox.Show("Araç Giriş Kaydı Oluşturmakta Bir Hata İle Karşılaşıldı.!");
            }
        }
        private void cbAboneler_Format(object sender, ListControlConvertEventArgs e)
        {
            //Class called AboneBilgileriModel , and Firstname & Lastname are the fields
            string lastname = ((AboneBilgileriModel)e.ListItem).AD;
            string firstname = ((AboneBilgileriModel)e.ListItem).SOYAD;
            e.Value = lastname + " " + firstname;
        }

        private void txtPlaka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPlaka.TextLength == 10)
            {
                e.Handled = true;
            }
        }
    }
}
