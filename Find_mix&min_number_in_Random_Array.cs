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
          int count=10;
            int[] numbers = new int[count];
            Random rnd = new Random();
            int min, max;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(1, 100);
                Console.Write(numbers[i] + "|");
            }

            min = numbers[0];
            max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                min = numbers[i];
                if (max < numbers[i])
                max = numbers[i];
            }
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine("The highest number in the array: > > > " + max);
            Console.WriteLine("The lowest number in the array: > > > " + min);
            Console.ReadKey();
        }
    }
}
