using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Claculator
    {
        static void Main()
        {
            string condition = "";
             while(true)
            {
                if(condition == "" || condition == "yes") { 
                Console.WriteLine("Enter the first number");
                int a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter symbol: +,-,*,/");
                int res;
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        res = a + b;
                        Console.WriteLine("Result : " + res);
                        break;
                    case "-":
                        res = a - b;
                        Console.WriteLine("Result : " + res);
                        break;
                    case "*":
                        res = a * b;
                        Console.WriteLine("Result : " + res);
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Divide by zero error");
                            break;
                        }
                        else
                        {
                            res = a / b;
                            Console.WriteLine("Result : " + res);
                            break;
                        }

                    case "default":
                        Console.WriteLine("Invalid Input");
                        break;
                }
                    Console.WriteLine("want to Continuee yes or no");
                   condition = Console.ReadLine();
                    
                }
            }
        }


        
    }
}
