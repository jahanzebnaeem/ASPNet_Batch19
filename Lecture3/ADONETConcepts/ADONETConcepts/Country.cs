using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONETConcepts
{
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
        }

        private void frmCountry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pNYASPBatch19DataSet.Country' table. You can move, or remove it, as needed.
            this.countryTableAdapter.Fill(this.pNYASPBatch19DataSet.Country);

        }
    }
}
