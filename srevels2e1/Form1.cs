using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels2e1
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
            tb01r.Text = "";
            tb02r.Text = "";
            tb03r.Text = "";
            tb04r.Text = "";
            tb04s.Text = "";
            tb05r.Text = "";
            tb05s.Text = "";
            tb06r.Text = "";
            tb06s.Text = "";
            tb07r.Text = "";
            tb08r.Text = "";
            tb09r.Text = "";
            tb10r.Text = "";
            tb10s.Text = "";



            decimal subtotal = Convert.ToDecimal(tb01.Text);
            tb01r.Text = (LogicalOperations.q01(subtotal)).ToString();

            int timeinservice = Convert.ToInt32(tb02.Text);
            tb02r.Text = (LogicalOperations.q02(timeinservice)).ToString();

            bool isvialid = Convert.ToBoolean(tb031.Text);
            int years = Convert.ToInt32(tb033.Text);
            int counter = Convert.ToInt32(tb032.Text);
            tb03r.Text =
                (
                    isvialid == true & counter++ < years
                ).ToString();
            tb03s.Text = counter.ToString();

            counter = Convert.ToInt32(tb032.Text);
            tb04r.Text =
                (
                    isvialid == true & counter++ < years
                ).ToString();
            tb04s.Text = counter.ToString();

            counter = Convert.ToInt32(tb032.Text);
            tb05r.Text = 
                (
                    isvialid == true && counter++ < years
                ).ToString();
            tb05s.Text = counter.ToString();

            counter = Convert.ToInt32(tb032.Text);
            tb06r.Text =
                (
                    isvialid == true || counter++ < years
                ).ToString();
            tb06s.Text = counter.ToString();

            DateTime startDate = Convert.ToDateTime(tb071.Text);
            DateTime expirationDate = Convert.ToDateTime(tb072.Text);
            DateTime date = Convert.ToDateTime(tb073.Text);
            isvialid = Convert.ToBoolean(tb074.Text);
            tb07r.Text = 
                (
                    date > startDate && date < expirationDate || isvialid == true
                ).ToString();

            decimal thisYTD = Convert.ToDecimal(tb081.Text);
            decimal lastYTD = Convert.ToDecimal(tb082.Text);
            string empType = tb083.Text;
            int startyear = Convert.ToInt32(tb084.Text);
            int currentYear = Convert.ToInt32(tb085.Text);
            tb08r.Text =
                (
                    ((thisYTD > lastYTD) || empType == "Part time") 
                    && startyear < currentYear
                ).ToString();

            counter = Convert.ToInt32(tb091.Text);
            years = Convert.ToInt32(tb092.Text);
            tb09r.Text =
                (
                    !(counter++ >= years)
                ).ToString();
            tb09s.Text = counter.ToString();

            int a = Convert.ToInt32(tb101.Text);
            int b = Convert.ToInt32(tb102.Text);
            int c = Convert.ToInt32(tb103.Text);
            int d = Convert.ToInt32(tb104.Text);
            tb10r.Text =
                (
                    a > b && (b < c || c < d)
                ).ToString();

            bool v = a > b;
            bool w = b < c;
            bool x = c < d;
            bool y = v && w;
            bool z = y || x;
            tb10r.Text = z.ToString();
            
        }
    }
}
