using System;

namespace QueueImplemen
{
    class Queue
    {
        static int top;
        int Max_Siz;
        
        int[] Queue_Array;
        
        Queue(int Max_Siz)
        {
            this.Max_Siz = Max_Siz;
            Queue_Array = new int[this.Max_Siz];
            top =-1;
        }
        
        Queue()
        {
            Max_Siz = 10000;
            Queue_Array = new int[Max_Siz];
            top =-1;
        }
        
        bool IsEmpty()
        {
            return (top < 0);
        }
        
        void Enqueue(int data)
        {
            if (top >= Max_Siz)
            {
                Console.WriteLine("Queue Overflow !!");
            }
            else
            {
                top++;
                Queue_Array[top] = data;
            }
        }
        void Dequeue()
        {
            if (top < 0)
            Console.WriteLine("[ Null ]");
            else
            top--;
        }
        
        
        int peek()
        {
            return Queue_Array[0];
        }
        
        void Clear()
        {
            top = -1;
        }
        
        void println()
        {
            if (top < 0)
            Console.WriteLine("Null");
            else
            {
                Console.WriteLine("Items in the Queue are ");
                for (int i = 0; i<=top;++i)
                {
                    Console.WriteLine(Queue_Array[i]);
                }
            }
            
            Console.WriteLine("\n                                  Ali_Rashad</>");
            
        }
        
        void print()
        {
            if (top < 0)
            Console.WriteLine(" Null ");
            else
            {
                for (int i = 0; i<=top; i++)
                {
                    if (i == 0)
                    Console.Write("[" + Queue_Array[i]);
                    else if (i == top)
                    Console.Write("," + Queue_Array[i] + "]");
                    else
                    Console.Write("," + Queue_Array[i]);
                    
                }
                
            }
            
            Console.WriteLine("\n                                  Ali_Rashad</>");
            
        }
        
        
        public static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(0);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(-1);
            queue.Dequeue();
            
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine("The Head of Queue is: "+queue.peek());
            queue.println();
            
        }
    }
}
