using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    public class PublicExampleTest
    {
        //define property
        public int PublicProperty { get; set; }

        //method
        //[access-modifier][return_type][method_name]
        public void Display()
        {
            Console.WriteLine("Public Property Value:" + PublicProperty);
        }

        public void show()
        {
            Console.WriteLine("Hello");
        }

        public class PublicExample
        {
            static void Main()
            {
                PublicExampleTest obj = new PublicExampleTest();

                obj.PublicProperty = 1;
                obj.Display();
                obj.show();
            }
        }

        //class assignment
        






    }
}
