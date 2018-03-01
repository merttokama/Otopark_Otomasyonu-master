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
    public partial class frmAbonelikler : Form
    {
        AboneBilgileriBLL ab = new AboneBilgileriBLL();
        AboneliklerModel AbonelikModel = new AboneliklerModel();
        public frmAbonelikler()
        {
            InitializeComponent();
        }
        private void getAbone()
        {
            Result<List<AboneBilgileriModel>> abList = ab.SelectAboneBilgileri();
            cbAboneler.DataSource = abList.TransactionResult;
            cbAboneler.ValueMember = "ABONE_ID";
            cbAboneler.DisplayMember = "AD";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            AbonelikBLL abonelik = new AbonelikBLL();
            AbonelikModel.ABONE_ID = int.Parse(cbAboneler.SelectedValue.ToString()); //tablo öyle bak bana verdikleri tablo yani
            AbonelikModel.ABONE_UCRETI = decimal.Parse(txtUcret.Text);
            AbonelikModel.BITIS_TARIHI = dTPBitisTarih.Value.ToString();
            if (abonelik.AddAbonelik(AbonelikModel).IsSucceded)
            {
                txtUcret.Text = "";
                MessageBox.Show("Abonelik Oluşturuldu");
            }
            else
            {
                MessageBox.Show("Abonelik Oluşturmakta Bir Hata İle Karşılaşıldı.!");
            }
        }

        private void frmAbonelikler_Load(object sender, EventArgs e)
        {
            getAbone();
        }

        private void cbAboneler_Format(object sender, ListControlConvertEventArgs e)
        {
            //Class called AboneBilgileriModel , and Firstname & Lastname are the fields
            string lastname = ((AboneBilgileriModel)e.ListItem).AD;
            string firstname = ((AboneBilgileriModel)e.ListItem).SOYAD;
            e.Value = lastname + " " + firstname;
        }

        private void txtUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
