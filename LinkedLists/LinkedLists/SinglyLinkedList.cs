using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class SinglyLinkedList
    {

        public Node head;
        public Node current;
        public int count;
        public SinglyLinkedList()
        {
            head = new Node();
            current = head;
        }
        public void AddAtLast(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            current.Next = newNode;
            current = newNode;
            count++;
        }

        public void RemoveDups()
        {
            Node start = head;
            Node curr = start;
            int count = 1;
            Node prev = null;
            while(curr.Next!=null)
            {

                curr = curr.Next;
                if (curr.data != start.data)
                {
                    if (count == 1)
                    {
                        prev = start;
                        start = curr;
                    }
                    else
                    {
                        if (prev == null)
                        {
                            head = curr;
                        }
                        else
                        { prev.Next = curr; }
                        count = 1;
                    }
                }
                else
                    count++;
            }

            if(count!=1)
            {
                prev.Next = null;
            }
        }

        internal void reverse()
        {
            Node prev =null;
            Node curr = head.Next;
            Node next = head.Next.Next;
            while (curr.Next!=null)
            {
                curr.Next = prev;
                prev = curr;
                curr = next;
                next = curr.Next;
                
            }
            curr.Next = prev;
            head.Next = curr;
           
        }
       
        public void AddAtFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.Next = head.Next;
            head.Next = newNode;
            count++;
        }

        public object RemoveFromStart()
        {
            if (head.Next == null)
                return null;
            Object ret = head.Next.data;
            head.Next = head.Next.Next;
            return ret;
        }

        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr.Next != null)
            {
                curr = curr.Next;
                Console.Write(curr.data);
                Console.Write("->");
            }
            Console.Write("NULL");
        }
    }
    public class Node
    {
        public int data;
        public Node Next;
    }
}
