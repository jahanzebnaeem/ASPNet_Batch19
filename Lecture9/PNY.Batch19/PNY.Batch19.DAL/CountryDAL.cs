using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using PNY.Batch19.Common;

namespace PNY.Batch19.DAL
{
    public class CountryDAL
    {
        #region Quries
        private string allCountries = @"Select * from Country";
        //private string insertCountry = @"";
        #endregion

        public List<Country> GetCountries()
        {
            SqlConnection sqlConnection = DALHelper.GetSqlConnection();
            SqlCommand sqlCommand = new SqlCommand(allCountries, sqlConnection);
            SqlDataReader sqlDataReader = null;
            List<Country> countries = null;
            sqlConnection.Open();
            try
            {
                sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    countries = new List<Country>();
                    while (sqlDataReader.Read())
                    {
                        Country country = new Country(Convert.ToInt32(sqlDataReader["ID"].ToString()), Convert.ToString(sqlDataReader["Name"].ToString()));
                        countries.Add(country);
                    }
                }
            }
            finally
            {
                if (sqlDataReader!=null)
                {
                    sqlDataReader.Close();
                }
                sqlConnection.Close();
                if (countries!=null)
                {
                    countries.TrimExcess();
                }
            }

            return countries;
        }


    }
}
