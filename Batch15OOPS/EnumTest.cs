using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class EnumTest
    {
        enum Months
        {
            //Enum Implementations
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            Octomber,
            November,
            December

        }
        static void Main()
        {
            Months monthname = Months.January;
            switch (monthname)
            {
                case Months.January:
                    Console.WriteLine("Starting Month of year ");
                    break;
                case Months.December:
                    Console.WriteLine("Last Month Of Year");
                    break;
                case Months.February:
                    Console.WriteLine("Second Month Of Year");
                    break;
                case Months.March:
                    Console.WriteLine("Third Month Of Year");
                    break;
                case Months.April:
                    Console.WriteLine("Fourth Month Of Year");
                    break;
                case Months.May:
                    Console.WriteLine("Fifth Month Of Year");
                    break;
                case Months.June:
                    Console.WriteLine("Sixth Month Of Year");
                    break;
                case Months.July:
                    Console.WriteLine("Seventh Month Of Year");
                    break;
                case Months.August:
                    Console.WriteLine("Eighth Month Of Year");
                    break;
                case Months.September:
                    Console.WriteLine("Nineth Month Of Year");
                    break;
                case Months.Octomber:
                    Console.WriteLine("Tenth Month Of Year");
                    break;
                case Months.November:
                    Console.WriteLine("Eleventh Month Of Year");
                    break;

            }
        }
    }
}
