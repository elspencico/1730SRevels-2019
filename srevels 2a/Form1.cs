using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels_2a
{
    public partial class frmVariables : Form
    {
        public frmVariables()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            decimal total = 0.0m;
            decimal discountPercent = Convert.ToDecimal(txtDiscountPercent.Text);
            decimal discountAmount = 0.0m;
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);

            discountAmount = subtotal * (discountPercent / 100);
            total = subtotal - discountAmount;

            txtTotal.Text = Convert.ToString(total);
            txtDiscountAmount.Text = Convert.ToString(discountAmount);


        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtDiscountAmount.Text = "0.0";
            txtDiscountPercent.Text = "0.0";
            txtSubtotal.Text = "0.0";
            txtTotal.Text = "0.0";
        }
    }
}
