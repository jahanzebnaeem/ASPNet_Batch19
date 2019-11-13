using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PNY.Batch19.Common;
using PNY.Batch19.Application;

namespace PNY.Batch19.WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Country> countries = null;
            try
            {
                countries = new CountryHelper().GetCountries();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            grdCountries.DataSource = countries;
        }
    }
}
