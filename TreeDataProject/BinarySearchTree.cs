using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDataProject
{
    class Node
    {
        public int Value;
        public Node Left;
        public Node Right;

        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    class BinarySearchTree
    {
        public Node Root;

        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }

        private Node InsertRec(Node root, int value)
        {
            if (root == null)
            {
                return new Node(value);
            }

            if (value < root.Value)
                root.Left = InsertRec(root.Left, value);
            else if (value > root.Value)
                root.Right = InsertRec(root.Right, value);

            return root;
        }

        public bool Search(int value)
        {
            return SearchRec(Root, value);
        }

        private bool SearchRec(Node root, int value)
        {
            if (root == null)
                return false;

            if (root.Value == value)
                return true;

            if (value < root.Value)
                return SearchRec(root.Left, value);

            return SearchRec(root.Right, value);
        }

        public void InOrderTraversal()
        {
            InOrderRec(Root);
            Console.WriteLine();
        }

        private void InOrderRec(Node root)
        {
            if (root != null)
            {
                InOrderRec(root.Left);
                Console.Write(root.Value + " ");
                InOrderRec(root.Right);
            }
        }
    }

}
