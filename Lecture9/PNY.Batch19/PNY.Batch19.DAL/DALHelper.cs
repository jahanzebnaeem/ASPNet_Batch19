using System.Data.SqlClient;
using System.Configuration;

namespace PNY.Batch19.DAL
{
    public class DALHelper
    {
        public static SqlConnection GetSqlConnection()
        {
            string conString = @"Data Source=.;Initial Catalog=PNYASPBatch19;User ID=sa;Password=1234";
            //string conString = ConfigurationManager.ConnectionStrings["connectionStringName"].ConnectionString; ;
            return new SqlConnection(conString);
        }
    }
}
