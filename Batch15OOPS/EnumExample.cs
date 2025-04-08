using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class EnumExample
    {
        //Syntax of enum
        enum Days
        {
            //Enum Implementations
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thrusday,
            Friday,
            Saturday

        }

        enum Httpstatuscode
        {
            OK = 200,
            Badrequest = 400,
            unathoriesd = 500,
        }
        static void Main()
            
        {

            Days today = Days.Monday;
            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case Days.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                case Days.Thrusday:
                    Console.WriteLine("Today is Thrusday");
                    break;
                case Days.Friday:

                    //Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Today is Friday");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Today is Saturday");
                    break;

            }

            if (today == Days.Sunday || today == Days.Saturday)
            {
                Console.WriteLine("Its Weekend");
            }
            else
            {
                Console.WriteLine("Its Weekday");
            }

            Httpstatuscode code = Httpstatuscode.OK;
            Console.WriteLine("HTTP Status code:" + code);

            int codenumber = (int)code;
            Console.WriteLine("HTTP Status code number:" + codenumber);
        }

//
      
            }


        }

  

