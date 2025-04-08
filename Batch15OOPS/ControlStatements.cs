using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class ControlStatements
    {

        static void Main()
        {
            //IF  statement
            int Number = 11;
            if (Number == 10)
            {
                Console.WriteLine("This number is positive");
            }

            //IF else statement
            string Username = "Shubham";
            if (Username == "Shubham")
            {
                Console.WriteLine("This is Active user");
            }
            else
            {
                Console.WriteLine("This is Invalid user");
            }


            //if else if statement
            int Numbernew = 10;
            if (Numbernew > 0)
            {
                Console.WriteLine("The Number is positive");
            }
            else if (Number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else if (Numbernew > 100 && Numbernew < 200)
            {
                Console.WriteLine("The Number is positive");
            }
            else
            {
                Console.WriteLine("the number is zero");
            }

            //SWITCH
            int Day = 6;
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Weekend");
                    break;


            }



            //Looping Statememnt

            //For loop

            int n = 5; //variable declaration
                       //1)variable initilize 2)iteration condition 3)iteration increment/decrement
            for (n = 0; n < 5; n++) //n
            {
                Console.WriteLine("Iterration:" + n);

            }


            //while loop--entry controlloop

            int i = 0;
            while (i < 5)
            {
                //core logic
                Console.WriteLine("iteration in while loop" + i);
                i++;

            }


            //do while loop--exit control loop

            int j = 0;
            do
            {
                Console.WriteLine("Iteration in do while loop" + j);
                j++;

            } while (j < 5);

            //for each statement
            string[] Fruits = { "Apple", "Mango", "Banana", "Orange", "Watermelon", "Grapes" };
            foreach (string fruit in Fruits)
            {
                Console.WriteLine("the Fruit is" + fruit);
            }

            //Jumping statement

            /// continue

            for (i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                Console.WriteLine("iteration:" + i);

            }

            //go to ssatement

            int count = 0;
        startloop:
            if (count < 5)
            {
                Console.WriteLine($"count is {count}");
                count++;
                goto startloop;
                Console.WriteLine($"count after goto is {count}");
            }
            Console.WriteLine($"loop with goto is finished");



          
        }

    }
}
