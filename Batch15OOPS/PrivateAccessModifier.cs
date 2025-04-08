using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class PrivateAccessModifier
    {


        class Person1
        {
            private string first_name;
            private string last_name;

            public Person1(string firstname, string lastname)
            {
                first_name = firstname;
                last_name = lastname;
            }

            public void displayfullname()
            {
                Console.WriteLine($"full name is :{first_name}{last_name}");
            }
        }
        
        static void main(string[] args)
        {
            Person1 P = new Person1("shubham", "Barsing");
            P.displayfullname();

        }
    }
}
