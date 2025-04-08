using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class Stringbuilder
    {
        static void Main()
        {
            //String
            string str = "Hello World";
            Console.WriteLine(str);

            str = "Test";
            Console.WriteLine(str);

            string firstname = "Shubham";
            string lastname = "Barsing";


            string fullname = firstname + lastname;
            Console.WriteLine(fullname);

            //String Builder Implementation

            StringBuilder SB = new StringBuilder();
            SB.Append("My Name ");
            SB.Append("Is ");
            SB.Append("Shubham");
            SB.Append("Barsing");
            Console.WriteLine(SB.ToString());


            //remove value to string builder in specific index
           // SB.Remove(8, 3);
            Console.WriteLine(SB.ToString());

            //Insert value in specific index
            SB.Insert(11, "Mr");
            Console.WriteLine(SB.ToString());

            //replace value in specific index
            SB.Replace("Shubham", "Anurag");
            Console.WriteLine(SB.ToString());


            //boxing-converting value type to object
            int x = 10;
            object Y = x;

            //unboxing-converting object to value
            object o = 10;
            int i = (int)o;




            StringBuilder GS = new StringBuilder();
            GS.Append(" The Ajay ");
            GS.Append("Is Best Dancer ");
            GS.Append(" Than Rahul ");
            GS.Append("In Whole class ");
            Console.WriteLine(GS.ToString());


            GS.Replace("Rahul", "Geeta");
            Console.WriteLine(GS.ToString());

            GS.Remove(24, 12);
            Console.WriteLine(GS.ToString());







        }


    }
}
