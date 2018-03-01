using Otopark.BLL;
using Otopark.Entity;
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
    public partial class frmAboneBilgisi : Form
    {
        AboneBilgileriBLL ab = new AboneBilgileriBLL();
        AboneBilgileriModel AboneBilgisiModel = new AboneBilgileriModel();
        public frmAboneBilgisi()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AboneBilgisiModel.AD = txtAd.Text;
            AboneBilgisiModel.SOYAD = txtSoyad.Text;
            AboneBilgisiModel.ADRES = txtAdres.Text;
            AboneBilgisiModel.IL = txtIl.Text;
            AboneBilgisiModel.ILCE = txtIlce.Text;
            AboneBilgisiModel.TELEFON = txtTelefon.Text;
            if (ab.AddAboneBilgi(AboneBilgisiModel).IsSucceded)
            {
                txtAd.Text = "";
                txtSoyad.Text = "";
                txtAdres.Text = "";
                txtIl.Text = "";
                txtIlce.Text = "";
                txtTelefon.Text = "";
                MessageBox.Show("Abone Bilgisi Oluşturuldu");
            }
            else
            {
                MessageBox.Show("Abone Bilgisi Oluşturulurken Bir Hata Oluştu.!");
            }
        }

        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtAdres_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtIl_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtIlce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
            && !char.IsSeparator(e.KeyChar);
        }

        private void txtTelefon_KeyPress(object sender, KeyPressEventArgs e)
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
