using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    public class TreeNode
    {
        public int data;
        public TreeNode left, right;

        public TreeNode(int item)
        {
            data = item;
            left = right = null;
        }
    }



    class DS
    {

        TreeNode root;

        public int MaxDepth(TreeNode node)
        {

            DS tree = new DS();


            tree.root = new TreeNode(1);
            tree.root.left = new TreeNode(2);
            tree.root.right = new TreeNode(3);
            tree.root.right.left = new TreeNode(4);
            tree.root.right.right = new TreeNode(5);


            if (node == null)
                return 0;
            else
            {
                /* compute the depth of each subtree */
                int lDepth = MaxDepth(node.left);
                int rDepth = MaxDepth(node.right);

                /* use the larger one */
                if (lDepth > rDepth)
                    return (lDepth + 1);
                else
                    return (rDepth + 1);
            }


        }

    }
}
