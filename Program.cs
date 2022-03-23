using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            tree Tree = new tree();
            Tree.Add(56);
            Tree.Add(30);
            Tree.Add(70);
            

            Tree.TraversePreorder(Tree.Root);

        }
    }
}