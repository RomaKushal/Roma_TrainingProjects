using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MVCApplication.CommonClass
{
    public class ConnectionHelper
    {
        public SqlConnection DBConnection = new SqlConnection (ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        /// <summary>
        /// It fetches the data from Database based on query
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable GetData(string query)
        {
            DataTable result = new DataTable();
            try
            {
                this.DBConnection.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter(query, DBConnection);
                sqlda.Fill(result);
            }
            catch (Exception)
            {
                return result;
            }
            finally
            {
                this.DBConnection.Close();
            }

            return result;
        }

        /// <summary>
        /// This function inserts the data
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int InsertData(string query)
        {
            int result = 0;
            try
            {
                this.DBConnection.Open();
                SqlCommand sqlcommand = new SqlCommand(query, DBConnection);
                result = sqlcommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.DBConnection.Close();
            }

            return result;
        }

    }
}