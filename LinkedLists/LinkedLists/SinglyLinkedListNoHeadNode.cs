using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class SinglyLinkedListNoHeadNode
    {

        public Node head;
        public Node current;
        public int count;
        public SinglyLinkedListNoHeadNode()
        {
            head = null;
            current = head;
            count = 0;
        }
        public void AddAtLast(int data)
        {

            Node newNode = new Node();
            newNode.data = data;
            if(current!=null)
            {
                current.Next = newNode;
                
            }
            else
            {
                head = newNode;
                
            }
            current = newNode;
            count++;

        }
        public void InsertAtPosition(int data, int position)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (position <= 0)
            {
                Console.WriteLine("invalid position ");

            }

            if (position == 1)
            {
                newNode.Next = head;
                head = newNode;
                return;
            }
            Node curr=head;
            var pos = 1;
            while (pos != position-1 && curr.Next!=null)
            {
                pos++;
                curr = curr.Next;
            }
            if(pos!=position-1)
            {
                Console.WriteLine("invalid position");
                return;
            }
            newNode.Next = curr.Next;
            curr.Next = newNode;

        }

        public void partition(int val)
        {
            Node lower = null;
            Node loweend = null;
            Node higher = null;
            Node higherend = null;

            Node cur = head;
            while(cur!=null)
            {
                
                if (cur.data<val)
                {
                    if (loweend!=null)
                    {
                        loweend.Next = cur;
                    }
                    else
                    {
                        lower = cur;
                    }
                    loweend = cur;
                }
                else 
                {
                    if (higherend != null)
                    {
                        higherend.Next = cur;
                    }
                    else
                    {
                        higher = cur;
                    }
                    higherend = cur;
                }
                cur = cur.Next;
            }

            higherend.Next = null;
            loweend.Next = higher;
            head = lower;


        }

        public void removenth(int k)
        {
            Node curr = head;
            Node toDel = head;
            Node p = null;
            
            while (k>1)
            {
                curr = curr.Next;
                k--;
            }
            while (curr.Next!=null)
            {
                p = toDel;
                curr = curr.Next;
                toDel = toDel.Next;
            }
            if (p==null)
            {
                head = head.Next;

            }
            else
            {
                p.Next = toDel.Next;
            }
        }

        internal void specialSort()
        {
            if (head == null)
                return;
            Node headInc = head;
            Node headDec;
            if (head.Next==null)
            {
                return;
            }
            else
            {
                headDec = head.Next;
            }
            Node currInc = headInc;
            Node currDec=headDec;
            while (currInc.Next!=null && currInc.Next.Next!=null)
            {
                currInc.Next = currInc.Next.Next;
                currInc = currInc.Next;
            }
            while (currDec.Next != null && currDec.Next.Next != null)
            {
                currDec.Next = currDec.Next.Next;
                currDec = currDec.Next;
            }

            Node headDecInc = reverse(head);

            head = merge(headInc, headDecInc);

        }

        private Node merge(Node head1, Node head2)
        {
            Node newhead = null;
            Node curr = null;
            if (head1 == null && head2 == null)
                return null;
            if (head1 == null)
                return head2;
            if (head2 == null)
                return head1;

            Node curr1 = head1;
            Node curr2 = head2;
            while(curr1.Next!=null && curr2.Next!=null)
            {
                Node nodeToAdd = null;
                if (curr1.data <curr2.data)
                {
                    nodeToAdd = curr1;
                    curr1 = curr1.Next;
                }
                else
                {
                    nodeToAdd = curr2;
                    curr2 = curr2.Next;
                }

                if (newhead==null)
                {
                    newhead = nodeToAdd;
                    curr = newhead;
                }
                curr.Next = nodeToAdd;
                nodeToAdd.Next = null;
                curr = curr.Next;
            }
            
            if (curr1.Next!=null)
            {
                curr.Next = curr1;
            }
            if (curr2.Next != null)
            {
                curr.Next = curr2;
            }

            return newhead;




        }



        private Node reverse(Node header)
        {
            if (header == null)
                return null;
            if (header.Next==null)
            {
                return header;
            }
            Node first = header;
            Node second = header.Next;

            second = reverse(second);
            Node iter = second;
            while(iter.Next!=null)
            { iter = iter.Next; }

            iter.Next = first;
            first.Next = null;

            return second;

        }

        public Node reveseGrps(Node head, int k)
        {
            int x = k;
            Node nextNode = null;
            Node currNode = head;
            Node prevNode = null;
            while (currNode != null && x > 0)
            {
                nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
                x--;
            }
            if (nextNode != null)
            {
                head.Next = reveseGrps(nextNode, k);
            }
            return prevNode;
        }

        public void reverseInBlocks()
        {
            //reverseInBlocks(head,null,head,3);
            head = reveseGrps(head, 3);
        }
        public void reverseInBlocks(Node head,Node prev, Node swaphead,int k)
        {
           
            if (swaphead != null)
            {
                
                Node curr = swaphead;
                Node next = swaphead.Next;
                count = 1;
                while (curr.Next != null && count<=k)
                {
                    count++;
                    curr.Next = prev;
                    prev = curr;
                    curr = next;
                    next = curr.Next;

                }
                swaphead.Next = curr;
                if (swaphead==head)
                {
                    head = prev;
                }
                prev = curr;
                curr = curr.Next;
                
                reverseInBlocks(head, prev,curr,k);


            }
        }

        void reverse1()
        {
            Node newhead = null;
            Node curr = head;
            while (curr.Next!=null)
            {
                Node temp = curr;
                curr = curr.Next;
                temp.Next = newhead;
                newhead = temp;
            }
            curr.Next = newhead;
            head = newhead;
        }
        internal void reverse()
        {
            if (head != null)
            {
                Node prev = null;
                Node curr = head;
                Node next = head.Next;
                while (curr.Next != null)
                {
                    curr.Next = prev;
                    prev = curr;
                    curr = next;
                    next = curr.Next;

                }
                curr.Next = prev;
                head = curr;
            }
        }

        public void AddAtFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (current!=null)
            {
                newNode.Next = head;
                head = newNode;
                count++;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
                count++;
                current = newNode;
            }
            
        }

        public object RemoveFromStart()
        {
            if (head == null)
                return null;
            Object ret = head.data;
            head = head.Next;
            return ret;
        }

        public void PrintAllNodes()
        {
            //Traverse from head
            Console.Write("Head ->");
            Node curr = head;
            while (curr!=null)
            {
                Console.Write(curr.data);
                curr = curr.Next;
                Console.Write("->");
            }
            Console.Write("NULL");
        }
        public void RemoveDups()
        {
            Node start = head;
            Node curr = start;
            int count = 1;
            Node prev = null;
            while (curr.Next != null)
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
                        start = curr;
                        count = 1;
                    }
                }
                else
                    count++;
            }

            if (count != 1)
            {
                prev.Next = null;
            }
        }
    }
   
}
