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
                    after = after.LeftNode;
                else if (value > after.data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.data = value;
            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }
            return true;

        }
        public void TraversePreorder(Node Parent)
        {

            if (Parent != null)
            {
                Console.WriteLine(Parent.data + " ");
                TraversePreorder(Parent.LeftNode);
                TraversePreorder(Parent.RightNode);

            }

        }
    }
}
