using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Entity.Models
{
    public class GirisCikisKayitlariModel : BaseTypeModel
    {
        public int ABONE_ID { get; set; }
        public string ARAC_PLAKA { get; set; }
        public string GIRIS_TARIHI { get; set; } = DateTime.Now.ToString();
        public string CIKIS_TARIHI { get; set; }
        public int SURE_DAKIKA { get; set; }
        public decimal UCRET { get; set; }
        public string TOPLAM { get; set; }
       

    }
}
