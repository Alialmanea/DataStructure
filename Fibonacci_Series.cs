using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, add=0, i=1, j=0;
            
            
            Console.Write("Enter The Max of your Fibonacci Series :  ");
            max = Convert.ToInt32(Console.ReadLine());
            
            Console.Write(add); //0,
            
            while (add <=max) //
            {
                add = i + j;
                Console.Write(","+ add);//0,1,1,2,3,5,.....
                
                i = j;
                j = add;
                
            }
            
            
            Console.ReadLine(); //Keep the console window open in debug mode.
        }
    }
}

