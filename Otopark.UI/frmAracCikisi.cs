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
    public partial class frmAracCikisi : Form
    {
        public frmAracCikisi()
        {
            InitializeComponent();
        }
        AracCikisiBLL aGBLL = new AracCikisiBLL();
        AracCikisiBLL ab = new AracCikisiBLL();
        GirisCikisKayitlariModel GirisCikisKayitlari = new GirisCikisKayitlariModel();

        private void getAbone()
        {
            Result<List<GirisCikisKayitlariModel>> abList = ab.selectOtoparktakiAraclar();
            foreach (var item in abList.TransactionResult)
            {
                cbAboneler.Items.Add(item);
            }
           // cbAboneler.DataSource = abList.TransactionResult;
            //cbAboneler.ValueMember = "ABONE_ID";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (GirisCikisKayitlari.ID!=0)
            {
                GirisCikisKayitlari.UCRET = decimal.Parse(txtToplamHesap.Text);
                GirisCikisKayitlari.SURE_DAKIKA = Convert.ToInt32(txtSure.Text);
                GirisCikisKayitlari.CIKIS_TARIHI = DateTime.Now.ToString();
                if (aGBLL.UpdateAracCikisi(GirisCikisKayitlari).IsSucceded)
                {
                    txtSure.Text = "";
                    txtToplamHesap.Text = "";
                    txtUcret.Text = "";
                    MessageBox.Show("Araç Çıkışı Gerçekleştirildi");
                }
                else
                    MessageBox.Show("Araç Çıkışı Yaparken Bir Hata İle Karşılaştı!");
            }
        }

        private void frmAracCikisi_Load(object sender, EventArgs e)
        {
            getAbone();
        }

        private void cbAboneler_Format(object sender, ListControlConvertEventArgs e)
        {
            //Class called AboneBilgileriModel , and Firstname & Lastname are the fields
            string lastname = ((GirisCikisKayitlariModel)e.ListItem).ARAC_PLAKA;
            e.Value = lastname;
        }
       
        private void cbAboneler_SelectedIndexChanged(object sender, EventArgs e)
        {
            GirisCikisKayitlari = cbAboneler.SelectedItem as GirisCikisKayitlariModel;
            int sure = (Convert.ToDateTime(DateTime.Now.ToString()).Hour) - (Convert.ToDateTime(GirisCikisKayitlari.GIRIS_TARIHI).Hour);
            txtSure.Text = sure.ToString();
        }

        private void txtUcret_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int toplamHesap = (Convert.ToInt32(txtUcret.Text)) * (Convert.ToInt32(txtSure.Text));
                txtToplamHesap.Text = toplamHesap.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtSure_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void txtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }

        private void txtToplamHesap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;//eğer rakamsa  yazdır.
            }

            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;//eğer basılan tuş backspace ise yazdır.
            }
            else
            {
                e.Handled = true;//bunların dışındaysa hiçbirisini yazdırma
            }
        }
    }
}
