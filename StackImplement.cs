using System;

namespace StackImplemen
{
    class Stack
    {
        static int top;
        int Max_Siz;
        
        int[] Stack_Array;
        
        Stack(int Max_Siz)
        {
            this.Max_Siz = Max_Siz;
            Stack_Array = new int[this.Max_Siz];
            top = -1;
        }
        
        Stack()
        {
            Max_Siz = 10000;
            Stack_Array = new int[Max_Siz];
            top = -1;
        }
        
        bool IsEmpty()
        {
            return (top < 0);
        }
        
        void push(int data)
        {
            if (top >= Max_Siz)
            {
                Console.WriteLine("Stack Overflow !!");
            }
            else {
                top++;
                Stack_Array[top] = data;
            }
        }
        void pop()
        {
            if (top < 0)
            Console.WriteLine("[ Null ]");
            else
            top--;
        }
        
        
        int peek() {
            return Stack_Array[top];
        }
        
        void println()
        {
            if (top < 0)
            Console.WriteLine("Null");
            else
            {
                Console.WriteLine("Items in the Stack are ");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(Stack_Array[i]);
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
                for (int i = top; i >= 0; i--)
                {
                    if(i == top)
                    Console.Write("[" + Stack_Array[i]);
                    else if (i == 0)
                    Console.Write(","+Stack_Array[i] + "]");
                    else
                    Console.Write("," + Stack_Array[i]);
                    
                }
                
            }
            
            Console.WriteLine("\n                                  Ali_Rashad</>");
            
        }
        
        
        public static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            stack.pop();
            stack.push(-1);
            stack.push(0);
            stack.pop();
            
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.peek());
            stack.print();
            
        }
    }
}

