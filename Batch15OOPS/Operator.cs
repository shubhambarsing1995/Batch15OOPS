using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class Operator
    {
        static void Main()
        {
            //Console.WriteLine("Test");  //first line
            //Console.WriteLine("Test1"); //second line
            //Console.Write("Test2");  //third line
           // Console.Write("Test3");  //third line
             
            //Variable Declaration
            int a = 10;
            int b = 15;

            //Arithmatic Operator

            Console.WriteLine("Arithmatic Operator");

            Console.WriteLine($"Addition:{a + b}");
            Console.WriteLine($"substraction:{a - b}");
            Console.WriteLine($"Multiplication:{a * b}");
            Console.WriteLine($"Division:{ a / b}");
            Console.WriteLine($"MOD:{a % b}");

            //COMPARISION OPERATOR OR RELATION OPERATOR

            Console.WriteLine("comparision operator");
            Console.WriteLine($"a==b:{ a==b}");
            Console.WriteLine($"a!=b: {a != b}");
            Console.WriteLine($"a>b:{a > b}");
            Console.WriteLine($"a<b:{a < b}");
            Console.WriteLine($"a>=b:{a >= b}");
            Console.WriteLine($"a<=b: {a <= b}");

            //Logical Operator

            bool x = true;
            bool y = false;
            Console.WriteLine("logical operator");
            Console.WriteLine($"x&& y:{x && y}");
            Console.WriteLine($"x || y:{x || y}");
            Console.WriteLine($"!x:{!x}");







        }

    }
}
