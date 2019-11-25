using System;

namespace data_structure
{
    class MainClass
    {
        
        private static int Linear_Search(int x,int[]ar)
        {
            if (ar.Length == 1)
            return 1;
            else if (ar.Length != 1)
            {
                for (int i = 0; i < ar.Length; i++)
                if (ar[i] == x)
                return i;
            }
            
            return -1;
        }
        
        
        private static int Binary_Search(int x, int[] ar)
        {
            int Start, End, mid;
            
            Start = 0;
            End = ar.Length-1;
            
            while (Start <= End)
            {
                mid = (Start + End) / 2;
                
                if (x == ar[mid])
                return mid;
                else if (x < ar[mid])
                End = mid - 1;
                else if (x > ar[mid])
                Start = mid + 1;
            }
            
            return -1;
        }
        
        public static void Main(string[] args)
        {
            int[] artest = {1,2,3,4,5,6,7};
            
            
            Console.WriteLine("Index_number : "+Binary_Search(6,artest));
        }
    }
}
