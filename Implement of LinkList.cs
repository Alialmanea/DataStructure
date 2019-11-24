using System;

namespace ImplementOfLinlList
{
    public class Node //Structure of (Node)
    {
        public int data; //[data[Next]]==>[data[Next]]
        public Node Next;

        public Node(int i)//[i[Next]]
        {
            data = i;
            Next = null;
        }

        public void Add(int data)//Add to End 
        {
            if (Next == null)//if it is Empty!
                Next = new Node(data);
            else
                Next.Add(data);//recursive 

        }

        public void print()// TO Show what is going there
        {
            Console.Write("|" + data + "|==>");
            if (Next != null)
                Next.print();
        }
    }

    public class LinkList
    {
        public Node HeadNode;

        public LinkList()
        {
            HeadNode = null;
        }

        public void AddLast(int data)
        {
            if (HeadNode == null)
                HeadNode = new Node(data);
            else
                HeadNode.Add(data);
        }

        public void AddFirst(int data)
        {
            if (HeadNode == null)
                HeadNode = new Node(data);
            else
            {
                Node swap = new Node(data);
                swap.Next = HeadNode;
                HeadNode = swap;
            }
        }

        public void Addsorted(int data)
        {
            if (HeadNode == null)
                HeadNode = new Node(data);
            else if (data < HeadNode.data)
            {
                Node swap = new Node(data);
                swap.Next = HeadNode;
                HeadNode = swap;
            }

        }


        public void print()// TO show what is going
        {
            if (HeadNode != null)
                HeadNode.print();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            /*Node mynode = new Node(7); //make node with value 7
            mynode.Next = new Node(8); //fill the next node  with vlaue 8
            mynode.Next.Next = new Node(45);
            mynode.Add(5);// fill it with using methode
            mynode.Add(20);*/

            LinkList linklist = new LinkList();

            linklist.AddLast(1);
            linklist.AddLast(2);
            linklist.AddLast(3);
            linklist.AddFirst(4);
            linklist.AddFirst(0);
            linklist.AddLast(5);
            linklist.AddLast(8);
            linklist.Addsorted(-1);
            linklist.print();// print it all

            Console.ReadLine();

        }
    }
}