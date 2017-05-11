using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salesforce
{
    class Program
    {
        static void Main(string[] args)
        {
            bNode root = new bNode(3);


        }

        public class bNode
        {
            public int data;
            public bNode left;
            public bNode right;
            private int v;

            public bNode(int v)
            {
                this.v = v;
            }
        }

        public void preorder(bNode root)
        {
            if (root == null)
                return;
            Console.Write("{0}  ", root.data);
            preorder(root.left);
            preorder(root.right);
        }

        public void preorderIter(bNode root)
        {
            Stack<bNode> s = new Stack<bNode>();
            if (root==null)
            {
                return;
            }
            s.Push(root);
            while (s.Count>0)
            {
                var cur = s.Pop();
                Console.WriteLine(cur.data);
                if (cur.right!=null)
                {
                    s.Push(cur.right);

                }
                if (cur.left!=null)
                {
                    s.Push(cur.left);
                }
            }
        }

        //13.1
        //13.3
        public class version:IComparable<version>
        {
            public string ver;

            public int CompareTo(version other)
            {
                if (string.IsNullOrWhiteSpace(ver)|| string.IsNullOrWhiteSpace(other.ver))
                {
                    throw new InvalidOperationException();
                }
                string[] v1= ver.Split('.');
                string[] v2 = other.ver.Split('.');
                int i = 0;
                int j = 0;

                while(i<v1.Length && j<v2.Length)
                {
                    if (int.Parse(v1[i]) == int.Parse(v2[j]))
                    {
                        i++;
                        j++;
                    } 
                    else
                    {
                        return (int.Parse(v1[i]).CompareTo(int.Parse(v2[j])));
                    }
                }
                if (i==v1.Length)
                {
                    return 0.CompareTo(int.Parse(v2[j]));
                }
                else
                {
                    return int.Parse(v1[i]).CompareTo(0);
                }           


            }
        }
    }
}
