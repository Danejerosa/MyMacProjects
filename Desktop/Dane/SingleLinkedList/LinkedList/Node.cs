using System;
namespace Fun
{
    public class Node
    {
        private Node next;
        private int data;

        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}
