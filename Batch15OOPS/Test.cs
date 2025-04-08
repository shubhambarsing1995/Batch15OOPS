using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class Test
    {

        static void Main()
        //for switch statement

        { 
            Console.WriteLine("Food Menu");
            Console.WriteLine("Burger Rs. 49");
            Console.WriteLine("Pizza Rs. 100");
            Console.WriteLine("Salad Rs. 145");
            Console.WriteLine("Please Confirm order");
            Console.WriteLine("Bill");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("Food Menu");
                    break;
                case "2":
                    Console.WriteLine("Burger Rs.49");
                    break;
                case "3":
                    Console.WriteLine("Pizza Rs. 100");
                    break;
                case "4":
                    Console.WriteLine("Salad Rs. 145");
                    break;
                case "5":
                    Console.WriteLine("Confirm Order");
                    break;
                case "6":
                    Console.WriteLine("Bill");
                    break;

            }

            //for loop

            Console.WriteLine("using for loop");
                for (int  j = 1; j < 10; j++) 
            {
                Console.WriteLine($"checking student{ j }");
            }

            //while loop
            int i = 0;
            while (i < 10)
            {
                //core logic
                Console.WriteLine("checking student in while loop" + i);
                i++;

            }

            //do while loop
            int k = 0;
            do
            {
                Console.WriteLine("checking student in do while loop" + k);
                k++;
            }
            while (k < 10);

            //for each loop
            String[] Mobiles = { "Apple", "Nokia", "Realme", "Oppo", "Vivo", "Oneplus", "Motorola" };
            foreach (string mobile in Mobiles) 
            {
                Console.WriteLine("the Mobile is" + mobile) ;

            }


            //Break
            int sum = 0;
            while (true)
            {
                Console.WriteLine("entre a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if(num<0)
                {
                    break;
                }
                sum += num;
            }
            Console.WriteLine("sum of number:" +sum);
            Console.WriteLine("\t");

            //continue stateement

            for (i = 0; i < 20; i++)
            {
                if (i%3 == 0)
                {
                    continue;
                }

                Console.WriteLine("nuber divisible by 3:" + i);
            }

            //goto statement
            int age;
            Repeat:
            Console.Write("entre age between (0 to 120): ");
            age = Convert.ToInt32(Console.ReadLine());
            if(age>120)
            {
                Console.WriteLine("please entre valid age between 0 to 120");
                goto Repeat;

            }
            Console.WriteLine("your age is :" + age);




        }


    }


}
