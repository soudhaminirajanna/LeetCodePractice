using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class stackUsingArrays
    {
        int[] stack;
        int top;

        public   stackUsingArrays()
        {
            stack= new int[10];
            top = -1;

        }

        public void push(int data)
        {
            if (top==9)
            { Console.WriteLine("stack full");
            }
            stack[++top] = data;


        }
        public int pop()
        {
            if(top<0)
            {
                Console.WriteLine("stack empty");

            }
            return stack[top--];
        }

    }
}
