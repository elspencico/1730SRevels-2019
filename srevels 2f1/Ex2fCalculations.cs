using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace srevels_2f1
{
    public class Ex2fCalculations
    {


        public static string Calc01(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountprecent = 0.0m;

            // #1: if
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100)
                discountprecent = 0.2m;
           return discountprecent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountprecent = 0.0m;

            // #2: if {block}
            subtotal = Decimal.Parse(input);
            discountprecent = 0m;
            string status = "Standard Rate: ";
            if (subtotal >= 100m)
            {
                discountprecent = 0.2m;
                status = "Bulk Rate: ";
            }
            return status + discountprecent.ToString("n2");
        }
        public static string Calc03(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountprecent = 0.0m;

            // #3: if else
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountprecent = 0.2m;
            else
                discountprecent = 0.1m;
            return discountprecent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountprecent = 0.0m;

            // #4 if else if
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m && subtotal < 200m)
                discountprecent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountprecent = 0.3m;
            else if (subtotal >= 300m)
                discountprecent = 0.4m;
            else
                discountprecent = 0.1m;
            return discountprecent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            decimal subtotal = 0.0m;
            decimal discountprecent = 0.0m;

            // #5 Better range test
            subtotal = Decimal.Parse(input);
            if (subtotal >= 300m)
                discountprecent = 0.4m;
            else if (subtotal >= 200m)
                discountprecent = 0.3m;
            else if (subtotal >= 100m)
                discountprecent = 0.2m;
            else
                discountprecent = 0.1m;
            return discountprecent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            decimal subtotal = 0.0m;
            decimal discountprecent = 0.0m;

            // #6 Nested if
            subtotal = Decimal.Parse(inputA);
            string customertype = inputB;
            discountprecent = 0m;
            if (customertype == "R")
            {
                if (subtotal >= 100m)
                    discountprecent = 0.2m;
                else
                    discountprecent = 0.1m;
            }
            else        //costomertype isn't "R"
                discountprecent = 0.4m;
            return discountprecent.ToString("n2");

        }

        public static string Calc07(string input)
        {
            decimal ether = 0m;
            decimal dollars = Decimal.Parse(input);

            // #7 Validate input: non-empty string
            if (input == "")
            {
                return "Invalid Input";


            }
            else
            {
                ether = 200m * dollars;
                return ether.ToString("n2");
            }
        }

        public static string Calc08(string inputA, string inputB)
        {
            decimal total = 0m;
            decimal a = Convert.ToDecimal(inputA);
            decimal b = Convert.ToDecimal(inputB);

            // #8 Validate input, calculate quantity * price, shipping
            if (inputA == "" && inputB == "")
                return "Invalid Input";
            else
            {
                total = a * b;
                return total.ToString("n2");
            }

          
        }

        public static string Calc09(string inputA, string inputB)
        {
            decimal difference = 0m;
            decimal a = Decimal.Parse(inputA);
            decimal b = Decimal.Parse(inputB);

            // #9 Validate input, calculate difference * rate
            if (inputA == "" && inputB == "")
                return "Invalid Input";
            else
                difference = b - a;
            return difference.ToString(); 
        }

        public static string Calc10(string inputA, string inputB)
        {
            double result = 0.0;
            double a = Double.Parse(inputA);
            double b = Double.Parse(inputB);
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            if (inputA == "" && inputB == "")
                return "Invalid Input";
            else if (a > 0 && b > 0)
            {
                result = b / a;
                return result.ToString("n2");
            }
            else
                return "Invalid Input"; 
                    
            
        }

    }
}
