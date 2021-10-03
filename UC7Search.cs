﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_PP1
{
    class UC7Search
    {
        internal UC1Node head;

        //UC2 Add To list
        internal void AddToFront(int data)
        {
            UC1Node UC1Node = new UC1Node(data);
            UC1Node.next = head;
            head = UC1Node;

            Console.WriteLine("{0} inserted into the linked list", UC1Node.data);
        }

        //UC3 Appending to list
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

        //UC4 Add in between

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

        //UC5 Delete First Element

        internal UC1Node PopFirst()
        {
            if (this.head == null)

                return null;
            this.head = this.head.next;
            return this.head;

        }

        //UC6 Delete Last Element

        internal UC1Node PopLast()
        {
            if (head == null)
                return null;

            if (head.next == null)
                return null;

            UC1Node newUC1Node = head;

            while (newUC1Node.next.next != null)
            {
                newUC1Node = newUC1Node.next;
            }

            newUC1Node.next = null;
            return head;
        }

        //UC7 Search for UC1Node with data 30

        internal UC1Node SearchData(int value)
        {
            UC1Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Your element found");
                    return temp;
                    Console.WriteLine(value);
                }
                Console.WriteLine("Your element not found");
                temp = temp.next;

            }
            return null;
        }

        internal void PrintList()
        {
            UC1Node temp = head;

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
