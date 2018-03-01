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
    public class AboneBilgileriBLL
    {
        public Result AddAboneBilgi(AboneBilgileriModel ab)
        {
            Result result = new Result();
            SqlProvider provider = new SqlProvider("addAboneBilgi", true);
            provider.AddParameter("@ad", ab.AD);
            provider.AddParameter("@soyad", ab.SOYAD);
            provider.AddParameter("@adres", ab.ADRES);
            provider.AddParameter("@il", ab.IL);
            provider.AddParameter("@ilce", ab.ILCE);
            provider.AddParameter("@telefon", ab.TELEFON);
            provider.AddParameter("@kayitTarihi", ab.KAYIT_TARIHI);
            if (provider.ExecuteNonQuery() > 0)
                result.IsSucceded = true;
            return result;
        }

        public Result<List<AboneBilgileriModel>> SelectAboneBilgileri()
        {
            Result<List<AboneBilgileriModel>> rLab = new Result<List<AboneBilgileriModel>>();
            List<AboneBilgileriModel> aboneBilgileri = new List<AboneBilgileriModel>();
            SqlProvider provider = new SqlProvider("selectAboneBilgi", true);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AboneBilgileriModel ab = new AboneBilgileriModel();
                    ab.ABONE_ID = int.Parse(reader["ABONE_ID"].ToString());
                    ab.AD = reader["AD"].ToString();
                    ab.SOYAD = reader["SOYAD"].ToString();
                    ab.ADRES = reader["ADRES"].ToString();
                    ab.IL = reader["IL"].ToString();
                    ab.ILCE = reader["ILCE"].ToString();
                    ab.TELEFON = reader["TELEFON"].ToString();
                    ab.KAYIT_TARIHI = reader["KAYIT_TARIHI"].ToString();
                    aboneBilgileri.Add(ab);
                }
            }
            reader.Close();
            rLab.TransactionResult = aboneBilgileri;
            if (rLab.TransactionResult.Count > 0)
                rLab.IsSucceded = true;
            return rLab;
        }
    }
}
