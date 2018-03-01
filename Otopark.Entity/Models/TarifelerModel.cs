using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Entity.Models
{
    public class TarifelerModel : BaseTypeModel
    {
        public string ILK_SAAT { get; set; }
        public string SON_SAAT { get; set; }
        public decimal UCRET { get; set; }
        public bool AKTIF { get; set; }

    }
}
