using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels_2B1
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

        private void TextChangedAustralia(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtAustralianDollar.Text);
            decimal rate = Convert.ToDecimal(txtAustraliaRate.Text);
            decimal USD = 0.00m;

            USD = amount * rate;

            txtAustralianUSD.Text = Convert.ToString(USD);

            txtUSDTotal.Text = (

                Convert.ToDecimal(txtAustralianUSD.Text)
                + Convert.ToDecimal(txtBhutanUSD.Text)
                + Convert.ToDecimal(txtCostaRicaUSD.Text)
                + Convert.ToDecimal(txtRateUSD.Text)
                ).ToString("0.00");
        }

        private void TextChangedBhutan(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtBhutanAmount.Text);
            decimal rate = Convert.ToDecimal(txtBhutanRate.Text);
            decimal USD = 0.00m;

            USD = amount * rate;

            txtBhutanUSD.Text = Convert.ToString(USD);

           
            txtUSDTotal.Text = (

                Convert.ToDecimal(txtAustralianUSD.Text)
                + Convert.ToDecimal(txtBhutanUSD.Text)
                + Convert.ToDecimal(txtCostaRicaUSD.Text)
                + Convert.ToDecimal(txtRateUSD.Text)
                ).ToString("0.00");

        }

        private void TextChangedCostaRica(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtCostaRicaAmount.Text);
            decimal rate = Convert.ToDecimal(txtCostaRicaRate.Text);
            decimal USD = 0.00m;

            USD = amount * rate;

            txtCostaRicaUSD.Text = Convert.ToString(USD);

            txtUSDTotal.Text = (

                Convert.ToDecimal(txtAustralianUSD.Text)
                + Convert.ToDecimal(txtBhutanUSD.Text)
                + Convert.ToDecimal(txtCostaRicaUSD.Text)
                + Convert.ToDecimal(txtRateUSD.Text)
                ).ToString("0.00");

        }

        private void TextChangedEuro(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtEuroAmount.Text);
            decimal rate = Convert.ToDecimal(txtEuroRate.Text);
            decimal USD = 0.00m;

            USD = amount * rate;

           txtRateUSD.Text = Convert.ToString(USD);

           txtUSDTotal.Text = (

                Convert.ToDecimal(txtAustralianUSD.Text)
                + Convert.ToDecimal(txtBhutanUSD.Text)
                + Convert.ToDecimal(txtCostaRicaUSD.Text)
                + Convert.ToDecimal(txtRateUSD.Text)
                ).ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAustralianDollar.Text = "0.00";
            txtAustraliaRate.Text = "0.717976";
            txtBhutanAmount.Text = "0.00";
            txtBhutanRate.Text = "0.0139831";
            txtCostaRicaAmount.Text = "0.00";
            txtCostaRicaRate.Text = "0.00176122";
            txtEuroAmount.Text = "0.00";
            txtEuroRate.Text = "1.15528";
        }
    }
}
