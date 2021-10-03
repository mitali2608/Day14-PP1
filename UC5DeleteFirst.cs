using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_PP1
{
    class UC5DeleteFirst
    {
        internal UC1Node head;

        internal void AddToFront(int data)           //UC2 - Adding data to the list
        {
            UC1Node UC1Node = new UC1Node(data);
            UC1Node.next = head;
            head = UC1Node;

            Console.WriteLine("{0} inserted into the linked list", UC1Node.data);
        }

        internal void AddToEnd(int data)        //UC3 Appending data to list
        {

            UC1Node UC1Node = new UC1Node(data);

            if (this.head == null)

                this.head = UC1Node;

            else
            {
                UC1Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = UC1Node;
            }
            Console.WriteLine("{0} inserted into the linked list", UC1Node.data);

        }


        internal UC1Node AddInBet(int position, int data)  //UC4 Adding data in between
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newUC1Node = new UC1Node(data);
                newUC1Node.next = this.head;
                head = newUC1Node;
            }
            else
            {
                UC1Node temp = this.head;
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        UC1Node UC1Node = new UC1Node(data);
                        UC1Node.next = this.head.next;
                        head.next = UC1Node;
                        break;

                    }
                    temp = temp.next;

                }

                if (position != 1)
                    Console.WriteLine("Position Not in a range");

            }
            return head;
        }


        internal UC1Node PopFirst()   
        {
            if (this.head == null)

                return null;
            this.head = this.head.next;
            return this.head;

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
