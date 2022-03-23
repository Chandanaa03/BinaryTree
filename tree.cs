using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class tree
    {
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = Root;
            while (after != null)
            {
                before = after;
                if (value < after.data)
                    after = after.left;
                else if (value > after.data)
                    after = after.right;
                else
                {
                    return false;
                }
            }

            Node newNode = new Node(56);
            newNode.data = value;

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.data)
                    before.left = newNode;
                else
                    before.right = newNode;
            }
            return true;

        }
        public void TraversePreorder(Node Parent)
        {

            if (Parent != null)
            {
                Console.WriteLine(Parent.data + " ");
                TraversePreorder(Parent.left);
                TraversePreorder(Parent.right);

            }

        }
    }
}
