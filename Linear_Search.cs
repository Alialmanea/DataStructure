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
                return i+1;
            }
            
            return -1;
        }
        
        
        public static void Main(string[] args)
        {
            int[] artest = {1,2,0,-1,0,10,5};
            
            
            Console.WriteLine("Index_number : "+Linear_Search(0,artest));
        }
    }
}

