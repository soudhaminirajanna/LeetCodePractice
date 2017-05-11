using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAndTree
{
    
    public class BNode
    {
        public int data;
        public BNode left;
        public BNode right;
    }
    class Node
    {
        int data;
        List<Node> children;
    }
    class Tree
    {
        Node root;

    }
    class Edge
    {
        public int fromV;
        public int toV;
        public Edge(int s, int d)
        {
            fromV = s;
            toV = d;
        }
    }

    class BTree
    {
        Node root;
            
    }
    class Graph
    {
        public int v;
        public Dictionary<int, List<int>> adjList;
        public Graph(int numberOfVertices,List<Edge> edges)
        {
            v = numberOfVertices;
            adjList = new Dictionary<int, List<int>>();
            for(int i=0; i< numberOfVertices; i++)
            {
                adjList.Add(i, new List<int>());
            }
            foreach (Edge e in edges)
            {
                adjList[e.fromV].Add(e.toV);
                adjList[e.toV].Add(e.fromV);
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //breathFirstSearchGraph();
            //depthFirstSearch();
            //binarySearchTree();//insert, delete and search in bst
            //prefixInfixToTree();
            //pathsum();
            //zigzagLevelOrder();
            //flattenBinaryTree();
            binaryTreetodll();
            Console.ReadLine();
        }

        private static void binaryTreetodll()
        {
           BNode root = new BNode();
            root.data = 5;
            BNode a = new BNode();
            a.data = 4;
            BNode b = new BNode();
            b.data = 8;
            BNode c = new BNode();
            c.data = 11;
            BNode d = new BNode();
            d.data = 13;
            BNode e = new BNode();
            e.data = 4;
            BNode f = new BNode();
            f.data = 7;
            BNode g = new BNode();
            g.data = 2;
            BNode h = new BNode();
            h.data = 5;
            BNode i = new BNode();
            i.data = 1;

            root.left = a;
            root.right = b;
            a.left = c;
            b.left = d;
            b.right = e;
            c.left = f;
            c.right = g;
            e.left = h;
            e.right = i;
            TreePrinter.Print(root);
            btol bto=treetodllHelper(root);
            var cur = bto.head;
            while (cur!=null)
            {
                Console.WriteLine(cur.data);
                cur = cur.right;
            }
            //TreePrinter.Print(bto.head);
        }

        public class btol
        {
            public BNode head;
            public BNode tail;

            public btol(BNode head, BNode tail)
            {
                this.head = head;
                this.tail = tail;
            }
        }

        private static btol treetodllHelper(BNode root)
        {
            if (root == null)
                return new btol(null, null);

                        btol l = treetodllHelper(root.left);
            btol r = treetodllHelper(root.right);
                      
            root.left = l.tail;
            if (l.tail!=null)
            {
                l.tail.right = root;
            }
            else
            {
                l.head = root;
            }

            root.right = r.head;
            if (r.head != null)
            {
                r.head.left = root;
            }
            else
            {
                r.tail = root;
            }
            return new btol(l.head, r.tail);

        }

        private static void flattenBinaryTree()
        {
            BNode root = new BNode();
            root.data = 5;
            BNode a = new BNode();
            a.data = 4;
            BNode b = new BNode();
            b.data = 8;
            BNode c = new BNode();
            c.data = 11;
            BNode d = new BNode();
            d.data = 13;
            BNode e = new BNode();
            e.data = 4;
            BNode f = new BNode();
            f.data = 7;
            BNode g = new BNode();
            g.data = 2;
            BNode h = new BNode();
            h.data = 5;
            BNode i = new BNode();
            i.data = 1;

            root.left = a;
            root.right = b;
            a.left = c;
            b.left = d;
            b.right = e;
            c.left = f;
            c.right = g;
            e.left = h;
            e.right = i;
            TreePrinter.Print(root);
            flattenHelper(root);
            TreePrinter.Print(root);
        }

        private static BNode flattenHelper(BNode root)
        {
            if (root==null)
            { return root; }

            BNode end = root;
            if (root.left!=null)
                end= flattenHelper(root.left);
            
            BNode temp = root.right;
            root.right = root.left;
            root.left = null;
            end.right = temp;

            if (temp!=null)
            {
                end= flattenHelper(temp);
            }
            return end;
        }

        private static void zigzagLevelOrder()
        {        
            BNode root = new BNode();
            root.data = 5;
            BNode a = new BNode();
            a.data = 4;
            BNode b = new BNode();
            b.data = 8;
            BNode c = new BNode();
            c.data = 11;
            BNode d = new BNode();
            d.data = 13;
            BNode e = new BNode();
            e.data = 4;
            BNode f = new BNode();
            f.data = 7;
            BNode g = new BNode();
            g.data = 2;
            BNode h = new BNode();
            h.data = 5;
            BNode i = new BNode();
            i.data = 1;

            root.left = a;
            root.right = b;
            a.left = c;
            b.left = d;
            b.right = e;
            c.left = f;
            c.right = g;
            e.left = h;
            e.right = i;

            
            TreePrinter.Print(root);

            Stack<BNode> q = new Stack<BNode>();
            Stack<BNode> s = new Stack<BNode>();
            List<List<int>> res = new List<List<int>>();
            q.Push(root);
            while(q.Count>0 || s.Count>0)
            {
                List<int> level = new List<int>();
                while(q.Count>0)
                {
                    var cur = q.Pop();
                    level.Add(cur.data);
                    if (cur.left!=null) s.Push(cur.left);
                    if (cur.right!=null) s.Push(cur.right);
                }
                res.Add(level);

                level = new List<int>();
                while(s.Count>0)
                {
                    var cur = s.Pop();
                    level.Add(cur.data);
                    if (cur.right != null) q.Push(cur.right);
                    if (cur.left != null) q.Push(cur.left);
                }
                res.Add(level);

            }


            foreach(var l in res)
            {
                foreach(var data in l)
                {
                    Console.Write("{0} ", data);
                }
                Console.WriteLine();
            }

           
        }

        private static void pathsum()
        {
            BNode root = new BNode();
            root.data = 5;
            BNode a = new BNode();
            a.data = 4;
            BNode b = new BNode();
            b.data = 8;
            BNode c = new BNode();
            c.data = 11;
            BNode d = new BNode();
            d.data = 13;
            BNode e = new BNode();
            e.data = 4;
            BNode f = new BNode();
            f.data = 7;
            BNode g = new BNode();
            g.data = 2;
            BNode h = new BNode();
            h.data = 5;
            BNode i = new BNode();
            i.data = 1;

            root.left = a;
            root.right = b;
            a.left = c;
            b.left = d;
            b.right = e;
            c.left = f;
            c.right = g;
            e.left = h;
            e.right = i;

            int targetSum = 22;
            TreePrinter.Print(root);
            pathsumhelper(root, 0, targetSum,new List<int>());
        }

        private static void pathsumhelper(BNode root, int sum, int targetSum,List<int> path)
        {
           
            if (root!=null)
            {
                sum = sum + root.data;
                path.Insert(path.Count,root.data);
            }
            if (root.right == null && root.right==null)
            {
                if (sum == targetSum)
                {
                    foreach(var node in path)
                    {
                        Console.Write("{0}->", node);
                    }
                    Console.WriteLine();
                }

            }
            if (root.left!=null)            pathsumhelper(root.left, sum, targetSum, path);
            if (root.right!=null)           pathsumhelper(root.right, sum, targetSum, path);

            path.RemoveAt(path.Count-1);
        }

        private static void prefixInfixToTree()
        {
            String prefix = "ABCDEFGH";
            string infix = "BDCAFEHG";
            BNode tree=prefixInfixToTreeHelper(prefix, infix, 0,prefix.Length-1, 0, infix.Length-1);
            TreePrinter.Print(tree);

        }

        private static BNode prefixInfixToTreeHelper(string prefix, string infix, int prefixStart,int preEnd,int infixstart, int infixend)
        {
            if (infixstart > infixend || prefixStart>preEnd)
            {
                return null;
            }
                                 
            BNode rtx = new BNode();
            rtx.data = prefix[prefixStart];
            int i = 0;
            for (i=0; i< infix.Length;i++)
            {
                if (prefix[prefixStart] == infix[i])
                    break;

            }

            rtx.left = prefixInfixToTreeHelper(prefix, infix, prefixStart+1,prefixStart+i-infixstart, infixstart,i-1);
            rtx.right = prefixInfixToTreeHelper(prefix, infix, prefixStart + i - infixstart+1, preEnd,i+1,infixend);

            return rtx;

        }



        //search a node in bst
        static BNode searchBST(BNode root, int data)
        {
            if (root==null)
            {
                return null;
            }
            if (root.data == data)
            {
                return root;
            }
            if (data<root.data)
            {
                return searchBST(root.left, data);
            }
            else
            {
                return searchBST(root.right, data);
            }
        }
        //delete a node from BST
        static BNode deleteBST(BNode root, int data)
        {
            if (root==null)
            { return null; }

            if (data<root.data)
            {
                root.left = deleteBST(root.left, data);
            }
            else if (data> root.data)
            {
                root.right = deleteBST(root.right, data);
            }
            else
            {
                if (root.left == null)
                    return root.right;
                if (root.right ==null)
                    return root.left;

                int keyMax = maxKey(root.left);
                root.data = keyMax;
                root.left = deleteBST(root.left, keyMax);
            }
            return root;

        }

        private static int maxKey(BNode root)
        {
            BNode cur = root;
            while (cur.right!=null)
            { cur = cur.right; }
            return cur.data;
        }

     static BNode mirrorBST(BNode root)
        {
            if (root == null)
                return null;
            if (root.right == null && root.left == null)
                return root;
            else
            {
                root.right = mirrorBST(root.right);
                root.left = mirrorBST(root.left);
                BNode temp = root.right;
                root.right = root.left;
                root.left = temp;
            }
            return root;
        }

        static  BNode insertBST(BNode root, int data)
        {
            
            if (root==null)
            {
                BNode n = new BNode();
                n.data = data;
                return n;
            }
            BNode curr = root;
            if (data<=curr.data )
            {
                curr.left = insertBST(curr.left, data);
            }
            else
            {
                curr.right = insertBST(curr.right, data);
            }

            return root;
        }

        private static void binarySearchTree()
        {
            BNode root= insertBST(null, 0);
            root = insertBST(root, 67);
            root = insertBST(root, 55);
            root = insertBST(root, 637);
            root = insertBST(root, 23);
            root = insertBST(root, 78);
            root = insertBST(root, 1);
            root = insertBST(root, 5);
            root = insertBST(root, 15);
            root = insertBST(root, 25);

            TreePrinter.Print(root);
            //root= deleteBST(root,5);
            //TreePrinter.Print(root);
            //root = mirrorBST(root);
            BNode ans = LeastCommonAns(root, 25, 15);
            TreePrinter.Print(root);
            BNode find = searchBST(root, 1);
        }

        private static BNode LeastCommonAns(BNode root, int v1, int v2)
        {
            BNode curr = root;
            if (curr.data > v1 && curr.data > v2 && curr.left != null)
            {
                return LeastCommonAns(curr.left, v1, v2);
            }
            else if (curr.data < v1 && curr.data < v2 && curr.right != null)
            {
                return LeastCommonAns(curr.right, v1, v2);
            }
            else if (curr.data == v1)
            {
                return searchBST(root, v1);
            }
            else if (curr.data == v2)
            {
                return searchBST(root, v2);
            }
            else return root;
        }

        private static void depthFirstSearch()
        {
            int number_of_vertices = 8;
            List<Edge> l = new List<Edge>();
            Edge a;
            a = new Edge(2, 6);
            l.Add(a);
            a = new Edge(1, 6); l.Add(a);
            a = new Edge(3, 7); l.Add(a);
            a = new Edge(7, 4); l.Add(a);
            a = new Edge(5, 6); l.Add(a);
            a = new Edge(6, 6); l.Add(a);
            a = new Edge(7, 6); l.Add(a);
            a = new Edge(5, 6); l.Add(a);
            a = new Edge(3, 6); l.Add(a);
            a = new Edge(0, 6); l.Add(a);

            Graph g = new Graph(number_of_vertices, l);

            bool[] visited = new bool[number_of_vertices];

            Stack<int> s = new Stack<int>();
            s.Push(0);
            while(s.Count>0)
            {
                int v = s.Pop();
                if (!visited[v])
                {
                    Console.WriteLine(v);
                    visited[v] = true;
                    foreach(int neighbor in g.adjList[v])
                    {
                        if (!visited[neighbor])
                        {
                            s.Push(neighbor);
                        }
                    }
                }
            }


        }

        private static void breathFirstSearchGraph()
        {

            int number_of_vertices = 8;
            List<Edge> l = new List<Edge>();
            Edge a;
            a = new Edge(2, 6);
            l.Add(a);
            a = new Edge(1, 6); l.Add(a);
            a = new Edge(3, 7); l.Add(a);
            a = new Edge(7, 4); l.Add(a);
            a = new Edge(5, 6); l.Add(a);
            a = new Edge(6, 6); l.Add(a);
            a = new Edge(7, 6); l.Add(a);
            a = new Edge(5, 6); l.Add(a);
            a = new Edge(3, 6); l.Add(a);
            a = new Edge(0, 6); l.Add(a);

            Graph g = new Graph(number_of_vertices, l);

            bool[] visited = new bool[number_of_vertices];
            Queue<int> q = new Queue<int>();

            q.Enqueue(0);
            while(q.Count>0)
            {
                int v = q.Dequeue();
                if (!visited[v])
                {
                    visited[v] = true;
                    Console.WriteLine(v);
                    foreach(int neighbor in g.adjList[v])
                    {
                        if (!visited[neighbor])
                        {
                            q.Enqueue(neighbor);
                        }
                    }
                }
            }



        }
    }
}


