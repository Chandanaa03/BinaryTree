using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //tree Tree = new tree();
            //Tree.Add(56);
            //Tree.Add(30);
            //Tree.Add(70);
            


            //Tree.TraversePreorder(Tree.Root);
            BinaryTree tree = new BinaryTree();
            tree.root = new Node(56);
            tree.root.left = new Node(30);
            tree.root.right = new Node(70);
            tree.root.left.left = new Node(22);
            tree.root.left.right = new Node(40);
            tree.root.right.left = new Node(60);
            tree.root.right.right = new Node(95);
            tree.root.right.right.left = new Node(65);
            tree.root.right.right.left.right = new Node(63);
            tree.root.right.right.left.left = new Node(67);
            tree.root.left.left.left = new Node(11);
            tree.root.left.left.left.left = new Node(3);
            tree.root.left.left.left.right = new Node(16);




            Console.WriteLine("The size of binary tree is : " + tree.size());
        }
    }
}