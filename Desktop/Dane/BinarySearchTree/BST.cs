using System;
namespace BinarySearchTree
{
    public class BST
    {
        Node root;
        public BST()
        {
        }

        public Node Insert(Node root, int val)
        {
            if(root == null)
            {
                Node new_node = new Node();
                new_node.Data = val;
                
            }
            else if(val < root.Data)
            {
                Insert(root.Left, val);
            }

            else if(val > root.Data)
            {
                Insert(root.Right, val);
            }

            return root;
        }

        public void PrintTree(Node root)
        {
            if(root == null)
            {
                return;
            }

            PrintTree(root.Left);
            Console.WriteLine(root.Data);
            PrintTree(root.Right);
        }
        
        

    }
}
