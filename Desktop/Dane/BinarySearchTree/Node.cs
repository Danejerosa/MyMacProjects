using System;
namespace BinarySearchTree
{
    public class Node
    {
        private Node left;
        private Node right;
        private int data;

        public Node Left
        {
            get { return left; }
            set { left = value; }
        }

        public Node Right
        {
            get { return right; }
            set { right = value; }
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node()
        {
        }
    }
}
