using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Entity
{
    public class BaseTypeModel
    {
        public int ID { get; set; }
        public string KAYIT_TARIHI { get; set; } = DateTime.Now.ToString();
    }
}
