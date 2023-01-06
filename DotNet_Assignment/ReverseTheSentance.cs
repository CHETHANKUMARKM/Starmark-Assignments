using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class ReverseTheSentance
    {
        public static void Reverse()
        {
            string sentance = Utilities.Prompt("Enter the Sentance");
            string[] temp = sentance.Split(' ');
         
            Console.WriteLine(temp.Length);
            string newString = "";
            
            for(int i=temp.Length-1; i>-1;i--)
            {
              
                newString = string.Concat(newString," "+ temp[i]);              
               
            }
            Console.WriteLine(newString);
        }
        static void Main(string[] args)
        {
            Reverse();
         
        }

    }
}
