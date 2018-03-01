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
    public class AracGirisiBLL
    {
        public Result AddAracGiris(GirisCikisKayitlariModel ab)
        {
            Result result = new Result();
            SqlProvider provider = new SqlProvider("addAracGirisi", true);
            provider.AddParameter("@aboneId", ab.ABONE_ID);
            provider.AddParameter("@aracPlaka", ab.ARAC_PLAKA);
            provider.AddParameter("@girisTarihi", Convert.ToDateTime(ab.GIRIS_TARIHI));
            provider.AddParameter("@ucret", ab.UCRET);
            provider.AddParameter("@kayitTarihi", ab.KAYIT_TARIHI);
            if (provider.ExecuteNonQuery() > 0)
                result.IsSucceded = true;
            return result;
        }

        public Result<List<GirisCikisKayitlariModel>> SelectGirisCikisKayitlari()
        {
            Result<List<GirisCikisKayitlariModel>> rLab = new Result<List<GirisCikisKayitlariModel>>();
            List<GirisCikisKayitlariModel> GirisCikisKayitlari = new List<GirisCikisKayitlariModel>();
            SqlProvider provider = new SqlProvider("selectGirisCikisKayitlari", true);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GirisCikisKayitlariModel GirisCikisK = new GirisCikisKayitlariModel();
                    GirisCikisK.ID = int.Parse(reader["ID"].ToString());
                    GirisCikisK.ABONE_ID = int.Parse(reader["ABONE_ID"].ToString());
                    GirisCikisK.ARAC_PLAKA = reader["ARAC_PLAKA"].ToString();
                    GirisCikisK.GIRIS_TARIHI = reader["GIRIS_TARIHI"].ToString();
                    GirisCikisK.CIKIS_TARIHI = reader["CIKIS_TARIHI"].ToString();
                    try
                    {
                        GirisCikisK.SURE_DAKIKA = int.Parse(reader["SURE_DAKIKA"].ToString());
                    }
                    catch (Exception)
                    {

                    }

                    GirisCikisK.UCRET = decimal.Parse(reader["UCRET"].ToString());
                    GirisCikisK.KAYIT_TARIHI = reader["KAYIT_TARIHI"].ToString();
                    GirisCikisKayitlari.Add(GirisCikisK);
                }
            }


            reader.Close();
            rLab.TransactionResult = GirisCikisKayitlari;
            if (rLab.TransactionResult.Count > 0)
                rLab.IsSucceded = true;
            return rLab;
        }

        public Result<List<GirisCikisKayitlariModel>> SelectPlakaHareketleri()
        {
            Result<List<GirisCikisKayitlariModel>> rLab = new Result<List<GirisCikisKayitlariModel>>();
            List<GirisCikisKayitlariModel> GirisCikisKayitlari = new List<GirisCikisKayitlariModel>();
            SqlProvider provider = new SqlProvider("selectPlakaHareketleri", true);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GirisCikisKayitlariModel plakaHareketleri = new GirisCikisKayitlariModel();
                    plakaHareketleri.ARAC_PLAKA = reader["ARAC_PLAKA"].ToString();
                    plakaHareketleri.GIRIS_TARIHI = reader["GIRIS_TARIHI"].ToString();
                    plakaHareketleri.CIKIS_TARIHI = reader["CIKIS_TARIHI"].ToString();
                    plakaHareketleri.SURE_DAKIKA = int.Parse(reader["SURE_DAKIKA"].ToString());
                    GirisCikisKayitlari.Add(plakaHareketleri);
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
