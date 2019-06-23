using System;


namespace Fun
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Node Filler = new Node(7);
            SinglyLinkedList newList = new SinglyLinkedList();
            Node Filler1 = new Node(8);
            Node Filler2 = new Node(7);
            Node Filler3 = new Node(22);
            Node Filler4 = new Node(1);
            Node Filler5 = new Node(13);


            newList.InsertFront(newList, Filler.Data);
            newList.InsertFront(newList, Filler1.Data);
            newList.InsertFront(newList, Filler2.Data);
            newList.InsertFront(newList, Filler3.Data);
            newList.InsertFront(newList, Filler4.Data);
            newList.InsertFront(newList, Filler5.Data);


            newList.PrintList(newList);




            

        }
    }
}
