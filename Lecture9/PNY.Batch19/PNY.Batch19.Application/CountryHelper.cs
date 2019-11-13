using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PNY.Batch19.Common;
using PNY.Batch19.DAL;

namespace PNY.Batch19.Application
{
    public class CountryHelper
    {
        List<Country> countries = new List<Country>();

        public CountryHelper() { }

        public List<Country> GetCountries()
        {
            return new CountryDAL().GetCountries();
        }
    }
}
