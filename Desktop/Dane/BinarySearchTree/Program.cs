using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST();
            Node A = new Node();
            Node B = new Node();
            Node C = new Node();
            Node D = new Node();
            Node E = new Node();
            Node F = new Node();

            tree.Insert(A, 9);
            tree.Insert(B, 7);
            tree.Insert(C, 10);
            tree.Insert(D, 6);
            tree.Insert(E, 11);
            tree.Insert(F, 1);


            tree.PrintTree(A);
            

        }
    }
}
