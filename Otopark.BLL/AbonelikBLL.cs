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
    public class AbonelikBLL
    {
        public Result AddAbonelik(AboneliklerModel ab)
        {
            Result result = new Result();
            SqlProvider provider = new SqlProvider("addAbonelik", true);
            provider.AddParameter("@aboneId", ab.ABONE_ID);
            provider.AddParameter("@baslangicTarihi", Convert.ToDateTime(ab.BASLANGIC_TARIHI));
            provider.AddParameter("@bitisTarihi", Convert.ToDateTime(ab.BITIS_TARIHI));
            provider.AddParameter("@aboneUcret", ab.ABONE_UCRETI);
            provider.AddParameter("@kayitTarihi", ab.KAYIT_TARIHI);
            if (provider.ExecuteNonQuery() > 0)
                result.IsSucceded = true;
            return result;
        }
        public Result<List<AboneliklerModel>> SelectAbonelikler()
        {
            Result<List<AboneliklerModel>> rLab = new Result<List<AboneliklerModel>>();
            List<AboneliklerModel> abonelikler = new List<AboneliklerModel>();
            SqlProvider provider = new SqlProvider("selectAbonelikler", true);
            provider.OpenConnection();
            SqlDataReader reader = provider.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AboneliklerModel aboneModel = new AboneliklerModel();
                    aboneModel.ID = int.Parse(reader["ID"].ToString());
                    aboneModel.ABONE_ID = int.Parse(reader["ABONE_ID"].ToString());
                    aboneModel.BASLANGIC_TARIHI = reader["BASLANGIC_TARIHI"].ToString();
                    aboneModel.BITIS_TARIHI = reader["BITIS_TARIHI"].ToString();
                    aboneModel.ABONE_UCRETI = Convert.ToDecimal(reader["ABONE_UCRETI"].ToString());
                    aboneModel.KAYIT_TARIHI = reader["KAYIT_TARIHI"].ToString();
                    abonelikler.Add(aboneModel);
                }
            }
            reader.Close();
            rLab.TransactionResult = abonelikler;
            if (rLab.TransactionResult.Count > 0)
                rLab.IsSucceded = true;
            return rLab;
        }
    }
}
