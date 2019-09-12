using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            txtAmount.Text = (
                (
                Convert.ToDecimal(txtTest1.Text)
                + Convert.ToDecimal(txtTest2.Text)
                + Convert.ToDecimal(txtTest3.Text)
                ) / 3
                ).ToString("0.0");
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
            txtAmount.Text = "0";

            txtTest1.Focus();
        }
    }
}
