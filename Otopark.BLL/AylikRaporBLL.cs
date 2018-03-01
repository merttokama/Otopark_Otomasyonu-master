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
    public class AylikRaporBLL
    {
        public Result<List<GirisCikisKayitlariModel>> SelectAylikUcretToplami(DateTime baslangic, DateTime bitis)
        {
            Result<List<GirisCikisKayitlariModel>> rLab = new Result<List<GirisCikisKayitlariModel>>();
            List<GirisCikisKayitlariModel> GirisCikisKayitlari = new List<GirisCikisKayitlariModel>();
            SqlProvider provider = new SqlProvider("selectAylikUcretToplam", true);
            provider.AddParameter("@BaslangicTarihi", baslangic);
            provider.AddParameter("@BitisTarihi", bitis);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GirisCikisKayitlariModel GirisCikisK = new GirisCikisKayitlariModel();
                    GirisCikisK.TOPLAM = reader[0].ToString();
                    GirisCikisKayitlari.Add(GirisCikisK);
                }
            }
            reader.Close();
            rLab.TransactionResult = GirisCikisKayitlari;
            if (rLab.TransactionResult.Count > 0)
                rLab.IsSucceded = true;
            return rLab;
        }

        public Result<List<GirisCikisKayitlariModel>> SelectAylikRapor(int ay)
        {
            Result<List<GirisCikisKayitlariModel>> rLab = new Result<List<GirisCikisKayitlariModel>>();
            List<GirisCikisKayitlariModel> GirisCikisKayitlari = new List<GirisCikisKayitlariModel>();
            SqlProvider provider = new SqlProvider("selectAylikRapor", true);
            provider.AddParameter("@ay", ay);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    GirisCikisKayitlariModel GirisCikisK = new GirisCikisKayitlariModel();
                    GirisCikisK.ARAC_PLAKA = reader["ARAC_PLAKA"].ToString();
                    GirisCikisK.GIRIS_TARIHI = reader["GIRIS_TARIHI"].ToString();
                    GirisCikisK.CIKIS_TARIHI = reader["CIKIS_TARIHI"].ToString();
                    GirisCikisK.SURE_DAKIKA = int.Parse(reader["SURE_DAKIKA"].ToString());
                    GirisCikisK.UCRET = decimal.Parse(reader["UCRET"].ToString());
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
