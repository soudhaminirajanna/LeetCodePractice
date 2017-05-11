using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    //public interface Iterator<E>
    //{
    //    /** Returns true if the iteration has more elements. */
    //    bool hasNext();

    //    /** Returns the next element in the iteration. */
    //    E next();

    //    /** Removes from the underlying collection the last element returned by
    //        the iterator (optional operation). */
    //    void remove();
    //}
    //class myArray : Iterator<Object>
    //{
    //    int[] values;
    //    int iter = 0;

    //    public myArray(int[] input)
    //    {
    //        values = input;
    //        iter = 0;
    //    }
    //    public bool hasNext()
    //    {
    //        if (iter<values.Length-1)
    //        {
    //            int n = iter;
    //            while(values[iter] == values[n] && n< values.Length)
    //            {
    //                n++;
    //            }
    //            if (n<values.Length)
    //            {
    //                return true;
    //            }
    //        }
            
    //        return false;
            
    //    }

    //    public Object next()
    //    {
    //        if (iter < values.Length - 1)
    //        {
    //            int n = iter;
    //            while (values[iter] == values[n] && n < values.Length)
    //            {
    //                n++;
    //            }
    //            if (n < values.Length)
    //            {
    //                return values[n];
    //            }
    //        }

    //        throw new InvalidOperationException();
    //    }

    //    public void remove()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    class Program
    {


        static void Main(string[] args)
        {
            //linkedlist();
            //isSorted();
            //findBiggestBlock();
            //stackWithArray();
            //infixTopostfix();
            //numberOfLeaves();
            //matrixSize();
            //nextPermutation();
            //basicCalculator();
            //summaryRanges();
            //removeDuplicates();
            //wordbreak();
            //mergeIntervals();
            //jumpGame();
            //minimumSizeSubarraySum();
            //longestCoommomSubsequence();
            //helperpermute();
            //combinationsHelper();
            //middleofStack();
            //balancingBracket();
            //maximumContiguousSum();
            //commonElementsSortedArray();
            //checkBSTstub();
            //triPhoneBook();
            //SequenceReconstruction();
            //evaluateDivision();
            //minimumSizeSubarraySum();
            //miniParser();
            //kpairswithSmallestSum();
            //Sum3CLosest();
            //wordBoggle();
            //uniqueWrapAround();
            //palindromePartitioning();
            //combinationSum();
            //rectiangleArea();
            //minesweaper();
            //remoevNth();
            //remdupHelper();
            //triangle();
            // numberOfIsland();
            //pacificAtlanticFlow();
            //findsquareroot();
            //to be tested
            //sortInterleavedLinkedList();
            //countTrailingZeros();
            //phoneCombination();
            //HouseRobber();
            //subset2();
            //wiggleSubsequence();
            //nextRightBinaryTree();
            //longestSubstringwithRepeatingChar();
            //superUglyNumbers();
            //uglyNumbers();
            //SuperDuperuglyNumbers();
            //graphValidTree();
            //sortColors();
            //onesandZeros();
            //BinaryTreefromstring();
            //minimumSumPath();
            //roatateImage();
            //LongestIncreasingSubsequence();
            //levelorderBinaryTree();
            //spiralMatrix2();
            //maximumContiguousSummorethan2();
            //beautifulArray();
            //greatEscape();
            //mergeIntervalList();
            //contiguousSubarraySum();
            //maximizeStockProfit();
            //splitsentintowords();
            geneMutation();
            Console.ReadLine();
            




        }

        public class mutationNode
        {
            public String strain;
            public int transformCount;
           

            public mutationNode(string start, int transformCount)
            {
                this.strain = start;
                this.transformCount = transformCount;
            }
        }

        private static void geneMutation()
        {
            String start = "AAAAACCC";
            string end = "AACCCCCC";
            string[] bank = new string[] { "AAAACCCC", "AAACCCCC", "AACCCCCC" };

            HashSet<string> genebank = new HashSet<string>();
            for(int i=0; i<bank.Length; i++)
            {
                genebank.Add(bank[i]);
            }

            char[] actg = new char[] { 'A', 'C', 'T', 'G' };

            Queue<mutationNode> q = new Queue<mutationNode>();
            q.Enqueue(new mutationNode(start,0));
            while(q.Count!=0)
            {
                var cur = q.Dequeue();
                Console.WriteLine("Queueed"+cur.strain);
                for (int i=0; i<start.Length; i++)
                {
                    for(int j=0; j<4; j++)
                    {
                        if (actg[j]==cur.strain[i])
                        {
                            continue;
                        }
                        var newstrain = makeNewstrain(cur.strain, i, actg[j]);
                        Console.WriteLine(newstrain);
                        if (newstrain == end)
                        {
                            Console.WriteLine(cur.transformCount + 1);
                            return;
                        }

                        if (genebank.Contains(newstrain))
                        {
                            q.Enqueue(new mutationNode(newstrain, cur.transformCount + 1));
                        }
                    }
                }

            }
            
        }

        private static string makeNewstrain(string strain, int index, char switchGene)
        {
            //cur.strain.Substring(0, i) + actg[j].ToString() + cur.strain.Substring(i + 1);
            char[] a = strain.ToCharArray();
            a[index] = switchGene;
            return new string(a);

        }

        private static void splitsentintowords()
        {
            HashSet<String> dict = new HashSet<string>() { "cow", "jumped", "co", "over", "the", "he", "moon", "moo", "jump", "ed" };
            string given = "cowjumpedoverthemoon";
            bool possible = splitter(given, dict);
            Console.WriteLine(possible);
        }

        private static bool splitter(string given, HashSet<string> dict)
        {
            if (string.IsNullOrEmpty(given))
            {
                return true;
            }
            for(int i=1; i<=given.Length;i++)
            {
                string first = given.Substring(0, i);
                Console.WriteLine(first);
                if (dict.Contains(first))
                {
                    var second = given.Substring(i);
                    Console.WriteLine(first+"-"+second);
                    var isSent= splitter(second, dict);
                    if(isSent)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static void maximizeStockProfit()
        {
            int[] a = new int[] { 1, 3, 7, 5, 10, 3 };
            bool haveStock = false;
            int buy = 0;
            int profit = 0;
            for(int i=0; i<a.Length-1; i++)
            {
                if (a[i+1]>a[i] && !haveStock)
                {
                    buy = i;
                    haveStock = true;
                }
                else if (a[i+1] <a[i] && haveStock)
                {
                    profit = profit + (a[i] - a[buy]);
                    haveStock = false;
                }
            }
            if (haveStock)
            {
                profit = profit + (a[a.Length-1] - a[buy]);
                haveStock = false;
            }
            Console.WriteLine(profit);
        }

        private static void contiguousSubarraySum()
        {
            int[] a = new int[] { 0, 5, 2, -3 ,6};
            int target = 5;
            Dictionary<int, int> sumMap = new Dictionary<int, int>();
            sumMap.Add(0, 1);
            int sum = 0;
            int targetCount = 0;
            for(int i=0; i<a.Length;i++)
            {
                sum = sum + a[i];
                if(sumMap.ContainsKey(sum-target))
                {
                    targetCount = targetCount + sumMap[sum - target];
                }
                if (sumMap.ContainsKey(sum))
                {
                    sumMap[sum] = sumMap[sum] + 1;
                }
                else
                {
                    sumMap.Add(sum, 1);
                }
            }

            Console.WriteLine(targetCount);
        }

        private static void mergeIntervalList()
        {
            List<Interval> iList1 = new List<Interval>();
            iList1.Add(new Interval(1,5));
            iList1.Add(new Interval(10,14));
            iList1.Add(new Interval(16,18));
            iList1.Add(new Interval(161, 181));
            Console.WriteLine("List1");
            foreach (Interval a in iList1)
            {
                Console.WriteLine("{0}-{1}", a.start, a.end);
            }

            List<Interval> iList2 = new List<Interval>();
            iList2.Add(new Interval(2, 6));
            iList2.Add(new Interval(8,10));
            iList2.Add(new Interval(11,20));
            Console.WriteLine("List2");
            foreach (Interval a in iList2)
            {
                Console.WriteLine("{0}-{1}", a.start, a.end);
            }

            List<Interval> shortList = iList1.Count > iList2.Count ? iList2 : iList1;
            List<Interval> longList = iList1.Count < iList2.Count ? iList2 : iList1;
            longList.Sort();
            foreach (var i in shortList)
            {
                //mergeInterval(i, longList);
            }
            Console.WriteLine("List1");
            foreach (Interval a in iList1)
            {
                Console.WriteLine("{0}-{1}", a.start, a.end);
            }
            Console.WriteLine("List2");
            foreach (Interval a in iList2)
            {
                Console.WriteLine("{0}-{1}", a.start, a.end);
            }


        }

        private static void mergeInterval2(Interval interval, List<Interval> iList2)
        {
            int start = interval.start;
            int end = interval.end;
            List<Interval> res = new List<Interval>();
            for(int i=1; i<iList2.Count; i++)
            {
                
            }
            //res.Add( new Interval(start, end));
        }
        //var b = iList2[i];
        //        if (b.start >= end)
        //        {
        //            res.Add(new Interval(start, end));
        //        }
        //        else if (b.end <= start)
        //        {
        //            res.Add(new Interval(b.start, b.end));
        //        }
        //        else if (start<b.start && end<b.end)
        //        {
        //            end = b.end;
        //        }
        //        else if (start> b.start && end> b.end)
        //        {
        //            start = b.start;
        //        }

        private static void greatEscape()
        {
            char[,] map = {
                               { '_','w','g','_'},
                               { '_','_','_','w'},
                               { '_','w','_','w'},
                               { 'g','w','_','_'},

            };
            string[,] cost = new string[map.GetLength(0), map.GetLength(1)];

            for (int r = 0; r < map.GetLength(0); r++)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                     if (map[r,c]=='g')
                     {
                        cost[r, c] = "g";

                     }
                     else if (map[r, c] == 'w')
                    {
                        cost[r, c] = "w";
                    }
                    else
                    {
                        cost[r, c] = getPathtoGate(map, r, c).ToString();
                    }
                        
                }
            }
            for (int r = 0; r < map.GetLength(0); r++)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    Console.Write("{0}  ", cost[r, c]);
                }
                Console.WriteLine();
            }

        }

        public class mazeq
        {
            public int r;
            public int c;
            public int dist;
            public mazeq(int r, int c, int dis)
            {
                this.r = r;
                this.c = c;
                this.dist = dis;
            }
        }
        private static int getPathtoGate(char[,] map, int r, int c)
        {
            if (map[r,c]=='g')
            {
                return 0;
            }
            Queue<mazeq> q = new Queue<mazeq>();
            //bool[,] visited = new bool[map.GetLength(0), map.GetLength(1)];

            q.Enqueue(new mazeq(r, c, 0));
            
            while (q.Count>0)
            {
                var cur = q.Dequeue();
                if (isValidMazeBoard(map, cur) )
                {
                    //visited[cur.r, cur.c] = true;

                    if ( map[cur.r, cur.c] != 'w' && map[cur.r, cur.c] != 'g')
                    {
                        q.Enqueue(new mazeq(cur.r + 1, cur.c, cur.dist + 1));
                        q.Enqueue(new mazeq(cur.r - 1, cur.c, cur.dist + 1));
                        q.Enqueue(new mazeq(cur.r, cur.c + 1, cur.dist + 1));
                        q.Enqueue(new mazeq(cur.r, cur.c - 1, cur.dist + 1));
                    }
                    else if (map[cur.r, cur.c] == 'g')
                    {
                        return cur.dist;
                    }
                }
                
            }
            return int.MaxValue;
        }

        private static bool isValidMazeBoard(char[,] map, mazeq cur)
        {
            if (cur.r >=0 && cur.r <map.GetLength(0) && cur.c >=0 && cur.c<map.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void greatEscape1()
        {
            char[,] map = {
                               { '_','w','g','_'},
                               { '_','_','_','w'},
                               { '_','w','_','w'},
                               { 'g','w','_','_'},

            };
            int[,] cost = new int[map.GetLength(0), map.GetLength(1)];
            bool[,] visited = new bool[map.GetLength(0), map.GetLength(1)];
            for (int r = 0; r < map.GetLength(0); r++)
            {
                for (int c = 0; c < map.GetLength(1); c++)
                {
                    cost[r, c] = int.MaxValue;
                }
            }
            for (int r=0; r<map.GetLength(0);r++)
            {
                for(int c=0; c<map.GetLength(1);c++)
                {
                    if (map[r, c] == 'g')
                    {
                        cost[r, c] = 0;
                        visited[r, c] = true;
                        exploreCost(map, r, c, cost, visited);
                    }
                }
            }

        }

        private static void exploreCost(char[,] map, int r, int c, int[,] cost, bool[,] visited)
        {
            List<cell> neigh = new List<cell> {  new cell(-1,-1),
            new cell(-1,0),
            new cell(-1,1),
            new cell(0,-1),
            new cell(0,1),
            new cell(1,-1),
            new cell(1,0),
            new cell(1,1),};
            if (map[r,c]=='g')
            {
                cost[r, c] = 0;
                return;
            }
            
            visited[r, c] = true;
            foreach (var n in neigh)
            {
                int nr = r + n.x;
                int nc = c + n.y;

                if (nr > 0 && nr < map.GetLength(0) && nc > 0 && nc < map.GetLength(1))
                {
                    
                }
            }
        }

        private static void stepsFromGate(char[,] map, int r, int c, bool[,] visited, int[,] cost)
        {
            List<cell> neigh = new List<cell> {  new cell(-1,-1),
            new cell(-1,0),
            new cell(-1,1),
            new cell(0,-1),
            new cell(0,1),
            new cell(1,-1),
            new cell(1,0),
            new cell(1,1),};
        
        
            
            foreach(var n in neigh)
            {
                int nr = r + n.x;
                int nc = c + n.y;

                if (nr > 0 && nr < map.GetLength(0) && nc > 0 && nc < map.GetLength(1) )
                {
                    if (visited[nr, nc] == false)
                    {
                        stepsFromGate(map, nr, nc, visited, cost);
                        
                    }
                }
            }



        }

        private static void beautifulArray()
        {
            int[] a = { 2, 5, 4, 9 };
            int m = 1;
            int n = a.Length;
            int i = 0;
            int j = 0;
            int oddCount = 0;
            int bCount = 0;
            while (oddCount!=m && j<n)
            {
                if (isOdd(a[j]))
                {
                    oddCount++;
                }
                j++;
                //if (oddCount != m)
                //{
                //    j++;
                //}
            }
            if (oddCount < m)
            {
                return;
            }
            else
            {
                
            }

            while(j<n)
            {
                while(i<j)
                {
                    bCount++;
                    if (isOdd(a[i]))
                    {
                        i++;
                        break;
                    }
                    i++;
                }

                int c = 0;
                while(j<n)
                {
                    
                    if (isOdd(a[j]))
                    {
                        bCount = bCount + c;
                        j++;
                        break;
                    }
                    else
                    {
                        c++;
                        j++;
                    }
                    
                }
                if (j==n)
                {
                    break;
                }
            }

            Console.WriteLine(bCount);

        }
        public static bool isOdd(int n)
        {
            if (n % 2 == 0)
                return false;
            else
                return true;
        }

        public static void setofIntegerSum(int[] a , int target)
        {

        }

        private static void spiralMatrix2()
        {
            int n = 5;

            int[,] matrix = new int[n, n];
            int val = 1;
            int left = 0;
            int right = n - 1;
            int top = 0;
            int bottom = n - 1;
            while(bottom>=top && left<=right)
            {
                for(int c=left;c<=right;c++ )
                {
                    matrix[top, c] = val++;
                }
                top++;

                for(int r=top; r<=bottom; r++)
                {
                    matrix[r, right] = val++;
                }
                right--;

                for(int c=right; c>=left;c--)
                {
                    matrix[bottom, c] = val++;
                }
                bottom--;

                for(int r=bottom;r>=top;r--)
                {
                    matrix[r, left] = val++;
                }
                left++;

            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0}     ", matrix[r, c]);
                }
                Console.WriteLine();
            }


        }

        private static void levelorderBinaryTree()
        {
            bNode root = new bNode();
            root.data = 5;
            bNode a = new bNode();
            a.data = 4;
            bNode b = new bNode();
            b.data = 8;
            bNode c = new bNode();
            c.data = 11;
            bNode d = new bNode();
            d.data = 13;
            bNode e = new bNode();
            e.data = 4;
            bNode f = new bNode();
            f.data = 7;
            bNode g = new bNode();
            g.data = 2;
            bNode h = new bNode();
            h.data = 5;
            bNode i = new bNode();
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

            Queue<bNode> q = new Queue<bNode>();
            q.Enqueue(root);

            while(q.Count>0)
            {
                int size = q.Count;
                while(size>0)
                {
                    bNode cur = q.Dequeue();
                    size--;
                    Console.Write("{0} ",cur.data);
                    if (cur.left != null) q.Enqueue(cur.left);
                    if (cur.right != null) q.Enqueue(cur.right);

                }
                Console.WriteLine();
            }

        }

        private static void LongestIncreasingSubsequence()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] lis = new int[a.Length];
            lis[0] = 1;

            for(int i=1; i<a.Length;i++)
            {
                int maxLen = 1;
                for(int j=0; j<i;j++)
                {
                    if (a[i]>a[j])
                    {
                        maxLen = maxLen > (lis[j] + 1) ? maxLen : (lis[j] + 1);
                    }
                }
                lis[i] = maxLen;
            }
            int longest = 1;
            for(int i=0; i<a.Length;i++)
            {
                if (lis[i]>longest)
                {
                    longest = lis[i];
                }
            }
            Console.WriteLine(longest);

        }

        private static void roatateImage()
        {
            int[,] matrix = new int[,]
           {
                {1,2,1,2,1 },
                {1,3,0,5,2 },
                {5,2,1,4,5 },
                {0,3,0,1,1 },
                {1,3,4,5,6 },

           };
            int n = matrix.GetLength(0) - 1;
            for (int r = 0; r <=n; r++)
            {
                for (int c = 0; c <=n; c++)
                {
                    Console.Write("{0} ", matrix[r, c]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(); Console.WriteLine();
            matrix=matrixrotate(matrix,0,0,n,n);

            for(int r=0; r<=n;r++)
            {
                for(int c=0;c<=n; c++)
                {
                    Console.Write("{0} ", matrix[r, c]);
                }
                Console.WriteLine();
            }
        }

        private static int[,] matrixrotate(int[,] a, int sr, int sc, int er, int ec)
        {
            if (sr>=er && sc>=ec)
            {
                return a;
            }
            //rotate outermost layer
            for(int i=0; i<(er-sr);i++)
            {
                //var temp = a[sr, sc + i];
                //a[sr, sc + i] = a[sr + i, ec];
                //a[sr + i, ec] = a[er, ec - i];
                //a[er, ec - i] = a[er - i, sc];
                //a[er - i, sc] = temp;

                var temp = a[er - i, sc];
                a[er - i, sc] = a[er, ec - i];
                a[er, ec - i] = a[sr + i, ec];
                a[sr + i, ec] = a[sr, sc + i];
                a[sr, sc + i] = temp;
            }
            return matrixrotate(a, sr + 1, sc + 1, er - 1, ec - 1);
        }

        private static void minimumSumPath()
        {
            int[,] matrix = new int[,]
           {
                {1,2,1,2,1 },
                {1,3,0,5,2 },
                {5,2,1,4,5 },
                {0,3,0,1,1 },
           };
            int pathCost = findCheapPath(matrix, 0, 0);
            Console.WriteLine(pathCost);
        }

        private static int findCheapPath(int[,] matrix, int r, int c)
        {
            if(r==matrix.GetLength(0)-1 && c==matrix.GetLength(1)-1)
            {
                return 0;
            }
            else
            {
                int rpath = int.MaxValue;
                int dpath = int.MaxValue;
                if (r+1 < matrix.GetLength(0) )
                {
                    dpath = findCheapPath(matrix, r + 1, c);
                }
                if (c + 1 < matrix.GetLength(1))
                {
                    rpath = findCheapPath(matrix, r , c+1);
                }
                return matrix[r, c] + Math.Min(rpath, dpath);

            }

        }

        public class bNode
        {
            public int data;
            public bNode right;
            public bNode left;
        }
        private static void BinaryTreefromstring()
        {
            Stack<bNode> s = new Stack<bNode>();
            string tree = "4(2(3)(1))(6(5))";
            int? val = null;
            for(int i=0; i<tree.Length;i++)
            {
                if (tree[i]>='0' && tree[i]<='9')
                {
                    val = val??0 * 10 + (tree[i] - '0');
                }
                else if (tree[i]=='(')
                {
                    if (val.HasValue)
                    {
                        bNode n = new bNode();
                        n.data = (int)val;
                        val = null;
                        s.Push(n);
                    }
                    else
                    {

                    }
                }
                else if (tree[i]==')')
                {
                    if (val.HasValue)
                    {
                        bNode n = new bNode();
                        n.data = (int)val;
                        val = null;
                        bNode a1 = s.Pop();
                        if (a1.left == null)
                        {
                            a1.left = n;
                        }
                        else
                        {
                            a1.right = n;
                        }
                        s.Push(a1);
                    }
                    else
                    {
                        if (s.Count >= 2)
                        {


                            bNode a1 = s.Pop();
                            bNode b = s.Pop();
                            if (b.left == null)
                            {
                                b.left = a1;
                            }
                            else
                            {
                                b.right = a1;
                            }
                            s.Push(b);
                        }
                    }
                }
            }
            int a= s.Count;
        }

        private static void onesandZeros()
        {
            string[] a = new string[]{ "10", "0001", "111001", "1", "0" };
            int zeroCount = 5;
            int oneCount = 3;
            //int[] used = new int[a.Length];
            int count = 0;
            int maxCount = 0;
            maxCount= findMaxMatch(a, zeroCount, oneCount, 0, count, maxCount);
            Console.WriteLine(maxCount);
        }

        private static int findMaxMatch(string[] a, int zeroCount, int oneCount, int startIndex, int count, int maxCount)
        {
            if (zeroCount==0 && oneCount ==0)
            {
                if (count>maxCount)
                {
                    maxCount = count;
                    return maxCount;                }
            }
            if (startIndex>=a.Length)
            {
                return maxCount;
            }

            int ocount= countZero(a[startIndex]);
            int icount = countOnes(a[startIndex]);

            if (zeroCount>=ocount && oneCount>= icount)
            {
                maxCount = findMaxMatch(a, zeroCount - ocount, oneCount - icount, startIndex + 1, count + 1, maxCount);
            }
            maxCount = findMaxMatch(a, zeroCount, oneCount, startIndex + 1, count, maxCount);
            return maxCount;
        }

        private static int countOnes(string v)
        {
            int count = 0;
               foreach(char c in v)
                {
                    if (c == '1')
                        count++;
                }
                return count;
        }

        private static int countZero(string v)
        {
            int count = 0;
            foreach (char c in v)
            {
                if (c == '0')
                    count++;
            }
            return count;
        }

        private static void sortColors()
        {
            int[] colors = new int[] { 0, 1, 2, 1, 1, 0, 0, 0, 2, 1, 2, 1, 0 };
            int i = 0;
            int j = colors.Length-1;
            while(i<j)
            {
                while (colors[i] == 0 && i<j)
                    i++;
                while (colors[j] != 0 && i<j)
                    j--;

                
                    var temp = colors[i];
                    colors[i] = colors[j];
                    colors[j] = temp;
                    i++;
                    j--;
                
            }
            for (int a = 0; a < colors.Length; a++)
            {
                Console.Write("{0}  ",colors[a]);
            }

            Console.WriteLine();
            j = colors.Length - 1;
            while (i < j)
            {
                while (colors[i] == 1 && i < j)
                    i++;
                while (colors[j] != 1 && i < j)
                    j--;


                var temp = colors[i];
                colors[i] = colors[j];
                colors[j] = temp;
                i++;
                j--;

            }
            for (int a = 0; a < colors.Length; a++)
            {
                Console.Write("{0}  ", colors[a]);
            }
        }

        class GEdge
        {
            public int from;
            public int to;
            public GEdge(int f, int t)
            {
                from = f;
                to = t;
            }
        }
        private static void graphValidTree()
        {

            int number_of_vertices = 9;
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();
            List<GEdge> l = new List<GEdge>();
            GEdge a;
            a = new GEdge(1, 4);
            l.Add(a);
            a = new GEdge(0, 7); l.Add(a);
            a = new GEdge(7, 8); l.Add(a);
            a = new GEdge(7, 6); l.Add(a);
            a = new GEdge(5, 6); l.Add(a);
            a = new GEdge(6, 4); l.Add(a);
            a = new GEdge(4, 2); l.Add(a);
            a = new GEdge(4, 3); l.Add(a);
            a = new GEdge(0, 2); l.Add(a);

            for (int v =0; v<number_of_vertices; v++)
            {
                adjList.Add(v,new List<int>());
            }
            foreach (var e in l)
            {
                adjList[e.from].Add(e.to);
                adjList[e.to].Add(e.from);
            }

            //BFS(number_of_vertices, adjList);
            DFS(number_of_vertices, adjList);


        }

        private static void DFS(int number_of_vertices, Dictionary<int, List<int>> adjList)
        {
            int[] prev = new int[number_of_vertices];
            for(int i=0; i<number_of_vertices;i++)
            {
                prev[i] = -1;
            }
            bool[] visited = new bool[number_of_vertices];
            dfsHelper(0, adjList, visited, prev);

        }

        private static void dfsHelper(int vertex, Dictionary<int, List<int>> adjList, bool[] visited, int[] prev)
        {
            visited[vertex] = true;
            Console.WriteLine(vertex);
            foreach(var n in adjList[vertex])
            {
                if (visited[n] && prev[vertex]!=n)
                {
                    Console.WriteLine("Not a tree");
                    return;
                }
                if (!visited[n])
                {
                    prev[n] = vertex;
                    dfsHelper(n, adjList, visited,prev);
                }
            }
        }

        private static void BFS(int number_of_vertices, Dictionary<int, List<int>> adjList)
        {
            int[] prev = new int[number_of_vertices];
            bool[] visited = new bool[number_of_vertices];
            Queue<int> q = new Queue<int>();
            prev[0] = -1;
            q.Enqueue(0);
            var cur = 0;
            while (q.Count>0)
            {
                cur = q.Dequeue();
                
                visited[cur] = true;
                Console.WriteLine(cur);
                foreach( var v in adjList[cur])
                {
                    if (visited[v] && prev[cur]!=v)
                    {
                        Console.WriteLine("Not a tree");
                        return;
                    }
                    else if (prev[cur] != v)
                    {
                        prev[v] = cur;
                        q.Enqueue(v);
                    }
                }

            }
        }

        private static void uglyNumbers()
        {
            int n = 10;
            int[] ugly = new int[n];
            ugly[0] = 1;
            int index2 = 2, index3 = 2, index5 = 2;
            int factor2 = 2, factor3 = 3, factor5 = 5;
            for (int i = 1; i < n; i++)
            {
                int min = Math.Min(Math.Min(factor2, factor3), factor5);
                Console.WriteLine("min-{0}", min);
                ugly[i] = min;
                if (factor2 == min)
                    factor2 = 2 * index2++;
                if (factor3 == min)
                    factor3 = 3 * index3++;
                if (factor5 == min)
                    factor5 = 5 * index5++;

                Console.WriteLine("f2-{0}", factor2);
                Console.WriteLine("f3-{0}", factor3);
                Console.WriteLine("f5-{0}", factor5);
            }
            
            for (int i=0;i<n;i++)
            {
                Console.WriteLine(ugly[i]);
            }

        }


        public static void nthSuperUglyNumber(int n, int[] primes)
        {
            int len = primes.Length;
            int[] ugly = new int[n], index = new int[len], factor = new int[len], mul = new int[len];
            for (int i = 0; i < len; i++)
            {
                index[i] = 0;
                factor[i] = primes[i];
                mul[i] = primes[i];
            }
            ugly[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < len; j++)
                {
                    if (min > factor[j]) min = factor[j];
                }
                ugly[i] = min;
                for (int j = 0; j < len; j++)
                {
                    if (factor[j] == min) factor[j] = mul[j] * ugly[++index[j]];
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ugly[i]);
            }

        }
        private static void SuperDuperuglyNumbers()
        {
            int n = 25;
            int[] primes = new int[] { 2, 7, 13, 19 };

            int[] factors = new int[primes.Length];
            int[] index = new int[primes.Length];
            for (int i=0; i< primes.Length;i++)
            {
                factors[i] = primes[i];
                index[i] = 2;
            }
            int[] ugly = new int[n];
            ugly[0] = 1;
           
            for (int i = 1; i < n; i++)
            {
                int min = factors[0];
               
                int pos = 0;
                for (int j = 0; j < factors.Length; j++)
                {
                    if (min > factors[j])
                    {
                        min = factors[j];
                        pos = j;
                    }
                }

                Console.WriteLine("min-{0}", min);
                ugly[i] = min;

                factors[pos] = primes[pos] * index[pos];
                index[pos]++;

                for (int a = 0; a < factors.Length; a++)
                {
                    Console.Write("{0}  ", factors[a]);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ugly[i]);
            }
            nthSuperUglyNumber(n,primes);

        }

        private static int arrayMinimum(int[] factors)
        {
            int min = factors[0];
            for(int i=0; i<factors.Length;i++)
            {
                if (min<factors[i])
                {
                    min = factors[i];
                }
            }
            return min;
        }

        private static void superUglyNumbers()
        {
            int target = 26;

            HashSet<int> h = getPrimefactors(target);
            foreach(int i in h)
            {
                Console.WriteLine(i);
            }


        }

        private static HashSet<int> getPrimefactors(int target)
        {
            HashSet<int> h=null;
            if (target==1)
            {
                return new HashSet<int>();
            }
            for(int i=2; i<=target; i++)
            {
                if (target%i==0)
                {
                    h=getPrimefactors(target / i);
                    h.Add(i);
                    break;
                }

            }
            return h;
        }

        private static void longestSubstringwithRepeatingChar()
        {
            string S = "aaabb";
            int k = 3;
            int[] longest = new int[S.Length];
            int[] alphabetCount = new int[26];
            for (int i=0; i<S.Length; i++)
            {
                alphabetCount[S[i] - 'a']++;
            }
            if (alphabetCount[S[0]-'a'] >= k)
                longest[0] = 1;

            for(int i=1; i<S.Length; i++)
            {
                if (alphabetCount[S[i] - 'a'] >= k)
                {
                    longest[i] = longest[i - 1] + 1;
                }
                else
                {
                    longest[i] = 0;
                }
            }
            int max = 0;
            for(int i=0; i<S.Length; i++)
            {
                Console.WriteLine(longest[i]);
                if (longest[i] > max)
                    max = longest[i];
            }

            Console.WriteLine(max);

        }

        private static void wiggleSubsequence()
        {
            int[] a = new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 };
            int[] up = new int[a.Length];
            int[] down = new int[a.Length];
            up[0] = 1;
            down[0] = 1;
            for (int i=1; i<a.Length; i++)
            {
                if (a[i]>a[i-1])
                {
                    up[i] = down[i - 1] + 1;
                    down[i] = down[i - 1];
                }
                else if (a[i]<a[i-1])
                {
                    up[i] = up[i - 1];
                    down[i] = up[i - 1] + 1;
                }
                else if (a[i]==a[i-1])
                {
                    down[i] = down[i - 1];
                    up[i] = up[i - 1];
                }
            }
            Console.WriteLine( Math.Max(down[a.Length - 1], up[a.Length - 1]));
        }

        private static void subset2()
        {
            int[] nums = new int[] { 1, 2, 2 };
            int startIndex = 0;
            List<List<int>> res = new List<List<int>>();
            bool[] used = new bool[nums.Length];
            findSubsets(nums, startIndex, res,used);
            foreach(var l in res)
            {
                foreach(var i in l)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }
        }
        private static void findSubsets(int[] nums, int startIndex, List<List<int>> res, bool[] used)
        {
            if (startIndex > nums.Length - 1)
            {
                List < int > l= new List<int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (used[i] == true)
                        l.Add(nums[i]);
                }
                res.Add(l);
                
                return;
            }
            int cur = nums[startIndex];
            used[startIndex]=true;
            findSubsets(nums, startIndex + 1, res, used);
            used[startIndex] = false;
            int r = 1;
            while (startIndex + r < nums.Length && nums[startIndex + r] == nums[startIndex]) r++;
            findSubsets(nums, startIndex + r, res, used);

        }
        private static void combinationSum()
        {
            int[] arr = new int[] { 10, 1,1, 2, 7, 6, 1, 5 };
            //int[] arr = new int[] { 1, 1, 2, 5, 6, 7, 10 };
            int target = 8;
            arr = sort(arr);
            combSumHelper(arr, 0, new bool[arr.Length], target);
        }
        private static void combSumHelper(int[] a, int si, bool[] used, int target)
        {
            if (target == 0)
            {

                for (int i = 0; i < a.Length; i++)
                {
                    if (used[i] == true)
                        Console.Write("{0} ", a[i]);
                }
                Console.WriteLine();
                return;
            }

            if (si >= a.Length || target < 0)
            {
                return;
            }
            int curr = a[si];




            used[si] = true;
            combSumHelper(a, si + 1, used, target - a[si]);
            used[si] = false;
            int r = 1;
            while (si + r < a.Length && a[si] == a[si + r]) r++;
            combSumHelper(a, si + r, used, target);
        }
        //private static void combSumHelper(int[] arr, int startIndex, List<int> prefix, int target)
        //{

        //    int sum = 0;
        //    foreach(var el in prefix)
        //    {
        //        sum= sum + el;
        //    }
        //    if (sum==target)
        //    {
        //        foreach (var el in prefix)
        //        {
        //            Console.Write("{0} ", el);
        //        }
        //        Console.WriteLine();
        //        return;
        //    }
        //    if (startIndex>=arr.Length)
        //    {
        //        return;
        //    }
        //    if (sum > target)
        //    {
        //        return;
        //    }

        //    prefix.Add(arr[startIndex]);
        //    combSumHelper(arr, startIndex + 1, prefix, target);
        //    prefix.Remove(arr[startIndex]);
        //    combSumHelper(arr, startIndex + 1, prefix, target);
        //}

       

        class nextrightBNode
        {
            public int data;
            public nextrightBNode left, right, next;
            public nextrightBNode() { }
        }
        private static void nextRightBinaryTree()
        {
            nextrightBNode root = new nextrightBNode();
            root.data = 5;
            nextrightBNode a = new nextrightBNode();
            a.data = 4;
            nextrightBNode b = new nextrightBNode();
            b.data = 8;
            nextrightBNode c = new nextrightBNode();
            c.data = 11;
            nextrightBNode d = new nextrightBNode();
            d.data = 13;
            nextrightBNode e = new nextrightBNode();
            e.data = 4;
            nextrightBNode f = new nextrightBNode();
            f.data = 7;
            nextrightBNode g = new nextrightBNode();
            g.data = 2;
            nextrightBNode h = new nextrightBNode();
            h.data = 5;
            nextrightBNode i = new nextrightBNode();
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


            setnext(root, null);

        }



        private static void setnext(nextrightBNode root, nextrightBNode sibling)
        {
            if (root.left!=null)
            {
                root.left.next = root.right;
                setnext(root.left, root.left.next);
            }
            if (root.right!=null)
            {
                root.right.next = sibling == null ? null : sibling.left;
                setnext(root.right, root.right.next);
            }
        }

        private static void HouseRobber()
        {
            int[] stash = new int[] { 2, 4, 10, 15, 20, 1, 1, 4 };
            int loot = robHelper(stash, stash.Length);
            Console.WriteLine(loot);
            int lootd = dunamicRobHelper(stash);
            Console.WriteLine(lootd);
        }

        private static int dunamicRobHelper(int[] stash)
        {
            int[] bestLoot = new int[stash.Length];
            for (int i = 0; i < stash.Length; i++)
            {
                if (i == 0)
                {
                    bestLoot[i] = stash[i];
                }
                else if (i==1)
                {
                    bestLoot[i]=stash[0] > stash[1] ? stash[0] : stash[1];
                }
                else
                {
                    bestLoot[i] = Math.Max(stash[i] + bestLoot[i - 2], bestLoot[i - 1]);
                }

            }
            return bestLoot[stash.Length - 1];
        }

        private static int robHelper(int[] stash, int length)
        {
            if (length<=0)
            {
                return 0;
            }
            if (length==1)
            {
                return stash[0];

            }
            else if (length==2)
            {
                return stash[0] > stash[1] ? stash[0] : stash[1];
            }

            return Math.Max(stash[length - 1] + robHelper(stash, length - 2), robHelper(stash, length - 1));

        }

        private static void phoneCombination()
        {
            Dictionary<int, List<char>> alphaNumericMap = new Dictionary<int, List<char>>();
            char c = 'a';
            for(int i=2; i<=9; i++)
            {
                alphaNumericMap.Add(i, new List<char>());
                for (int j=0; j<3;j++)
                {
                    alphaNumericMap[i].Add(c);
                    c++;
                }
            }
            String digitString = "23";
            string prefix = "";
            phoneHelper(digitString,0, alphaNumericMap, prefix);

        }

        private static void phoneHelper(string digitString, int startIndex, Dictionary<int, List<char>> alphaNumericMap, string prefix)
        {
            if (startIndex>=digitString.Length)
            {
                Console.WriteLine(prefix);
                return;
            }
            int cur = digitString[startIndex]-'0';
            foreach(char c in alphaNumericMap[cur])
            {
                String newprefix = prefix+c;
                phoneHelper(digitString, startIndex + 1, alphaNumericMap, newprefix);
            }
        }

        private static void numberOfIsland()
        {
            int[,] matrix = new int[,]
            {
                {1,1,0,0,0 },
                {1,1,0,0,0 },
                {0,0,1,0,0 },
                {0,0,0,1,1 },
            };

            int islandCount = 0;
            bool[,] visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for(int r=0; r<matrix.GetLength(0);r++)
            {
                for(int c=0; c<matrix.GetLength(1);c++)
                {
                    if (!visited[r,c] && matrix[r,c]==1)
                    {
                        islandCount++;
                        exploreIsland(matrix,visited,r,c);
                    }
                }
            }
            Console.WriteLine(islandCount);
        }

        class seaCord
        {
            public int r;
            public int c;
            public seaCord(int x,int y)
            {
                this.r = x;
                this.c = y;
            }
        }

        private static void exploreIsland(int[,] matrix, bool[,] visited, int r, int c)
        {
            Queue<seaCord> q = new Queue<seaCord>();
            q.Enqueue(new seaCord(r, c));

            while(q.Count>0)
            {
                var cur = q.Dequeue();
                visited[cur.r, cur.c] = true;
                if (isValidSeaCord(matrix, cur.r-1,cur.c) && !visited[cur.r-1,cur.c] && matrix[cur.r-1,c]==1)
                {
                    q.Enqueue(new seaCord(cur.r - 1, cur.c));
                }
                if (isValidSeaCord(matrix, cur.r +1, cur.c) && !visited[cur.r+1, cur.c] && matrix[cur.r + 1, c] == 1)
                {
                    q.Enqueue(new seaCord(cur.r +1 , cur.c));
                }
                if (isValidSeaCord(matrix, cur.r, cur.c+1) && !visited[cur.r, cur.c+1] && matrix[cur.r, c+1] == 1)
                {
                    q.Enqueue(new seaCord(cur.r, cur.c+1));
                }
                if (isValidSeaCord(matrix, cur.r, cur.c-1) && !visited[cur.r, cur.c-1] && matrix[cur.r, c-1] == 1)
                {
                    q.Enqueue(new seaCord(cur.r, cur.c-1));
                }

            }
        }

        private static bool isValidSeaCord(int[,] matrix, int r, int c)
        {
            if (r>=0 && c>=0 && r<matrix.GetLength(0) && c<matrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void pacificAtlanticFlow()
        {
            int[,] matrix = new int[,]
            {
                {1,2,2,3,5 },
                {3,2,3,4,4 },
                {2,4,5,3,1 },
                {6,7,1,4,5 },
                {5,1,1,2,4 }
            };
            bool[,] flowToBoth = new bool[matrix.GetLength(0),matrix.GetLength(1)];

            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {

                    HashSet<String> ocean = oceanFlows(matrix, r, c);
                    if (ocean.Count==2)
                    {
                        flowToBoth[r, c] = true;
                    }

                }
            }
            for (int r = 0; r < matrix.GetLength(0); r++)
            {
                for (int c = 0; c < matrix.GetLength(1); c++)
                {
                    Console.Write("{0}  ", flowToBoth[r, c]);
                }
                Console.WriteLine();
            }
        }
        class oceanCord
        {
            public int r;
            public int c;
            public oceanCord(int x, int y)
            {
                this.r = x;
                this.c = y;
            }
        }
        private static HashSet<string> oceanFlows(int[,] matrix, int r, int c)
        {
            bool[,] isVisited = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            Queue<oceanCord> q = new Queue<oceanCord>();
            HashSet<String> oceans = new HashSet<string>();
            q.Enqueue(new oceanCord(r, c));
            while (q.Count>0)
            {
                oceanCord cur = q.Dequeue();


                if (!isVisited[cur.r, cur.c])
                {
                    string oc;
                    if (!isOcean(matrix, cur.r - 1, cur.c, out oc))
                    {
                        if (matrix[cur.r, cur.c] >= matrix[cur.r - 1, cur.c])
                            q.Enqueue(new oceanCord(cur.r - 1, cur.c));
                    }
                    else
                    {
                        oceans.Add(oc);
                    }

                    if (!isOcean(matrix, cur.r + 1, cur.c, out oc))
                    {
                        if (matrix[cur.r, cur.c] >= matrix[cur.r + 1, cur.c])
                            q.Enqueue(new oceanCord(cur.r + 1, cur.c));
                    }
                    else
                    {
                        oceans.Add(oc);
                    }
                    if (!isOcean(matrix, cur.r, cur.c - 1, out oc))
                    {
                        if (matrix[cur.r, cur.c] >= matrix[cur.r, cur.c - 1])
                            q.Enqueue(new oceanCord(cur.r, cur.c - 1));
                    }
                    else
                    {
                        oceans.Add(oc);
                    }
                    if (!isOcean(matrix, cur.r, cur.c + 1, out oc))
                    {
                        if (matrix[cur.r, cur.c] >= matrix[cur.r, cur.c + 1])
                            q.Enqueue(new oceanCord(cur.r, cur.c + 1));
                    }
                    else
                    {
                        oceans.Add(oc);
                    }
                    isVisited[cur.r, cur.c] = true;
                }

                   
                    
                }
                
            
            return oceans;

        }



        private static bool isOcean(int[,] matrix, int r, int c, out string oc)
        {
            if (r<0 || c<0)
            {
                oc = "Pacific Ocean";
                return true;
            }
            else if (r>=matrix.GetLength(0) || c>=matrix.GetLength(1))
            {
                oc = "Atlantic Ocean";
                return true;
            }
            oc = "";
            return false;
            
        }

        private static void triangle()
        {
            int[][] tri = new int[][]
            {
                new int[]  {2},
                new int[] {3,4},
                new int[] {6,5,7},
                new int[] {4,1,8,3}
            };

            int sum = maxPathToLeaf(0, 0, tri);
        }

        private static int maxPathToLeaf(int row, int col, int[][] tri)
        {
            int ht = tri.GetLength(0);
            //int ht1 = tri.GetLength(1);
            int h2 = tri[ht-1].Length;

            int val = tri[row][col];

            if (row<3)
            {
                int left = maxPathToLeaf(row + 1, col, tri);
                int right = maxPathToLeaf(row + 1, col+1, tri);
                return Math.Min(left, right)+val;

            }
            else
            {
                return val;
            }


        }

        private static void findsquareroot()
        {
            double a = 2;
            double epsilon = 1e-6;
            double res = question2(a, epsilon);
            Console.WriteLine(res);
        }

        private static double question2(double a, double epsilon)
        {
            double res=a/2;//first approximation;
           
            
            while (Math.Abs((res*res)-a) > epsilon)
            {
                double y = a / res;
                res = (res + y) / 2;
                //Console.WriteLine(res);
            }
            return res;
        }

        private static void  remdupHelper()
        {
            int[] a = new int[] { 1, 2, 3, 3, 4, 4, 10, 13, 15, 15, 17 };
            int[] b= question(a);
            for(int i =0; i<b.Length;i++)
            {
                Console.Write("{0} ", b[i]);
            }
            Console.WriteLine();
            List<int> al = new List<int>();
            al.AddRange(a);
            List<int> bl = questionList(al);
            foreach (var el in bl)
            {
                Console.Write("{0} ", el);
            }
        }
        private static List<int> questionList(List<int> values)
        {
            if (values.Count == 0)
            {
                return new List<int>();
            }


            List<int> uniqueValues = new List<int>();
            uniqueValues.Add(values[0]);
            
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i].Equals(values[i - 1]))
                {
                    uniqueValues.Add(values[i]);
                    
                }
            }
            return uniqueValues;
        }


        private static int[] question(int[] values)
        {
            if (values.Length==0)
            {
                return new int[0];
            }
            
            
            int uniqueValueIndex = 1;
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] != values[i - 1])
                {
                    uniqueValueIndex++;
                }
            }

            int[] uniqueValues = new int[uniqueValueIndex];
            uniqueValues[0] = values[0];
            uniqueValueIndex = 1;
            for (int i=1; i<values.Length;i++)
            {
                if (values[i]!=values[i-1])
                {
                    uniqueValues[uniqueValueIndex] = values[i];
                    uniqueValueIndex++;
                }
            }
            return uniqueValues;
        }

        private static void minesweaper()
        {
            //int[,] minematrix = new int[,]
            //{
            //    {0,0,0 },
            //    {0,1,0 },
            //    { 1,1,1}
            //};
            int[,] minematrix = {

                {0,0,1 ,0},
                {0,0,0,0 },
                { 0,0,0,0},
                { 1,0,0,0}
            };
            int[,] game = new int[minematrix.GetLength(0), minematrix.GetLength(1)];

            for(int r=0; r<minematrix.GetLength(0);r++)
            {
                for(int c=0; c< minematrix.GetLength(1);c++)
                {
                    game[r, c] = nearestZero(minematrix, r, c);
                }
            }
            for (int r = 0; r < minematrix.GetLength(0); r++)
            {
                for (int c = 0; c < minematrix.GetLength(1); c++)
                {
                    Console.Write("{0}  ", game[r, c]);
                }
                Console.WriteLine();
            }


        }
        class mineCord
        {
            public int r;
            public int c;
            public int dist;
            public mineCord(int x,int y,int dist)
            {
                this.r = x;
                this.c = y;
                this.dist = dist;
            }
        }
        private static int nearestZero(int[,] minematrix, int r, int c)
        {
            if (minematrix[r,c]==0)
            {
                return 0;
            }
            Queue<mineCord> q = new Queue<mineCord>();
            q.Enqueue(new mineCord(r, c, 0));
            while(q.Count>0)
            {
                var cur = q.Dequeue();
                if (isValid(cur.r,cur.c,minematrix) && minematrix[cur.r,cur.c]!=0)
                {
                    q.Enqueue(new mineCord(cur.r + 1, cur.c,cur.dist+1));
                    q.Enqueue(new mineCord(cur.r - 1, cur.c, cur.dist + 1));
                    q.Enqueue(new mineCord(cur.r, cur.c+1, cur.dist + 1));
                    q.Enqueue(new mineCord(cur.r, cur.c-1, cur.dist + 1));
                }
                else if (isValid(cur.r, cur.c, minematrix) && minematrix[cur.r, cur.c] == 0)
                {
                    return cur.dist;
                }
            }
            return - 1;
        }

        private static bool isValid(int r, int c, int[,] minematrix)
        {
            if (r>=0 && c>=0 && r<minematrix.GetLength(0) && c<minematrix.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void remoevNth()
        {
            SinglyLinkedListNoHeadNode lnklist = new SinglyLinkedListNoHeadNode();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtLast(2);
            lnklist.AddAtLast(6);
            lnklist.AddAtLast(9);
            lnklist.AddAtLast(6);
            lnklist.AddAtLast(8);
            lnklist.AddAtLast(5);
            lnklist.AddAtLast(4);
            lnklist.AddAtLast(10);
            lnklist.AddAtLast(1);
            Console.WriteLine(5);
            

            //lnklist.RemoveFromStart();
            lnklist.PrintAllNodes();
            lnklist.removenth(4);
            lnklist.PrintAllNodes();

            Console.ReadKey();
        }

        private static void rectiangleArea()
        {
            int A = -3;
            int B = 0;
            int c = 3;
            int D = 4;
            int E = 0;
            int F = -1;
            int G = 9;
            int H = 2;

            int len = getIntersectionLength(A, c, E, G);
            int wid = getIntersectionLength(B, D, F, H);
            int area = ((c - A) * (D - B)) + ((G - E) * (H - F)) - (len * wid);

        }

        private static int getIntersectionLength(int a, int c, int e, int g)
        {
            if (c<e || g<a)
            { return 0; }
            if (a<=e && c>=g)
            {
                return (c - a);
            }
            else if (e<=a && g>=c)
            {
                return g - e;
            }

            if (a < e)
            {
                return c - e;
            }
            else return g - a;
        }

        public static int[] sort(int[] a)
        {
            for(int i=0; i<a.Length;i++)
            {
                for(int j=i+1; j<a.Length;j++)
                {
                    if (a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }
       
        private static void palindromePartitioning()
        {
            String pp = "aab";
            List<string> prefix = new List<string>();
            ppHelper(pp, 0,prefix);
        }

        private static void ppHelper(string pp, int startIndex, List<string> prefix)
        {
            if (startIndex>=pp.Length)
            {
                foreach(string p in prefix)
                {
                    Console.Write("{0} ",p);
                }
                Console.WriteLine();
                return;
            }
            for(int i=startIndex+1;i<=pp.Length;i++)
            {
                string a = pp.Substring(startIndex, i - startIndex);
                if (isPalindrome(a))
                {
                    prefix.Add(a);
                    ppHelper(pp, i , prefix);
                    prefix.Remove(a);
                }
            }
        }

        private static bool isPalindrome(string a)
        {
            int i = 0;
            int j = a.Length - 1;
            while(i<j)
            {
                if (a[i] != a[j])
                    break;
                i++;
                j--;
            }
            if (a[i] == a[j])
                return true;
            else
                return false;

        }

        private static void uniqueWrapAround()
        {
            string s = "abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz";
            string p = "zabx";
            int i = 0;
            int j = 0;
            int count = 0;
            while (j<p.Length)
            {
                i = s.IndexOf(p[j]);
                if (i>=0)
                {
                    int a=getcountofBestMatch(s, p, i, j);
                    j = j + a;
                    count = count + sumFact(a);
                }
            }
            Console.WriteLine(count);
        }

        private static int sumFact(int n)
        {
            int sum = 0;
            for(int i=1; i<=n;i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        private static int getcountofBestMatch(string s, string p, int i, int j)
        {
            int count = 0;
            while(i<s.Length && j < p.Length && s[i]==p[j])
            {
                count++;
                i++;
                j++;
            }
            return count;
        }

        private static void wordBoggle()
        {
            List<String> dict = new List<string> { "geek", "for", "quiz", "go" };
            char[,] boggle = { { 'g','i','z'},
                               { 'u','e','k'},
                               { 'q','s','e'}};
            
            for (int i = 0; i < boggle.GetLength(0); i++)
            {
                for(int j=0; j<boggle.GetLength(1);j++)
                {
                    wordBoggleHelper(dict, boggle, new bool[boggle.GetLength(0), boggle.GetLength(1)], i, j,"");
                }
            }
            
        }

        private static void wordBoggleHelper(List<String> dict, char[,] boggle, bool[,] visited, int startx, int starty, string prefix)
        {
            cell[] neighbormap = new cell[]
            { new cell(-1,-1),
            new cell(-1,0),
            new cell(-1,1),
            new cell(0,-1),
            new cell(0,1),
            new cell(1,-1),
            new cell(1,0),
            new cell(1,1),};

            visited[startx, starty] = true;
            prefix = prefix + boggle[startx, starty];
            if (dict.Contains(prefix))
            {
                Console.WriteLine(prefix);
            }
            foreach (cell n in neighbormap)
            {
                int nx = startx + n.x;
                int ny = starty + n.y;
                if (nx >= 0 && nx < boggle.GetLength(0) && ny >= 0 && ny < boggle.GetLength(1) && !visited[nx, ny])
                {
                    wordBoggleHelper(dict, boggle, visited, nx, ny, prefix);
                }

            }
            visited[startx, starty] = false;


        }
        class cell
        {
            public int x;
            public int y;
            public cell(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        private static void wordBoggleHelper(string[] dict, char[,] boggle, bool[,] visited, int startx, int starty)
        {
            StringBuilder str = new StringBuilder();
            List<char> strl = new List<char>();
            cell[] neighbormap = new cell[]
            { new cell(-1,-1),
            new cell(-1,0),
            new cell(-1,1),
            new cell(0,-1),
            new cell(0,1),
            new cell(1,-1),
            new cell(1,0),
            new cell(1,1),};
            Stack<cell> s = new Stack<cell>();
            s.Push(new cell(startx, starty));
            while(s.Count>0)
            {
                var p = s.Pop();
                visited[p.x, p.y] = true;
                strl.Add(boggle[p.x, p.y]);
                foreach(cell n in neighbormap)
                {
                    int nx = p.x + n.x;
                    int ny = p.y + n.y;
                    if(nx>=0 && nx<boggle.GetLength(0) && ny>=0 && ny<boggle.GetLength(1) && !visited[nx,ny])
                    {
                        s.Push(new cell(nx, ny));
                    }
                }
                
            }
        }

        private static void Sum3CLosest()
        {
            
            int[] arr = new int[] { -1, 2, 1, 4,9,10,15 };
            int target = 1;
            int min = arr[0] + arr[1] + arr[2];
            min = Math.Abs(min - target);
            for (int i=0; i<arr.Length ; i++)
            {
                int a = arr[i];
                int j = i + 1;
                int k = arr.Length - 1;
                
                while(k>j)
                {
                    int sum = arr[i] + arr[j] + arr[k];
                    if (sum==target)
                    {
                        Console.Write(0);
                        return;
                    }
                    else if (sum<target)
                    {
                        j++;
                    }
                    else
                    {
                        k--;
                    }

                    if (Math.Abs(sum-target) < min)
                    {
                        min = Math.Abs(sum - target);
                    }

                }

            }
            Console.WriteLine(min);

        }

        private static void kpairswithSmallestSum()
        {
            int[] num1 = new int[] { 1,7,11 };
            int[] num2 = new int[] { 2,4,6 };
            int k = 9;

            int i = 0;
            int j = 0; 
            while(i<num1.Length && j <num2.Length && k!=0)
            {
                k--;
                Console.WriteLine("({0},{1}",num1[i], num2[j]);
                
                if ((i+1 )>= num1.Length)
                {
                    j = j + 1;
                    i = 0;
                }
                else if ((j+1)>= num2.Length)
                {
                    i = i + 1;
                    j = 0;
                }
                else if (num1[i+1]>num2[j+1])
                {
                    j++;
                    i = 0;
                }
                else
                {
                    i++;
                    j = 0;
                    
                }
            }

         }

        private static void miniParser()
        {
           //implemented on leetcode
        }

        private static void minimumSizeSubarraySum()
        {
            int s = 7;
           
            int[] a = new int[] { 2, 2, 1, 2, 6, 3 };
            int[] count = new int[a.Length];
            int i = 0;
            int j = 0;
            int sum = 0;
            while (sum<s)
            {
                sum = sum + a[j];
                j++;
            }
            count[j - 1] = j - i;
            while(j<a.Length)
            {
                sum = sum + a[j];

                while(i<=j)
                {
                    if (sum >=s)
                    {
                        sum = sum - a[i];
                        i++;
                    }else
                    {
                        break;
                    }
                }
                count[j] = j - i + 2;
                j++;
            }

            for(i=0; i<a.Length; i++)
            { Console.Write(count[i]+" "); }
            
        }

        private static void longestCoommomSubsequence()
        {
            String string1 = "buffallosoilderllallallalallosala";
            string string2 = "allosol";
            int[,] lcs= new int[string1.Length, string2.Length];


            for(int i=0; i<string1.Length;i++)
            {
                for(int j=0; j<string2.Length; j++)
                {
                    if(i==0 || j==0)
                    {
                        lcs[i, j] = 0;
                        
                    }
                    else if (string1[i]==string2[j])
                    {
                        lcs[i, j] = lcs[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        lcs[i, j] = Math.Max(lcs[i - 1, j], lcs[i, j - 1]);
                    }
                }
            }
            Console.WriteLine(lcs[string1.Length - 1, string2.Length - 1]);
        }

        private static void maximumContiguousSummorethan2()
        {
            //int[] arr = new int[] { 3, 2, -7, 9, 8, 10, 15, -1, -10 };
            int[] arr = new int[] { -1, -1, 1, -1, 1, -1, 1, -1,  };

            int[] MCS = new int[arr.Length];
            int maxSoFar = arr[0] + arr[1];
            MCS[0] = 0;
            MCS[1] = maxSoFar;

            for (int i=2; i<arr.Length;i++)
            {
                MCS[i] = Math.Max(MCS[i - 2] + arr[i] + arr[i - 1], arr[i] + arr[i - 1]);
                if (MCS[i] > maxSoFar)
                    maxSoFar = MCS[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(MCS[i]);
            }
            Console.WriteLine(maxSoFar);
        }

        private static void maximumContiguousSum()
        {
            int[] arr = new int[] { 3, 2, -7, 9, 8, 10, 15, -1, -10, 100 };
            int[] MCS=new int[arr.Length];
            int maxSoFar = 0;
            if (arr[0]<0)
            {
                MCS[0] = 0;
            }
            else
            {
                MCS[0] = arr[0];
            }
            for (int i=1; i<arr.Length;i++)
            {
                MCS[i] = Math.Max(MCS[i - 1]+arr[i], 0);
                if (MCS[i] > maxSoFar)
                    maxSoFar = MCS[i];
            }
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine(MCS[i]);
            }
            Console.WriteLine(maxSoFar);
            

        }

        class bracket
        {
            public char openBracket;
            public int index;

        }

        private static void balancingBracket()
        {
            string exp = "((({() {{ [[   ]] }} )))";
            Stack<char> s = new Stack<char>();

            for(int i =0; i<exp.Length; i++)
            {
                if (exp[i] =='(' || exp[i] == '{' || exp[i] == '[')
                {
                    s.Push(exp[i]);
                }
                else if (exp[i] == ')' )
                {
                    char prev = s.Pop();
                    if (prev=='(')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (exp[i] == '}')
                {
                    char prev = s.Pop();
                    if (prev == '{')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (exp[i] == ']')
                {
                    char prev = s.Pop();
                    if (prev == '[')
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                
            }
            Console.WriteLine("Balanced");
            
        }

        class stack
        {
            int[] arr;
            int top;
            public stack(int size)
            {
                arr = new int[size];
                top = -1;
            }

            bool push(int value)
            {
                if (top < arr.Length)
                {
                    top++;
                    arr[top] = value;
                    return true;
                }
                else
                {
                    throw new InvalidOperationException("The stack is full");
                }
            }

            int pop()
            {
                if (top>-1)
                {
                    return arr[top];
                }
                else
                {
                    throw new InvalidOperationException("The stack is empty");
                }
            }

        }


        class ddlNode
        {
            public int data;
            public ddlNode right;
            public ddlNode left;
        }

        class middleOfStack
        {
            ddlNode head;
            ddlNode tail;
            Stack<int> s;
            int countL;
            

            public middleOfStack()
            {
                head = tail = null;
                s = new Stack<int>();
                countL = 0;
                
            }

            public void push(int value)
            {
                if (s.Count==countL)
                {
                    insertAtHead(value);
                }
                else
                {
                    s.Push(tail.data);
                    removeFromTail();
                    insertAtHead(value);
                }
            }

            private void removeFromTail()
            {
                if (tail==null)
                {
                    throw new InvalidOperationException();
                }
                else if (tail==head)
                {
                    countL--;
                    tail = null;
                    head = null;
                }
                else
                {
                    countL--;
                    ddlNode temp = tail.left;
                    temp.right = null;
                    tail = temp;
                }

            }

            public int pop()
            {
                if (s.Count==0 && head==tail)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    int popped= removefromHead();
                    if (countL!=s.Count)
                    {
                        insertAtTail(s.Pop());
                    }
                    return popped;
                }
            }

            private void insertAtTail(int value)
            {
                ddlNode n = new ddlNode();
                n.data = value;

                if (tail == null)
                {
                    countL++;
                    head = n;
                    tail = n;
                }
                else
                {
                    countL++;
                    n.left = tail;
                    tail.right = n;
                    tail = n;
                }
            }

            private int removefromHead()
            {
                int value = 0;
                if (tail == null)
                {
                    throw new InvalidOperationException();
                }
                else if (tail == head)
                {
                    countL--;
                    value = head.data;
                    tail = null;
                    head = null;
                }
                else
                {
                    countL--;
                    value = head.data;
                    head = head.right;
                }
                return value;
            }

            public int getMiddle()
            {
                if (s.Count == countL)
                {
                    int first = tail.data;
                    int second = s.Peek();
                    return (first + second) / 2;
                }
                else
                {
                    return tail.data;
                }
            }

           
            private void insertAtHead(int value)
            {
                ddlNode n = new ddlNode();
                n.data = value;

                if (head==null)
                {
                    countL++;
                    head = n;
                    tail = n;
                }
                else
                {
                    countL++;
                    n.right = head;
                    head.left = n;
                    head = n;
                }
            }
        }

        private static void middleofStack()
        {
            int mid;
            middleOfStack s = new middleOfStack();
            s.push(3);
            mid = s.getMiddle();

            s.push(7);
            mid = s.getMiddle();

            s.push(8);
            mid = s.getMiddle();

            s.push(2);
            mid = s.getMiddle();

            s.push(4);
            mid = s.getMiddle();

            s.push(5);
            mid = s.getMiddle();

            s.push(6);
            mid = s.getMiddle();

            s.push(7);
            mid = s.getMiddle();

            s.push(5);
            mid = s.getMiddle();

            s.pop();
            mid = s.getMiddle();

            s.pop();
            mid = s.getMiddle();

            s.pop();
            mid = s.getMiddle();

            s.pop();
            mid = s.getMiddle();

            s.pop();
            mid = s.getMiddle();

            s.pop();
            mid = s.getMiddle();

        }


        static int combCount;
        private static void combinationsHelper()
        {
            int[] arr = new int[] { 2, 4, 6, 1, 7, 9 };
            combCount = 0;
            combine(arr,0,new List<int>());
            Console.Write(combCount);
        }
        class element
        {
            public int data;
            public bool present;
        }

        private static void combine(int[] arr, int startIndex, List<int> prefix)
        {
            if (startIndex>=arr.Length)
            {
                foreach (int e in prefix)
                {
                        Console.Write("{0} ",e);
                    
                }
                Console.WriteLine();
                combCount++;
            }
            else
            {
                int element = arr[startIndex];
                prefix.Add(arr[startIndex]);
                combine(arr, startIndex + 1, prefix);
                prefix.Remove(arr[startIndex]);
                combine(arr, startIndex + 1, prefix);
            }

           

        }

        static int countPerm;
        private static void helperpermute()
        {
            int[] arr = new int[] { 3, 5, 6, 1, 7, 9 };
            countPerm = 0;
            permute(arr, new bool[arr.Length], new List<int>());
            Console.WriteLine(countPerm);

        }
      
        private static void permute(int[] arr,bool[] used,List<int> prefix)
        {
            if (prefix.Count==arr.Length)
            {
                countPerm++;
                foreach(int i in prefix)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
            }

            for(int i=0; i<used.Length;i++)
            {
                if(!used[i])
                {
                    used[i] = true;
                    prefix.Add(arr[i]);
                    permute(arr, used, prefix);
                    prefix.Remove(arr[i]);
                    used[i] = false;
                }
                
                
            }

        }



        private static void countTrailingZeros()
        {
            int n = 5;
            int count = 0;
            for(int i=5;i<n+1;i=i*5)
            {
                count = count + (n / i);
            }
            Console.WriteLine(count);
        }

        private static void sortInterleavedLinkedList()
        {
            SinglyLinkedListNoHeadNode lnklist = new SinglyLinkedListNoHeadNode();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtLast(2);
            lnklist.AddAtLast(6);
            lnklist.AddAtLast(9);
            lnklist.AddAtLast(6);
            lnklist.AddAtLast(8);
            lnklist.AddAtLast(5);
            lnklist.AddAtLast(4);
            lnklist.AddAtLast(10);
            lnklist.AddAtLast(1);
            Console.WriteLine(5);
            //lnklist.specialSort();
            lnklist.partition(5);

            //lnklist.RemoveFromStart();
            lnklist.PrintAllNodes();

            Console.ReadKey();
        }

        private class Edge
        {
            public string toNode;
            public double value;
            public  Edge(string tNode, double val)
            {
                toNode = tNode;
                value = val;
            }
        }
        private static void evaluateDivision()
        {
            var q = new String[] { "a", "b" };
            String[][] equations = new String[][]
            {
                new String[] { "a", "b" },
                new String[] { "a", "c" },
                new String[] { "c", "a" },
            };

            double[] value = new double[] { 2.0, 2.0, 0.5 };

            string[][] queries = new String[][]
            {
                new String[] { "a", "a" },
                new String[] { "a", "b" },
                new String[] { "b", "b" },
            };

            Dictionary<string, List<Edge>> adjList = new Dictionary<string, List<Edge>>();

           for(int i=0; i<equations.Length;i++)
            {
                string[] equation = equations[i];

                insertList(equation[0], equation[1], value[i], adjList);
                insertList(equation[0], equation[1], 1/value[i], adjList);
            }

            List<double> res = new List<double>();
            for(int i=0; i< queries.Length;i++)
            {
                var query = queries[i];
                Double? result = getValue(query[0], query[1], adjList, new HashSet<string>());
                if(result!=null)
                {
                    res.Add((double)result);
                }
                else
                {
                    res.Add(-1.0);
                }
            }




        }

        private static double? getValue(string src, string dest, Dictionary<string, List<Edge>> adjList, HashSet<string> visited)
        {
            if(src == dest)
            {
                return 1.0;
            }
            if(!adjList.ContainsKey(src) || !adjList.ContainsKey(dest))
            {
                return null;
            }
            
            if (visited.Contains(src + ":" + dest))
            {
                return null;
            }
            visited.Add(src + ":" + dest);

            foreach(Edge e in adjList[src])
            {
                Double? res = getValue(e.toNode, dest, adjList, visited);
                if(res!=null)
                {
                    return res * e.value;
                }
            }
            visited.Remove(src);


            return null;
            
        }

        private static void insertList(string src, string dest, double value, Dictionary<string, List<Edge>> adjList)
        {
            if (!adjList.ContainsKey(src))
            {
                List<Edge> list = new List<Edge>();
                adjList.Add(src, list);
            }
            Edge e = new Edge(dest, value);
            adjList[src].Add(e);


        }

        private static void SequenceReconstruction2()
        {
            int[] org = new int[] { 1, 2, 3 };
            int[][] seqs = new int[][]
            {
                new int[] {1,2},
                new int[] {1,3}
            };
            int size = org.Length;
            List<int>[] adjList = new List<int>[size];
            int[] incomingEdge = new int[size];
            for (int i = 0; i < seqs.Length; i++)
            {
                int[] seq = seqs[i];
                if (seq.Length < 2)
                    continue;
                int a = 0;
                int b = 1;

                while (b < seq.Length)
                {
                    if(adjList[seq[a]]==null)
                    {
                        List<int> adjNodes = new List<int>();
                        adjNodes.Add(seq[b]);
                        adjList[seq[a]] = adjNodes;
                    }
                    else
                    {
                        adjList[seq[a]].Add(seq[b]);
                    }                   
                    a++;
                    b++;
                    incomingEdge[seq[b]] = incomingEdge[seq[b]] + 1;
                }

                
            }
            Queue<int> q = new Queue<int>();
                        
            for (int i = 0; i < size; i++)
            {
                if (incomingEdge[i] == 0)
                {
                    q.Enqueue(i);
                    break;
                }
                    
            }

            if (q.Count>1)
            {
                Console.WriteLine("false");
                return;
            }
                       

            while(q.Count>0)
            {
                int curr = q.Dequeue();

                foreach (int child in adjList[curr])
                {
                    incomingEdge[child] = incomingEdge[child] - 1;
                    if (incomingEdge[child]==0)
                    {
                        q.Enqueue(child);
                    }
                }
                if(q.Count>1)
                {
                    Console.WriteLine("false");
                    return;
                }

            }


        }

        private static void SequenceReconstruction()
        {
            int[] org = new int[] { 1, 2, 3 };
            int[][] seqs = new int[][]
            {
                new int[] {1,2},
                new int[] {1,3}
            };
            int size = org.Length;
            int[,] adjMatrix = new int[size, size];

            for(int i=0; i<seqs.Length;i++)
            {
                int[] seq = seqs[i];
                if (seq.Length < 2)
                    continue;
                int a = 0;
                int b = 1;

                while(b<seq.Length)
                {
                    adjMatrix[seq[a], seq[b]] = 1;
                    a++;
                    b++;
                }
            }
            int startNode;
            for(int j=0; j<size;j++)
            {
                int sum = 0;
                for(int i =0; i<size; i++)
                {
                    sum = sum + adjMatrix[i,j];
                }

                if (sum==0)
                {
                    
                }
            }



        }

        class TNode
        {
            public char data;
            public Dictionary<char, TNode> children;
            public int count;
            public bool isEnd;
        }

        static void triPhoneBook()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            TNode root = new TNode();
            root.data = '0';
            root.children = new Dictionary<char, TNode>();

            for (int a0 = 0; a0 < n; a0++)
            {
                string[] tokens_op = Console.ReadLine().Split(' ');
                string op = tokens_op[0];
                string contact = tokens_op[1];

                if (op.Equals("add"))
                {
                    insertT(root, contact);
                }
                else if (op.Equals("find"))
                {
                    Console.WriteLine(findPattern(root, contact,0));
                }
            }
        }
    

        static void insertT(TNode root, String contact)
        {
            TNode curr = root;
            for (int i = 0; i < contact.Length; i++)
            {
                char c = contact[i];
                TNode next = null;
                if (curr.children.TryGetValue(c, out next))
                {
                    curr.count = curr.count + 1;
                    curr = next;
                }
                else
                {
                    TNode newNode = new TNode();
                    newNode.data = c;
                    newNode.children = new Dictionary<char, TNode>();
                    
                    newNode.count = 1;
                    newNode.isEnd = false;

                    curr.children.Add(c, newNode);
                    curr = newNode;
                }
                
            }
            curr.isEnd = true;
        }

        static int findT(TNode root, String contact)
        {
            TNode curr = root;
            for (int i = 0; i < contact.Length; i++)
            {
                char c = contact[i];
                TNode next = null;

                if (curr.children.TryGetValue(c, out next))
                {
                    curr = next;

                }
                else
                {
                    return 0;
                }
            }
            return curr.count;
        }

        static int findPattern(TNode root, String word, int count)
        {
            Console.WriteLine("finding pattern-{0}", word);
            TNode curr = root;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (c=='*')
                {
                    return findInsubtree(curr, word.Substring(i + 1),count);
                }
                else if (c=='?')
                {


                }
                else
                {
                    TNode next = null;

                    if (curr.children.TryGetValue(c, out next))
                    {
                        curr = next;

                    }
                    else
                    {
                        return count+0;
                    }
                }
                
            }
            if (curr.isEnd)
            {
                return count+1;
            }
            else
            {
                return count+0;
            }
        }

        private static int findInsubtree(TNode root, string v, int count)
        {
            Console.WriteLine("finding-{0}", v);
            Queue<TNode> q = new Queue<TNode>();
            q.Enqueue(root);
            while(q.Count!=0)
            {
                var cur = q.Dequeue();
                int found=findPattern(cur, v, count);
                Console.WriteLine("found {0}-{1}", v,found);
                count = count + found;
                if (found<1)
                {
                    foreach(var child in cur.children)
                    {
                        q.Enqueue(child.Value);
                    }
                }

            }
            return count;
        }

        private static void checkBSTstub()
        {
            Node a = new Node();
            a.data = 35;

            Node b = new Node();
            b.data = 20;

            Node c = new Node();
            c.data = 34;

            Node d = new Node();
            d.data = 45;

            a.left = b;
            a.right = d;

            b.right = c;
            Console.WriteLine(checkBST(a));


        }

        class Node
        {
            public int data;
            public Node left;
            public Node right;
        }
        static bool checkBST(Node root)
        {
            if (root.left == null && root.right == null)
            {
                return true;
            }
            bool isleft = false;
            if (root.left != null)
            {
                Node inorderSuccessor = root.left;
                while (inorderSuccessor.right != null)
                    inorderSuccessor = inorderSuccessor.right;

                isleft = checkBST(root.left) && (root.data > inorderSuccessor.data);
            }
            else
            {
                isleft = true;
            }

            bool isright = false;
            if (root.right != null)
            {
                Node inorderSuccessor = root.right;
                while (inorderSuccessor.left != null)
                    inorderSuccessor = inorderSuccessor.left;

                isright = checkBST(root.right) && (root.data < inorderSuccessor.data);
            }
            else
            {
                isright = true;
            }
            return (isleft && isright);
        }

        private static void commonElementsSortedArray()
        {
            int[] A = new int[] { };
            int[] B = new int[] { };
            List<int> commonElements = new List<int>();
            int j = 0;
            for (int i=0; i<A.Length;i++)
            {
                
                while(j<B.Length && B[j]<=A[i] )
                {
                    j++;
                }
                if (B[j] == A[i])
                {
                    commonElements.Add(A[i]);
                    continue;
                }
            }
        }

       
        static string[] reformatDate(string[] dates)
        {
            int n = dates.Length;


            List<string> result = new List<string>();

            if (n == 0)
            {
                return result.ToArray();
            }
            Dictionary<string, string> monthMap = new Dictionary<string, string>();
            monthMap.Add("Jan", "01");
            monthMap.Add("Feb", "02");
            monthMap.Add("Mar", "03");
            monthMap.Add("Apr", "04");
            monthMap.Add("May", "05");
            monthMap.Add("Jun", "06");
            monthMap.Add("Jul", "07");
            monthMap.Add("Aug", "08");
            monthMap.Add("Sep", "09");
            monthMap.Add("Oct", "10");
            monthMap.Add("Nov", "11");
            monthMap.Add("Dec", "12");


            for (int i = 1; i <= n; i++)
            {
                string[] date = dates[i].Trim().Split(' ');

                string year = date[2];
                string month = monthMap[date[1]];
                int len = date[0].Length;
                string day = date[0].Substring(0, len - 2);
                if (day.Length < 2)
                {
                    day = "0" + day;
                }
                result.Add(year + "-" + month + "-" + day);

            }
            return result.ToArray();
        }


        private static void jumpGame()
        {
            int[] jumpa = new int[] { 2, 3, 1, 1, 4 };
            int n = jumpa.Length;
            var ptr = n - 1;
            for (int i = n-2; i>=0; i--)
            {
                if (jumpa[i] >= ptr-i)
                { ptr = i; }
            }
            if (ptr == 0)
            { Console.WriteLine(true); }
            else Console.WriteLine(false);

        }

        public class Interval : IComparable<Interval>,IEquatable<Interval>
        {
            public  int start;
            public  int end;

            public  Interval(int s, int e)
            {
                start = s;
                end = e;

            }

            public  int CompareTo(Interval other)
            {
                return this.start.CompareTo(other.start);
            }

            public  bool Equals(Interval other)
            {
                return this.start.Equals(other.start);
            }
        }

        private static void mergeIntervals()
        {
            List<Interval> intervals = new List<Interval>();

            Interval i = new Interval(1, 3);
            intervals.Add(i);

            i = new Interval(15, 18);
            intervals.Add(i);

            i = new Interval(2,6);
            intervals.Add(i);

            i = new Interval(8,10);
            intervals.Add(i);
            

            i = new Interval(4,6);
            intervals.Add(i);

            List<Interval> mergedInterval = new List<Interval>();

            intervals.Sort();

            foreach(Interval a in intervals)
            {
                Console.WriteLine("{0}-{1}", a.start, a.end);
            }

            int start = intervals[0].start;
            int end = intervals[0].end;


            foreach(Interval a in intervals)
            {
                if (a.start>end)
                {
                    Interval newi = new Interval(start, end);
                    mergedInterval.Add(newi);
                    start = a.start;
                    end = a.end;
                    continue;
                }
                if(end<a.end)
                {
                    end = a.end;
                }

            }
            Interval newie = new Interval(start, end);
            mergedInterval.Add(newie);
            foreach (Interval a in mergedInterval)
            {
                Console.WriteLine("{0}-{1}", a.start, a.end);
            }
        }

        private static void wordbreak()
        {
            string s = "leetcodeishardmediumandeasy";
            List<string> dict = new List<string>();
            dict.Add("etc");
            dict.Add("leet");
            dict.Add("code");
            dict.Add("is");
            dict.Add("hard");
            dict.Add("medium");
            dict.Add("easy");
            dict.Add("le");
            dict.Add("odeishardmed");
            dict.Add("iumak");
            dict.Add("and");
            dict.Add("");
            Console.WriteLine(wordBreak(s, dict));

        }

        public static bool wordBreak(string s, List<string> dict)
        {
            for(int i=0; i< 12 && i< s.Length; i++)//12 is the length of the longest word
            {
                string word = s.Substring(0, i + 1);
                string remaining = s.Substring(i + 1, s.Length - i - 1);
                if (dict.Contains(word) && wordBreak(remaining, dict))
                {
                    Console.WriteLine(word);
                    return true;
                }
                else if (dict.Contains(word) && String.IsNullOrEmpty(remaining))
                {
                    Console.WriteLine(word);
                    return true;
                }
                else
                {
                    //Console.WriteLine("{0},{1}", word, remaining);
                }
            }
            return false;
        }

        private static void removeDuplicates()
        {
            SinglyLinkedListNoHeadNode lnklist = new SinglyLinkedListNoHeadNode();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            lnklist.AddAtLast(1);
            lnklist.AddAtLast(1);
            lnklist.AddAtLast(1);
            lnklist.AddAtLast(1);
            lnklist.AddAtLast(4);
            lnklist.AddAtLast(4);
            lnklist.AddAtLast(4);
            lnklist.AddAtLast(5);
            lnklist.AddAtLast(6);
            lnklist.AddAtLast(6);
            lnklist.AddAtLast(8);
            lnklist.AddAtLast(9);
            lnklist.AddAtLast(9);
            lnklist.AddAtLast(9);
            Console.WriteLine();
            lnklist.PrintAllNodes();
            lnklist.RemoveDups();
            lnklist.PrintAllNodes();







        }

        public class ListNode
        {
      public int val;
      public ListNode next;
      public ListNode(int x) { val = x; }
  }

        private static void summaryRanges()
        {
            //int[] a = new int[] { 0, 1, 2, 4, 5 ,7,8};
            //int[] a = new int[] { 0, 1, 2, 4, 5, 7, 9};
            //int[] a = new int[] { 0};
            int[] a = new int[] { };
            int start = 0;
            int end = start + 1;

            while(start<a.Length)
            {
                while (end < a.Length && a[end] == (a[end - 1] + 1))
                {
                    end++;
                }
                if (start==end-1)
                {
                    Console.WriteLine("{0},", a[start]);
                }
                else
                {
                    Console.WriteLine("{0} ->{1},", a[start], a[end - 1]);
                }
                

                start = end;
                end = end + 1;
            }

            
        }

        private static void basicCalculator()
        {
            Stack<string> s = new Stack<string>();
            var exp = "3+2-5*2/10+5";
            int i = 0;
            while(i < exp.Length)
            {
                int j = 0;
                while (j<exp.Length)
                {
                    if ((exp[j] != '+' && exp[j] != '-' && exp[j] != '/' && exp[j] != '*'))
                        j++;
                    else break;
                }
                string number = exp.Substring(i, j);

                s.Push(number);

                if (j+1 < exp.Length && (exp[j+1]=='+' || exp[j+1]=='-'))
                {
                    s.Push(exp[j + 1].ToString());
                    i = j + 2;
                    j = i;
                }
                else if(j+1 < exp.Length)
                {
                    char operation = exp[j+1];
                    int num1 = int.Parse(s.Pop());
                    i = j + 2;
                    j = i;
                    while (exp[j] != '+' || exp[j] != '-' || exp[j] != '/' || exp[j] != '*')
                    {
                        j++;
                    }
                    int num2 = int.Parse(exp.Substring(i, j));

                    if (operation=='*')
                    {
                        s.Push((num1 * num2).ToString());
                    }
                    else
                    {
                        s.Push((num1 / num2).ToString());
                    }
                    i = j + 2;
                    j = i;

                }


            }
            int stack = s.Count;
        }

        private static void nextPermutation()
        {
            //int[] a = new int[] { 1, 2, 3, 4, 5 };
            int[] a = new int[] { 5, 4, 3, 2, 1 };
            int n = a.Length;
            int i = n - 1;
            while(i>0 && a[i] < a[i - 1])
            {
               i--;
            }
            if (i==0)
            {
                Array.Sort(a);
                Display(a);
                return;
            }

            int pivot = i - 1;
            int closestindex = pivot + 1;
            int j= pivot + 1;
            while (j<=0)
            {
                if ((a[j] - a[pivot]) < (a[closestindex] - a[pivot]))
                    closestindex = j;
                j++;
            }

            int temp = a[pivot];
            a[pivot] = a[closestindex];
            a[closestindex] = temp;

            reverse(a, pivot + 1, n - 1);
            Display(a);

        }

        private static void reverse(int[] a, int start, int end)
        {
            int i = start;
            int j = end;
            while(i<j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                i++;
                j--;
            }
        }

        private static void Display(int[] a)
        {
            for (int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void matrixSize()
        {
            int[,] matrix = new int[4, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = i * 3 + j;
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.ReadKey();
        }

        private static void numberOfLeaves()
        {
            Tree tree = new Tree();
            tree.root = new TreeNode(1);
            tree.root.left = new TreeNode(2);
            tree.root.right = new TreeNode(3);
            tree.root.left.left = new TreeNode(4);
            tree.root.left.right = new TreeNode(5);
            Console.WriteLine(tree.getLeafCount());
        }

        private static void infixTopostfix()
        {
            var exp = "A+(B-C)*D";
            InfixPostFixExpression converter= new InfixPostFixExpression();
            string postfix=converter.InfixTOPostfix(exp);
            Console.WriteLine(postfix);

        }

        private static void stackWithArray()
        {
            SinglyLinkedListNoHeadNode lnklist = new SinglyLinkedListNoHeadNode();
            lnklist.PrintAllNodes();
            Console.WriteLine();

        }

        private static void findBiggestBlock()
        {
            bool[,] matrix = { { true, true, false, false, false }, 
                               { false, true, true, false, true }, 
                               { false, false, false, true, true }, 
                               { true, false, false, true, true }, 
                               { false, true, false, true, true } };
            int size = findBiggestBlockMatrix(matrix);
            Console.WriteLine(size);
        }

        private static int findBiggestBlockMatrix(bool[,] matrix)
        {
            var blocksize = 0;
            var biggesstBlock = 0;
            bool[, ] countm = { { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false }, { false, false, false, false, false } };

            for (int i =0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    if (matrix[i,j] && !countm[i,j])
                    {
                        computeAreaAround(matrix, i, j,ref countm,ref blocksize);
                        biggesstBlock = biggesstBlock > blocksize ? biggesstBlock : blocksize;
                        blocksize = 0;
                    }
                        
                            
                }
            }
            return biggesstBlock;
        }

        private static void computeAreaAround(bool[,] matrix, int i, int j,ref bool[,] countm,ref int size)
        {
            size++;
            countm[i,j] = true;
            Tuple<int, int>[] neighbors = { new Tuple<int, int>(- 1, -1),
                new Tuple<int, int>(0, -1),new Tuple<int, int>(1, -1),new Tuple<int, int>(- 1, 0),
                new Tuple<int, int>(1, 0),new Tuple<int, int>(- 1, 1),new Tuple<int, int>(0, 1),
                new Tuple<int, int>(1, 1) };
            foreach(var co in neighbors)
            {
                var neighborX = i + co.Item1;
                var neighborY = j + co.Item2;
                var Explored = isExplored(neighborX, neighborY,countm);
                var Area = isArea(neighborX, neighborY,matrix);
                if (!Explored && Area)
                {
                    computeAreaAround(matrix, neighborX, neighborY,ref countm,ref size);
                }

            }
        }

        private static bool isArea(int neighborX, int neighborY, bool[,] matrix)
        {
            if (neighborX < 0 || neighborX >=5 || neighborY < 0  || neighborY>=5)
            {
                return false;
            }
            return matrix[neighborX, neighborY];
        }

        private static bool isExplored(int neighborX, int neighborY, bool[,] countm)
        {
            if (neighborX < 0 || neighborX >= 5 || neighborY < 0 || neighborY >= 5)
            {
                return true;
            }
            return countm[neighborX, neighborY];
        }

        private static void isSorted()
        {
            int[] array = {  30,0 };
            bool issorted = isSortedRecurssive(array, array.Length);
            Console.WriteLine(issorted);
            Console.ReadKey();
        }

        private static bool isSortedRecurssive(int[] array, int sortLength)
        {
            if (sortLength == 1)
                return true;
            if (isSortedRecurssive(array, sortLength - 1))
            {
                if (array[sortLength-1] > array[sortLength - 2])
                {
                    return true;
                }
            }
                return false;


        }

        public static void  linkedlist()
         {
            SinglyLinkedListNoHeadNode lnklist = new SinglyLinkedListNoHeadNode();
            lnklist.PrintAllNodes();
            Console.WriteLine();

            //lnklist.AddAtLast(12);
            //lnklist.AddAtLast("John");
            //lnklist.AddAtLast("Peter");
            //lnklist.AddAtLast(34);
            //lnklist.PrintAllNodes();
            //Console.WriteLine();

            //lnklist.reverse();
            //lnklist.PrintAllNodes();
            //Console.WriteLine();
            //lnklist.AddAtFirst(55);
            //lnklist.PrintAllNodes();
            //Console.WriteLine();

            //lnklist.InsertAtPosition(33333, 5);

            lnklist.AddAtLast(1);
            lnklist.AddAtLast(2);
            lnklist.AddAtLast(3);
            lnklist.AddAtLast(4);
            lnklist.AddAtLast(5);
            lnklist.AddAtLast(6);
            lnklist.AddAtLast(7);
            lnklist.AddAtLast(8);
            lnklist.AddAtLast(9);
            Console.WriteLine();
            lnklist.reverseInBlocks();

            //lnklist.RemoveFromStart();
            lnklist.PrintAllNodes();

            Console.ReadKey();
        }

        
    }
}
//string[] a = new string[2]{
//    "20th Aug 2345","23th Jan 1289" };
//string[] b = reformatDate(a);
//1) Given a directory, convert names of all files and subdirectories recursively to upper case names
//2) Reverse a string
//3) Reverse a linked list (singly)
//4) Maximum subsequence problem


////            SELECT column-names
////  FROM table-name
//// WHERE condition
//// GROUP BY column - names
////HAVING condition

////Select WEATHER.WEATHER_TYPE,  PLANTS.PLANT_SPECIES
////FROM PLANTS
////INNER JOIN WEATHER AS W ON P.PLANT_SPECIES = W.PLANT_SPECIES
////WHERE P.PLANT_SPECIES IN
////{
////                Select P.PLANT_SPECIES
////                FROM PLANTS AS P
////                INNER JOIN WEATHER AS W ON P.PLANT_SPECIES = W.PLANT_SPECIES
////GROUP BY P.PLANT_SPECIES
////HAVING COUNT(P.PLANT_SPECIES) = 1};


