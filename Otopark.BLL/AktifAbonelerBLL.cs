using Otopark.DAL;
using Otopark.Entity;
using Otopark.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.BLL
{
    public class AktifAbonelerBLL
    {
        public Result<List<AktifAbonelerModel>> SelectAktifAboneler()
        {
            Result<List<AktifAbonelerModel>> aAboneler = new Result<List<AktifAbonelerModel>>();
            List<AktifAbonelerModel> aktifAboneBilgileri = new List<AktifAbonelerModel>();
            SqlProvider provider = new SqlProvider("selectAboneligiAktifOlanlar", true);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AktifAbonelerModel ab = new AktifAbonelerModel();
                    ab.AD = reader["AD"].ToString();
                    ab.SOYAD = reader["SOYAD"].ToString();
                    ab.ADRES = reader["ADRES"].ToString();
                    ab.IL = reader["IL"].ToString();
                    ab.ILCE = reader["ILCE"].ToString();
                    ab.TELEFON = reader["TELEFON"].ToString();
                    aktifAboneBilgileri.Add(ab);
                }
            }
            reader.Close();
            aAboneler.TransactionResult = aktifAboneBilgileri;
            if (aAboneler.TransactionResult.Count > 0)
                aAboneler.IsSucceded = true;
            return aAboneler;
        }
    }
}
