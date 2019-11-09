using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //1a) 'Switch' with no default
            txt1b.Text = Ex2gCalculations.Switch01(txt1a.Text);

            //1b) seperate if statements
            txt2b.Text = Ex2gCalculations.If01(txt1a.Text);

            //1c) else if
            txt3b.Text = Ex2gCalculations.ElseIf01(txt1a.Text);

            //1d) nested if else
            txt4b.Text = Ex2gCalculations.Nest01(txt1a.Text);

            //1e) switch w/default
            txt5b.Text = Ex2gCalculations.Switchdefault01(txt1a.Text);

            //1f) seperate if statements, default 0
            txt6b.Text = Ex2gCalculations.IfDefault01(txt1a.Text);

            //1g) if elseif with default
            txt7b.Text = Ex2gCalculations.ElseIfDefault01(txt1a.Text);

            //1h) else if r/c
            txt7b.Text = Ex2gCalculations.elseifRC01(txt1a.Text);

            //2a) seperate 'if' Statements
            txt9b.Text = Ex2gCalculations.Switch02(txt9a.Text);

            //2b) seperate 'if' statements
            txt10b.Text = Ex2gCalculations.If02(txt9a.Text);

            //2c) elseIf R/C/T
            txt10b.Text = Ex2gCalculations.



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
