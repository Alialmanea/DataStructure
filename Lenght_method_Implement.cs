using System;

namespace Palindrome
{
    class MainClass
    {
        public static int Length(string str)
        {
            str  = str +'\0';
            int count = 0;
            for (int i = 0;!str[i].Equals('\0');i++)
            {
                count++;
            }
            
            return count;
        }
        public static void Main(string[] args)
        {
            
            string ad = "Ali Rashad</>";
            
            Console.WriteLine(Length(ad));
            
     }
   }
}
