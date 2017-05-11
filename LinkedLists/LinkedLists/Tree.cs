using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Tree
    {
        
        public TreeNode root;

        public int getLeafCount(TreeNode node)
        {
            if (node!=null)
            {
                if (node.left==null && node.right==null)
                { return 1; }
                return getLeafCount(node.left) + getLeafCount(node.right);
            }

            return 0;
        }

        internal int getLeafCount()
        {
            return getLeafCount(root);
        }
    }
    class TreeNode
    {
        public int data;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int adata)
        {
            data = adata;
            left = right = null;
        }



    }
}
