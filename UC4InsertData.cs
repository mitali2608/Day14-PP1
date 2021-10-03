﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_PP1
{
    class UC4InsertData
    {
        internal UC1Node head;

        internal void AddToFront(int data)
        {
            UC1Node UC1Node = new UC1Node(data);
            UC1Node.next = head;
            head = UC1Node;

            Console.WriteLine("{0} inserted into the linked list", UC1Node.data);
        }

        internal void AddToEnd(int data)
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


        internal UC1Node AddInBet(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
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
                    Console.WriteLine("Position out of range");

            }
            return head;
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
