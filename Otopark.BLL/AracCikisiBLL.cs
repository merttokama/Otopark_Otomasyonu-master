using Otopark.DAL;
using Otopark.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.BLL
{
    public class AracCikisiBLL
    {
        public Result UpdateAracCikisi(GirisCikisKayitlariModel arac)
        {

            Result result = new Result();
            SqlProvider provider = new SqlProvider("updateAracCikisi", true);
            provider.AddParameter("@id", arac.ID);
            provider.AddParameter("@sureDakika", arac.SURE_DAKIKA);
            provider.AddParameter("@cikisTarihi", Convert.ToDateTime(arac.CIKIS_TARIHI));
            provider.AddParameter("@ucret", arac.UCRET);
            if (provider.ExecuteNonQuery() > 0)
                result.IsSucceded = true;
            return result;
        }
        public Result<List<GirisCikisKayitlariModel>> selectOtoparktakiAraclar()
        {
            Result<List<GirisCikisKayitlariModel>> rLab = new Result<List<GirisCikisKayitlariModel>>();
            List<GirisCikisKayitlariModel> GirisCikisKayitlari = new List<GirisCikisKayitlariModel>();
            SqlProvider provider = new SqlProvider("selectOtoparktakiAraclar", true);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GirisCikisKayitlariModel GirisCikisK = new GirisCikisKayitlariModel();
                    GirisCikisK.ID = int.Parse(reader["ID"].ToString());
                    GirisCikisK.ARAC_PLAKA = reader["ARAC_PLAKA"].ToString();
                    GirisCikisK.GIRIS_TARIHI = reader["GIRIS_TARIHI"].ToString();
                    GirisCikisKayitlari.Add(GirisCikisK);
                }
            }
            reader.Close();
            rLab.TransactionResult = GirisCikisKayitlari;
            if (rLab.TransactionResult.Count > 0)
                rLab.IsSucceded = true;
            return rLab;
        }
    }
}
    