using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node
    {
        //public Node LeftNode { get; set; }
        //public Node RightNode { get; set; }
        //public int data { get; set; }
        public int data;
        public Node left, right;

        public Node(int item)
        {
            data = item;
            left = right = null;
        }
    }
    public class BinaryTree
    {
        public Node root;

        public virtual int size()
        {
            return size(root);
        }
        public virtual int size(Node node)
        {
            if (node == null)
            {
                return 0;
            }
            else
            {
                return (size(node.left) + 1 + size(node.right));
            }
        }

    }
    
}
