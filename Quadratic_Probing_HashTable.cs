using System;


namespace Hashtable
{
    class Hashtable
    {
        
        public int maxSize; //our table size
        int[] table;
        
        public Hashtable()
        {
            maxSize = 1000;
            table = new int[maxSize];
            
            for (int i = 0; i < maxSize; i++)
            {
                table[i] = -1;
            }
        }
        
        public Hashtable(int size)
        {
            maxSize =size;
            table = new int[maxSize];
            
            for (int i = 0; i < maxSize; i++)
            {
                table[i] = -1;
            }
        }
        
        public static int h(int key)
        {
            return key % 100;
        }
        
        
        
        
        
        public void add(int key, int vale)
        {
            if (table[h(key)] == -1)
            table[h(key)] = vale;
            else
            {
                int index = h(key);
                int i = 0;
                
                while (table[index] != -1 && index != key)
                {
                    i++;
                    index = (index + i * i) % 100;
                    
                }
                
                if (table[index] == -1)
                {
                    table[index] = vale;
                }
                
                
            }
            
        }
        
        int Size()
        {
            return maxSize;
        }
        
        
        void print(int k)
        {
            
            if (table[h(k)] == -1)
            Console.WriteLine(k + " = null ");
            else
            Console.WriteLine(k + " = " + table[h(k)]);
            
        }
        
        
        static void Main(string[] args)
        {
            Hashtable mtable = new Hashtable(100);
            
            Random rnd = new Random();
            
            
            for (int i = 0; i < mtable.Size(); i++)
            mtable.add(rnd.Next(0, 100),rnd.Next(500, 10000));
            
            
            
            for (int i = 0; i <=mtable.Size(); i++)
            
            mtable.print(i);
            
            
            
            
            
            Console.ReadLine();
            
        }
    }
}


