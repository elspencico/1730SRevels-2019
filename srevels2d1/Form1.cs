using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels2d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSetPass_Click(object sender, EventArgs e)
        {
            tbInputFrank.Text = "Frank";
            tbInputEmpty.Text = "";
            tbInput23.Text = "2.3";
            tbInputFalse.Text = "False";
            tbInputA.Text = "2";
            tbInputB.Text = "2";
            tbInputJones.Text = "xyz";
            tbInput0.Text = "1";
            tbInput2A.Text = "1";
            tbInput2B.Text = "2";
            tbInput500.Text = "500";
            tbInput3A.Text = "2";
            tbInput3B.Text = "3";
          
        }

        private void BtnSetFail_Click(object sender, EventArgs e)
        {
            tbInputFrank.Text = "xyz";
            tbInputEmpty.Text = "xyz";
            tbInput23.Text = "2.4";
            tbInputFalse.Text = "True";
            tbInputA.Text = "2";
            tbInputB.Text = "3";
            tbInputJones.Text = "Jones";
            tbInput0.Text = "0";
            tbInput2A.Text = "1";
            tbInput2B.Text = "1";
            tbInput500.Text = "499";
            tbInput3A.Text = "4";
            tbInput3B.Text = "3";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            tbCheckFrank.Text = "Fail";
            tbCheckEmpty.Text = "Fail";
            tbCheck23.Text = "Fail";
            tbCheckFalse.Text = "Fail";
            tbCheckAisB.Text = "Fail";
            tbCheckJones.Text = "Fail";
            tbCheck0.Text = "Fail";
            tbCheckAlessB.Text = "Fail";
            tbCheck500.Text = "Fail";
            tbCheckAlessisB.Text = "Fail";


            tbCheckFrank2.Text = "Pass";
            tbCheckEmpty2.Text = "Pass";
            tbCheck232.Text = "Pass";
            tbCheckFalse2.Text = "Pass";
            tbCheckAisB2.Text = "Pass";
            tbCheckJones2.Text = "Pass";
            tbCheck02.Text = "Pass";
            tbCheckAlessB2.Text = "Pass";
            tbCheck5002.Text = "Pass";
            tbCheckAlessisB2.Text = "Pass";

            if (tbInputFrank.Text == "Frank")
                tbCheckFrank.Text = "Pass";
            if(tbInputEmpty.Text == "")
                tbCheckEmpty.Text = "Pass";
            if(tbInput23.Text == "2.3")
                tbCheck23.Text = "Pass";
            if(tbInputFalse.Text == "False")
                tbCheckFalse.Text = "Pass";
            if(tbInputA.Text == tbInputB.Text)
                tbCheckAisB.Text = "Pass";
            if(tbInputJones.Text != "Jones")
                tbCheckJones.Text = "Pass";
            if(Convert.ToInt16(tbInput0.Text) > 0)
                tbCheck0.Text = "Pass";
            if(
                Convert.ToInt16(tbInput2A.Text)
                < Convert.ToInt16(tbInput2B.Text)
              )
                tbCheckAlessB.Text = "Pass";
            if(tbInput500.Text == "500")
                tbCheck500.Text = "Pass";
            if(
                Convert.ToInt16(tbInput3A.Text)
                <= Convert.ToInt16(tbInput3B.Text)
              )
                tbCheckAlessisB.Text = "Pass";

            if (tbInputFrank.Text != "Frank")
                tbCheckFrank2.Text = "Fail";
            if (tbInputEmpty.Text != "")
                tbCheckEmpty2.Text = "Fail";
            if (tbInput23.Text != "2.3")
                tbCheck232.Text = "Fail";
            if (tbInputFalse.Text != "False")
                tbCheckFalse2.Text = "Fail";
            if (tbInputA.Text != tbInputB.Text)
                tbCheckAisB2.Text = "Fail";
            if (tbInputJones.Text == "Jones")
                tbCheckJones2.Text = "Fail";
            if (Convert.ToInt16(tbInput0.Text) <= 0)
                tbCheck02.Text = "Fail";
            if (
                Convert.ToInt16(tbInput2A.Text)
                >= Convert.ToInt16(tbInput2B.Text)
              )
                tbCheckAlessB2.Text = "Fail";
            if (tbInput500.Text != "500")
                tbCheck5002.Text = "Fail";
            if (
                Convert.ToInt16(tbInput3A.Text)
                > Convert.ToInt16(tbInput3B.Text)
              )
                tbCheckAlessisB2.Text = "Fail";

        }
    }
}
