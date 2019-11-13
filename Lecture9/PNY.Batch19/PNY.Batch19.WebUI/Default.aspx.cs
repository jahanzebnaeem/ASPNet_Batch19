using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PNY.Batch19.Common;
using PNY.Batch19.Application;

namespace PNY.Batch19.WebUI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Country> countries = null;
            try
            {
                countries = new CountryHelper().GetCountries();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.ToString();
            }
            grdCountries.DataSource = countries;
            grdCountries.DataBind();
        }
    }
}