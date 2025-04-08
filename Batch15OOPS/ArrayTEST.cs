using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class ArrayTEST
    {
        static void Main()
        //Assignment 2
        {
            int[] Numbers = { 50, 30, 80, 10, 40 };
            int maxvalue = Numbers.Max();
            int minvalue = Numbers.Min();
            Console.WriteLine("maxium value of array:" + maxvalue);
            Console.WriteLine("minium value of array:" + minvalue);


            //Assignment3
            string[] Names = { "Alice", "Bob", "Charlie", "David", "Emily" };
            Console.WriteLine("Names in list:Alice,Bob,Charlie,David,Emily");

            Console.WriteLine("Ram");
            string searchname = Console.ReadLine();
            if (Names.Contains(searchname))
            {
                Console.WriteLine(searchname + "found");
            }



        }
        


        



    }
    
}      