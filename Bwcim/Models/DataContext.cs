using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
using System.Data.SqlClient;

namespace Bwcim.Models
{
    public class DataContext
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        public IEnumerable<T> Query<T>(string query, object param = null)
        {
            try
            {
                using (var con = new SqlConnection(connectionString))
                {
                    return con.Query<T>(query, param);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}