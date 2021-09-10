using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProject
{
    class LinkedList
    {
        private Node head;
        public int CountOfMembers { get; private set; } = 0;

        private Node Create(int data)
        {
            CountOfMembers++;
            return new Node(data);
        }


        public LinkedList(int data)
        {
            head = Create(data);
        }

        public void AddToEnd(int data)
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = Create(data);
        }

        public void AddFirst(int data)
        {
            Node temp = head;
            head = Create(data);
            head.next = temp;
        }

        public void Insert(int data, int position)
        {
            Node temp = head;
            while (position-- != 0)
            {
                if (position == 1)
                {
                    Node newNode = Create(data);
                    newNode.next = temp.next;
                    temp.next = newNode;
                }
                temp = temp.next;
            }
        }


        public void PrintList()
        {
            Node temp = head;

            while (temp.next != null)
            {
                Console.Write($"{temp.data} -> ");
                temp = temp.next;
            }
            Console.Write($"{temp.data} -> \n");
        }

    }
}
