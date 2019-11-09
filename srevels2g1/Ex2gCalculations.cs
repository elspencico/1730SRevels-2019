using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srevels2g1
{
    public class Ex2gCalculations
    {
        public static string Switch01(string customertype)
        {
            // 1a) 'Switch' with no default
            decimal discountPercent = -1m;
            
            switch(customertype)
            {
                case "R":
                    discountPercent = .1m;
                    break;

                case "C":
                    discountPercent = .2m;
                    break;
            }

            return discountPercent.ToString("0.0");

        }


        public static string If01(string customertype)
        {
            //1b)  seperate if statements
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            if (customertype == "C")
                discountpercent = .2m;

            return discountpercent.ToString("0.0");

        }

        public static string ElseIf01(string customertype)
        {
            //1c) if elseif
            decimal discoutpercent = -1m;

            if (customertype == "R")
                discoutpercent = .1m;
            else if (customertype == "C")
                discoutpercent = .2m;

            return discoutpercent.ToString("0.0");
        }

        public static string NestedIfElse01(string customertype)
        {
            //1d) Nested if else
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            else
                if (customertype == "C")
                    discountpercent = .2m;

            return discountpercent.ToString("0.0");

        }

        public static string SwitchDefault01(string customertype)
        {
            //1e) Switch w/default
            decimal discountpercent = -1m;

            switch(customertype)
            {
                case "R":
                    discountpercent = .1m;
                    break;
                case "C":
                    discountpercent = .2m;
                    break;

                default:
                    discountpercent = .0m;
                    break;
            }

            return discountpercent.ToString("0.0");

        }

        public static string IfDefault01(string customertype)
        {
            //1f) seperate if statements, default 0
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            if (customertype == "C")
                discountpercent = .2m;
            if (customertype != "R" && customertype != "R")
                discountpercent = .0m;

            return discountpercent.ToString("0.0");

        }

        public static string ElseIfDefault01(string customertype)
        {
            //ig elseif with default
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            else if (customertype == "C")
                discountpercent = .2m;
            else
                discountpercent = .0m;

            return discountpercent.ToString("0.0");

        }

        public static string NestedIfElseDefault01(string customertype)
        {
            //1h) nested else if with default
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            else
            {
                if (customertype == "C")
                    discountpercent = .2m;

                else
                    discountpercent = .0m;
            }
            return discountpercent.ToString("0.0");
        }

        public static string Switch02(string customertype)
        {
            //2a 'Switch' with no default
            decimal discountpercent = -1m;

            switch(customertype)
            {
                case "R":
                case "C":
                    discountpercent = .2m;
                    break;

                case "T": 
                    discountpercent = .4m;
                    break;
            }
            return discountpercent.ToString("0.0");


        }

        public static string If02(string customertype)
        {
            //2b)  seperate if statements
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            if (customertype == "C")
                discountpercent = .2m;
            if (customertype == "T")
                discountpercent = .4m;

            return discountpercent.ToString("0.0");
        }

        public static string ElseIf02(string customertype)
        {
            //2c) elseif R/C/T 
            decimal discoutpercent = -1m;

            if (customertype == "R")
                discoutpercent = .1m;
            else if (customertype == "C")
                discoutpercent = .2m;
            else if (customertype == "T")
                discoutpercent = .4m;

            return discoutpercent.ToString("0.0");
        }

        public static string NestedIfElse02(string customertype)
        {
            //2d) nested if else
            decimal discountpercent = -1m;

            if (customertype == "R")
                discountpercent = .1m;
            else
                if (customertype == "C")
                discountpercent = .2m;
            else
                if (customertype == "T")
                discountpercent = .4m;

            return discountpercent.ToString("0.0");


        }

    }
}
