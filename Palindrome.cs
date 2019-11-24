using System;

namespace Palindrome
{
    class MainClass
    {
        public static bool IsPalindrome(string value)
        {
            int i = 0;
            int j = value.Length - 1;
            while (true)
            {
                if (i > j)
                {
                    return true;
                }
                char a = value[i];
                char b = value[j];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                i++;
                j--;
            }
        }
        public static void Main(string[] args)
        {
            string[] array =
            {
                "civic",
                "deified",
                "deleveled",
                "devoved",
                "dewed",
                "Hannah",
                "kayak",
                "level",
                "madam",
                "racecar",
                "radar",
                "redder",
                "refer",
                "repaper",
                "reviver",
                "rotator",
                "rotor",
                "sagas",
                "solos",
                "sexes",
                "stats",
                "tenet",
                
                "Dot",
                "Net",
                "Perls",
                "Is",
                "Not",
                "A",
                "Palindrome",
                "yatay"
            };
            
            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }
            
            
        }
    }
}

