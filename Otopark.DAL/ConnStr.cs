using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.DAL
{
    public class ConnStr
    {
        public static string ConnectionString
        {
            get
            {
                return @"Server = MERTTOKAMA; Database = OtoparkDB; UID=tokama; PWD=1234";
            }
        }
    }
}
