using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels_1f1
{
    public partial class fmCurrencyConverterV2 : Form
    {
        public fmCurrencyConverterV2()
        {
            InitializeComponent();
        }

        private void FmCurrencyConverterV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = pbAustralia.Image;
            btnBhutan.BackgroundImage = pbBhutanD.Image;
            btnCostaRica.BackgroundImage = pbCostaRicaD.Image;
            btnEU.BackgroundImage = pbEUD.Image;
            

        }

        private void BtnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = pbAustralia.Image;
            btnBhutan.BackgroundImage = pbBhutanD.Image;
            btnCostaRica.BackgroundImage = pbCostaRicaD.Image;
            btnEU.BackgroundImage = pbEUD.Image;
            lblCountry.Text = "Australian Dollar";
            txtRate.Text = "0.685304";
        }

        private void BtnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = pbBhutan.Image;
            btnAustralia.BackgroundImage = pbAustraliaD.Image;
            btnCostaRica.BackgroundImage = pbCostaRicaD.Image;
            btnEU.BackgroundImage = pbEUD.Image;
            lblCountry.Text = "Bhutanese Ngultrum";
            txtRate.Text = "0.0139339";
        }

        private void BtnCostaRica_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = pbAustraliaD.Image;
            btnBhutan.BackgroundImage = pbBhutanD.Image;
            btnCostaRica.BackgroundImage = pbCostaRica.Image;
            btnEU.BackgroundImage = pbEUD.Image;
            lblCountry.Text = "Costa Rican Colon";
            txtRate.Text = "0.00173439";
        }

        private void BtnEU_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = pbAustraliaD.Image;
            btnBhutan.BackgroundImage = pbBhutanD.Image;
            btnCostaRica.BackgroundImage = pbCostaRicaD.Image;
            btnEU.BackgroundImage = pbEU.Image;
            lblCountry.Text = "Euro";
            txtRate.Text = "1.10073";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void CurrencyTextChanged(object sender, EventArgs e)
        {
            txtUS.Text = (
                Convert.ToDecimal(txtAmount.Text)
                * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "0.00";
            txtRate.Text = "0.00";
            txtTotal.Text = "0.00";
            txtUS.Text = "0.00";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotal.Text = (
                Convert.ToDecimal(txtUS.Text)
                + Convert.ToDecimal(txtTotal.Text)
                ).ToString("0.00");
        }
    }
}
