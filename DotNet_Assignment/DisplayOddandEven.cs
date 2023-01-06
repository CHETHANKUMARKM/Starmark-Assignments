using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class DisplayOddandEven
    {
        static void Main(string[] args)
        {
             void Check()
            {
                Console.WriteLine("Enter the total number ");
                int total = Convert.ToInt32(Console.ReadLine()) ;

                int[] numbers = new int[total];
                Console.WriteLine("Enter the "+total+" number ");
                for (int i=0;i<numbers.Length;i++)
                {
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                //Console.WriteLine( "numbers");

                for(int j=0;j<numbers.Length;j++)
                {
                    if(numbers[j]%2==0)
                    {
                        Console.WriteLine("The "+numbers[j]+"is EvenNumber");
                    }
                    else
                    {
                        Console.WriteLine("The " + numbers[j] + "is oddNumber");
                    }
                    
                }
          
            }
            Check();
           
        }
    }
}
