using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_PP1
{
    class UC2AddData
    {
        internal UC1Node head;

        internal void AddToFront(int data)   //UC2 - Adding data to the list
        {
            UC1Node UC1Node = new UC1Node(data);
            UC1Node.next = head;
            head = UC1Node;

            Console.WriteLine("{0} inserted into the linked list", UC1Node.data);
        }

        internal void PrintList()
        {
            UC1Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }


            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
