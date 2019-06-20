using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;



//BURASI ADONETE GİRDİĞİ İÇİN BURASI OLMADI BURAYI SİLECEĞİM
namespace VoyageFramework.DAL
{
    public class AdoProvider
    {
        private SqlConnection connection;
        public AdoProvider(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed) connection.Open();
        }
        private void CloseConnection()
        {
            if (connection.State == ConnectionState.Open) connection.Close();
        }

        public int ExecuteNonQuery(string commandText, Dictionary<string,object>parameters=null)
        {
            SqlCommand komut = new SqlCommand(commandText, connection);
            if (parameters!=null)
            {
                foreach (var item in parameters)
                {
                    if (komut.CommandText.Contains(item.Key))
                        komut.Parameters.AddWithValue(item.Key, item.Value);
                    else
                        throw new ArgumentException(string.Format("Böyle bir parametre bulunamadı:{0}", item.Key));

                }
                int result = default(int);
                try
                {
                    OpenConnection();
                    result = komut.ExecuteNonQuery();
                }
                catch { }
                finally { CloseConnection(); }
                return result;
            }
        }
        public object ExecuteScalar(string commandText, Dictionary<string,object>parameters=null)
        {
            SqlCommand komut = new SqlCommand(commandText, connection);
            if(parameters!=null)
            {
                foreach (var item in parameters)
                {
                    if (komut.CommandText.Contains(item.Key))
                        komut.Parameters.AddWithValue(item.Key, item.Value);
                    else
                        throw new ArgumentException(string.Format("Böyle bir parametre bulunamadı:{0}", item.Key));
                }
                object result = default(object);
                try
                {
                    OpenConnection();
                    result = komut.ExecuteScalar();
                }
                catch { }
                finally { CloseConnection(); }
                return result;
            }
        }
        public T ExecuteScalar<T>(string commandText, Dictionary<string, object> parameters = null)
        {
            SqlCommand komut = new SqlCommand(commandText, connection);
            if(parameters!=null)
            {
                foreach (var item in parameters)
                {
                    if (komut.CommandText.Contains(item.Key)) komut.Parameters.AddWithValue(item.Key, item.Value);
                    else
                        throw new ArgumentException(string.Format("Böyle bir parametre bulunamadı:{0}", item.Key));
                }
                object result = default(object);
                try
                {
                    OpenConnection();
                    result = komut.ExecuteScalar();
                }
                catch { }
                finally { CloseConnection(); }
                return (T)Convert.ChangeType(result, typeof(T));
            }
        }
        public DataAdapter ExecuteAdapter(string commandText, Dictionary<string, object> parameters = null)
        {
            SqlCommand komut = new SqlCommand(commandText, connection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            if (parameters != null)
            {
                foreach (var item in parameters)
                {
                    if (komut.CommandText.Contains(item.Key))
                        komut.Parameters.AddWithValue(item.Key, item.Value);
                    else
                        throw new ArgumentException(string.Format("Böyle bir parametre bulunamadı:{0}", item.Key));
                }
            }
            SqlDataReader sqlDataReader =default (SqlDataReader);
            try
            {
                sqlDataAdapter.SelectCommand = komut;
                sqlDataAdapter.Fill(dataTable);
            }
            catch { }
            finally { CloseConnection(); }
            return dataTable;
        }
    }
}
