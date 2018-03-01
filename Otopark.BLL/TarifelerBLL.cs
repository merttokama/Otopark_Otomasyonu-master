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
    public class TarifelerBLL
    {
        public Result AddTarife(TarifelerModel ab)
        {
            Result result = new Result();
            SqlProvider provider = new SqlProvider("addTarife", true);
            provider.AddParameter("@ilkSaat", ab.ILK_SAAT);
            provider.AddParameter("@sonSaat", ab.SON_SAAT);
            provider.AddParameter("@ucret", ab.UCRET);
            provider.AddParameter("@aktif", ab.AKTIF);
            provider.AddParameter("@kayitTarihi", ab.KAYIT_TARIHI);
            if (provider.ExecuteNonQuery() > 0)
                result.IsSucceded = true;
            return result;
        }

        public Result<List<TarifelerModel>> selectTarifeler()
        {
            Result<List<TarifelerModel>> rLab = new Result<List<TarifelerModel>>();
            List<TarifelerModel> tarifeler = new List<TarifelerModel>();
            SqlProvider provider = new SqlProvider("selectTarifeler", true);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    TarifelerModel tM = new TarifelerModel();
                    tM.ID = int.Parse(reader["ID"].ToString());
                    tM.ILK_SAAT = reader["ILK_SAAT"].ToString();
                    tM.SON_SAAT = reader["SON_SAAT"].ToString();
                    tM.AKTIF = bool.Parse(reader["AKTIF"].ToString());
                    tM.UCRET = decimal.Parse(reader["UCRET"].ToString());
                    tM.KAYIT_TARIHI = reader["KAYIT_TARIHI"].ToString();
                    tarifeler.Add(tM);
                }
            }
            reader.Close();
            rLab.TransactionResult = tarifeler;
            if (rLab.TransactionResult.Count > 0)
                rLab.IsSucceded = true;
            return rLab;
        }
    }
}
