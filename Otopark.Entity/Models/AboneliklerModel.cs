using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Entity.Models
{
    public class AboneliklerModel : BaseTypeModel
    {
        public int ABONE_ID { get; set; }
        public string BASLANGIC_TARIHI { get; set; } = DateTime.Now.ToString();
        public string BITIS_TARIHI { get; set; }
        public decimal ABONE_UCRETI { get; set; }
    }
}
