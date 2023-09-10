using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calsize
{
    internal class progress
    {

        public void total (int code) 
        {
            if (code >= 1 && code <= 10)
            {
                MessageBox.Show(code + " " + "S");
            }
            else if (code >= 11 && code <= 15)
            {
                MessageBox.Show(code + " " + "M");
            }
            else if (code >= 16 && code <= 31)
            {
                MessageBox.Show(code + " " + "L");
            }
            else if (code >= 32 && code <= 100)
            {
                MessageBox.Show(code + " " + "XL");
            }


        }



        public  static double add (double num1, double num2) 
        {
            return num1 + num2;
        }

        public static double minus(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double multi(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double operationprog(double num1, double num2, string operation) 
        {
            switch(operation)
                {
                case "+":
                    return add(num1, num2);

                case "-":
                    return minus(num1, num2);

                case "*":
                    return multi(num1, num2);   

                case "/":
                    return divide(num1, num2);

                default:
                    throw new ArgumentException("invalid operation");
                
                
                
                
                }
        
        
        }
    }
}
