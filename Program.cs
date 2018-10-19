using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToTheMax_
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraysize = GetNumbers("What size do you want your array? Must be larger than zero.");
            int[] arrayOfInt = new int[arraysize];


            for (int i = 0; i < arraysize; i++)
            {
                
                arrayOfInt[i] = int.Parse(getUsernumbers($"What number do you want in the {i+1} spot?"));
            }
            ///test array below
            int prev = 0;
            int max = 0;    
            foreach (var item in arrayOfInt)
            {
               if (item > prev)
                    {
                    max = item;
                                         
                    }
                    prev = item;
            }
            Console.WriteLine($"The highest number in this array is {max}.");
            
        }
        static int GetNumbers(string message)
        {
            int number;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out number) || number < 1)
            {
                Console.WriteLine($"Invalid! Try again! {message}");
            }
            return number;
        }
        static string getUsernumbers(string message)
        {
            int number;
            Console.Write(message);

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("That is not a number! " + message);
            }
            return number.ToString();
        }
    }
}
