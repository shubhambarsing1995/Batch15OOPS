using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{  class Calculator
    {
        public double Calculation(int a, double b)
        {
            return a + b;
        }
        public double Calculation(double a, int b)
        {
            return a - b;
        }
        public double Calculation(double a, double b)
        {
            return a * b;
        }
        public double Calculation(int a, int b)
        {
            return a / b;
        }
    }
    class StaticPloyAssignment
    {
        static void Main()
        {
            Calculator calci = new Calculator();
            double sum = calci.Calculation(7,9.5);
            double subtract = calci.Calculation(7.8,5);
            double multiply = calci.Calculation(7.5,9.5);
            double division = calci.Calculation(7,9);


            Console.WriteLine($"sum of integer value:{sum}");
            Console.WriteLine($"subtraction of integer value:{subtract}");
            Console.WriteLine($"multiplication of integer value:{multiply}");
            Console.WriteLine($"division of integer value:{division}");



        }


    }
}
