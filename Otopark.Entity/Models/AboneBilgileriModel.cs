using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Entity
{
    public class AboneBilgileriModel
    {
        public int ABONE_ID { get; set; }
        public string AD { get; set; }
        public string SOYAD { get; set; }
        public string ADRES { get; set; }
        public string ILCE { get; set; }
        public string IL { get; set; }
        public string TELEFON { get; set; }
        public string KAYIT_TARIHI { get; set; } = DateTime.Now.ToString();

        public override string ToString()
        {
            return AD + " " + SOYAD;
        }
    }
}
