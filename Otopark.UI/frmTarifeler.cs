using Otopark.BLL;
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
    public partial class frmTarifeler : Form
    {
        TarifelerBLL ab = new TarifelerBLL();
        TarifelerModel TarifeModel = new TarifelerModel();
        public frmTarifeler()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TarifeModel.ILK_SAAT = dTPIlkSaat.Value.ToString();
            TarifeModel.SON_SAAT = dTPSonSaat.Value.ToString();
            TarifeModel.UCRET = int.Parse(txtUcret.Text);
            TarifeModel.AKTIF = true;
            if (ab.AddTarife(TarifeModel).IsSucceded)
            {
                txtUcret.Text = "";
                MessageBox.Show("Tarife Oluşturuldu");
            }
            else
            {
                MessageBox.Show("Tarife Oluşturulurken Hata İle Karşılaşıldı.!");
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
    }
}
