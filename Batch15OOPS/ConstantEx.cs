using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class ConstangEg
    {
        //normal variable declaration
        public int a = 10;
        public string name = "test";

        //declaration of constant variables
        public const double pi = 3.15;
        const string Appname = "ZYZ";


        public void PrintConstantsValues()
        {
            Console.WriteLine(name);
            Console.WriteLine($"the value of pi is :{pi}");

            name = "TestNew";
            Console.WriteLine(name);

        }
    }
}
