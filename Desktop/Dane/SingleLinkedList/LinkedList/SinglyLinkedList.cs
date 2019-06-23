using System;
namespace Fun
{
    public class SinglyLinkedList
    {
        public Node head;
        public SinglyLinkedList()
        {
           
        }


        public void PrintList(SinglyLinkedList List)
        {
            Node temp = List.head;
            while(temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }

        }


        public void InsertFront(SinglyLinkedList List, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.Next = List.head;
            List.head = new_node;
        }


       
        


    }
}
