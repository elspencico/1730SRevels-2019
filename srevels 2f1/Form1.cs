using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels_2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0.0m;
            decimal discountprecent = 0.0m;

            //1: if
            /*subtotal = Decimal.Parse(txtif1.Text);
            if (subtotal >= 100)
                discountprecent = 0.2m;
            txtif2.Text = discountprecent.ToString("n2");*/
            txtif2.Text = Ex2fCalculations.Calc01(txtif1.Text);

            //2: if block
          /*  subtotal = Decimal.Parse(txtifb1.Text);
            string status = "Standard Rate: ";
            if(subtotal >= 100m)
            {
                discountprecent = 0.2m;
                status = "Bulk Rate: ";
            }*/
            txtifb2.Text = Ex2fCalculations.Calc02(txtifb1.Text);

            //3: if else
            /* subtotal = Decimal.Parse(txtelse1.Text);
             if (subtotal >= 100m)
                 discountprecent = 0.2m;
             else
                 discountprecent = 0.1m;*/
            txtelse2.Text = Ex2fCalculations.Calc03(txtelse1.Text);

            //4: if else if
           /* subtotal = Decimal.Parse(txtelseif1.Text);
            if (subtotal >= 100m && subtotal < 200m)
                discountprecent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountprecent = 0.3m;
            else if (subtotal >= 300m)
                discountprecent = 0.4m;
            else
                discountprecent = 0.1m;*/
            txtelseif2.Text = Ex2fCalculations.Calc04(txtelseif1.Text);

            //5: Better Range Test
           /* subtotal = Decimal.Parse(txtbrt1.Text);
            if (subtotal >= 300m)
                discountprecent = 0.4m;    
            else if (subtotal >= 200m)
                discountprecent = 0.3m;
            else if (subtotal >= 100m)
                discountprecent = 0.2m;
            else
                discountprecent = 0.1m;*/
            txtbrt2.Text = Ex2fCalculations.Calc05(txtbrt1.Text);

            //6: Nested if statements
           /* subtotal = Decimal.Parse(txtnest1.Text);
            string customertype = txtnest2.Text;
            discountprecent = 0m;
            if (customertype == "R")
            {
                if (subtotal >= 100m)
                    discountprecent = 0.2m;
                else
                    discountprecent = 0.1m;
            }
            else        //costomertype isn't "R"
                discountprecent = 0.4m;*/
            txtnest3.Text = Ex2fCalculations.Calc06(txtnest1.Text,txtnest2.Text);

            //7: Input Validation
            txtvi2.Text = Ex2fCalculations.Calc07(txtvi1.Text);

            //8: Price * Quantity, Ship
            txtpqs3.Text = Ex2fCalculations.Calc08(txtpqs1.Text, txtpqs2.Text);

            //9: Difference * Rate
            txtdr3.Text = Ex2fCalculations.Calc09(txtdr1.Text, txtdr2.Text);

            //10: Divide Large
            txtdl3.Text = Ex2fCalculations.Calc10(txtdl1.Text, txtdl2.Text);



        }

        private void txtif2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnest3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbrt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtelseif2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtelse2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtifb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnest2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnest1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbrt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtelseif1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtelse1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtifb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtif1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
