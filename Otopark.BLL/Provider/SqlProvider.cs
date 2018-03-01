using Otopark.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.BLL
{
    public class SqlProvider
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public SqlProvider(string commandText, bool isProcedure)
        {
            cnn = new SqlConnection(ConnStr.ConnectionString);
            cmd = new SqlCommand(commandText, cnn);
            cmd.CommandType = isProcedure ? System.Data.CommandType.StoredProcedure : System.Data.CommandType.Text;
        }
        public void OpenConnection()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }
        public void CloseConnection()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public SqlDataReader ExecuteReader()
        {
            OpenConnection();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        public int ExecuteNonQuery()
        {
            int result = -1;
            try
            {
                OpenConnection();
                result = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                result = -1;
            }
            catch (Exception)
            {
                result = -1;

            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
        public void AddParameter(string parameterName, object value)
        {
            cmd.Parameters.AddWithValue(parameterName, value);
        }
    }
}

