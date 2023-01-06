using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Prime
    {
        public static void CheckFunc()
        {
            int number = Utilities.GetNumber("Enter the number");
            if (number==1||number==0)
            {
                Console.WriteLine($"The {number} is not prime");
            }
            int count = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                    Console.WriteLine($"The {number} is not prime");
                }

            }
            if (count == 0)
            {

                Console.WriteLine($"The {number} is  prime");
            }
            else
            {

                Console.WriteLine($"The {number} is not prime");
            }

        }
    }
    class CheckPrime
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Prime.CheckFunc();
            }
        }
    }
}
