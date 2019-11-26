using System;

namespace ConsoleApp9
{
    class Hashtable
    {
        static int maxSize; //Our table size
        int[] a; //Our table
        
        Hashtable(int Size)
        {
            maxSize = Size;
            a = new int[maxSize];
            for (int i = 0; i < maxSize; i++) //To make it Empty
            a[i] = -1;
        }
        
        Hashtable()
        {
            maxSize =100;
            a = new int[maxSize];
            for (int i = 0; i < maxSize; i++) //To make it Empty
            a[i] = -1;
        }
        
        public static int h(int key) //The key
        {
            return key % maxSize;
        }
        
        
        void add(int key, int vale)//If it is Empty
        {
            if (a[h(key)] == -1)
            a[h(key)] = vale;//Put it
            else //if not
            {       //use the ((linear))--probing-hashing technique
                int index = h(key);
                while (a[index] != -1 && index != key)
                index++;
                a[index] = vale;
            }
        }
        
        int Size()
        {
            return maxSize;
        }
        
        void print(int k)
        {
            if (a[h(k)] == -1)
            Console.WriteLine(k + "= null");
            else
            Console.WriteLine(k + " = " + a[h(k)]);
        }
        static void Main(string[] args)
        {
            Hashtable mtable = new Hashtable(10);
            Random rnd = new Random();
            
            for (int i = 0; i <10; i++)
            mtable.add(i,rnd.Next(1,100));
            
            for (int i = 0; i <mtable.Size(); i++)
            mtable.print(i);
            
            
            
            Console.ReadLine();
            
        }
    }
}
