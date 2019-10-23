using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppSample
{
    public partial class frmCountry : Form
    {
        public frmCountry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Iteration 1
            // lblMessage.Text = txtName.Text + ", hello and welcome to batch 19";

            // Iteration 2
            // Add two textboxes and add there values.
            // lblMessage.Text = Convert.ToString(Convert.ToInt32(txtName.Text) + Convert.ToInt32(lblNumber.Text));

            // Iteration 3
            // Work it with method
            // calculateValue();

            // Iteration 4
            // Work it with function
            lblMessage.Text = calculateValue(Convert.ToInt32(txtName.Text), Convert.ToInt32(txtNumber.Text));
        }

        /// <summary>
        /// Requires to generate a method
        /// <para>No Parameters</para>
        /// <return>Nothing</return>
        /// </summary>
        private void calculateValue()
        {
            lblMessage.Text = Convert.ToString(Convert.ToInt32(txtName.Text) + Convert.ToInt32(txtNumber.Text));
        }

        /// <summary>
        /// Adds the values of two controls
        /// </summary>
        /// <param name="a">Operand 1 in integer</param>
        /// <param name="b">Operand 2 in integer</param>
        /// <return>String value</return>
        /// <returns></returns>
        private string calculateValue(int a, int b)
        {
            // Code logic
            return Convert.ToString(a + b);
        }
    }
}
