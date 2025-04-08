using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch15OOPS
{
    class Arrays
    {  
        static void Main()
        {
            //Declare the Arrays
            string[] Mobiles = new string[4];

            //assigning values in arrays
            //first approach
            Mobiles[0] = "Apple";
            Mobiles[1] = "Samsung";
            Mobiles[2] = "oneplus";
            Mobiles[3] = "Nokia";

            //
            string[] Mobile = { "Apple", "Samsung", "oneplus", "Nokia" };

            //Accesing values from array
            for(int i=0; i < Mobiles.Length; i++)
            {

                Console.WriteLine("Mobile Names:" + Mobiles[i]);
            }

            //initilise multidimential array
            int[,] matrix = new int[,]    //int number
            {
                {1,2,3, },
                {4,5,6, },
                {7,8,9, },
            };
            //accessing values from multidimential array
            Console.WriteLine("Element at (0,0):" + matrix[0, 1]); //2
            Console.WriteLine("Element at (1,2):" + matrix[1, 2]); //6



            //print all the elements from multidimential array
            for (int i = 0; i < 3; i++)
            {
                for (int j=0; j<3; j++)
                {
                    Console.Write(matrix[i, j] + ",");

                }
                Console.WriteLine();


            }

            //sum of values of array
            int[] Numbers = new int [4];

            //assigning values in arrays
            //first approach
            Numbers[0] =5;
            Numbers[1] = 15;
            Numbers[2] = 13;
            Numbers[3] = 32;
            int sum = 0;
            for(int i=0; i < Numbers.Length; i++)
            {
                sum += Numbers[i];
              
            }
            Console.WriteLine("The sum of values of array is" + sum);



            //Average values of array
            int[] numbers = { 4,71,77,56,99,35};
            int Sum = 0;
            double average; 
            for (int i=0;i<numbers.Length;i++)
            {
                sum += numbers[i];

            }
            average = (double)Sum / numbers.Length;
            Console.WriteLine("The average values of array is" + average);



        }

    }
}
