using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels_1g1
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

        private void Btnbutton1_Click(object sender, EventArgs e)
        {
            // 1
            txtlabel1c.Text = txtlabel1a.Text + txtlabel1b.Text;
            // 2
            txtlabel2c.Text = (
                    Convert.ToInt32(txtlabel2a.Text) + Convert.ToInt32(txtlabel2b.Text)
                ).ToString();
            // 3
            txtlabel3c.Text = (
                    Convert.ToInt32(txtlabel3a.Text + txtlabel3b.Text)
                ).ToString();
            // 4
            txtlabel1a.Text = (
                Convert.ToInt32(txtlabel1b.Text).ToString() + txtlabel1c.Text
                ).ToString();
            // 5
            txtlabel2a.Text = txtlabel2b.Text + Convert.ToInt32(txtlabel2c.Text).ToString();
            // 6
            txtlabel3a.Text = (
                    txtlabel3b.MaxLength + txtlabel3c.SelectionLength
                ).ToString();
            // 7
            txtlabel1b.Text = (
                    Convert.ToInt32(txtlabel1a.Text) - Convert.ToInt32(txtlabel1c.Text)
                ).ToString("n2");
            // 8
            txtlabel2b.Text = (
                    Convert.ToDecimal(txtlabel1a.Text) * Convert.ToDecimal(txtlabel1c.Text)
                ).ToString("n2");
            // 9
            txtlabel3b.Text = (
                    Convert.ToDecimal(txtlabel3a.Text) / Convert.ToDecimal(txtlabel3c.Text)
                ).ToString("n2");
        }
    }
}
