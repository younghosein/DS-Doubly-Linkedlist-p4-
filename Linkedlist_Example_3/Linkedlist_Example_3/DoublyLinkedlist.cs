using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Example_3
{
    class DoublyLinkedlist
    {
        public Node head;
        public void print(Node n)
        {
            Node last = null;
            Console.Write("Traversal In Normal Is : ");
            while (n != null)
            {
                Console.Write(n.data + " . ");
                last = n;
                n = n.next;
            }
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            Console.Write("Traversal In Reverse Is : ");
            while (last != null)
            {
                Console.Write(last.data + " . ");
                last = last.back;
            }
        }

        public void push(int nd)
        {
            Node nn = new Node(nd);

            nn.next = head;
            nn.back = null;

            if (head != null)
                head.back = nn;

            head = nn;
        }
        public void addafter(Node bn, int nd)
        {
            if (bn == null)
            {
                Console.WriteLine("Add nmikonam .... Be to che ?!");
                return;
            }

            Node nn = new Node(nd);

            nn.next = bn.next;

            bn.next = nn;

            nn.back = bn;

            if (nn.next != null)
            {
                nn.next.back = nn;
            }
        }
        public object delLast()
        {
            if (head.next == head)
            {
                Console.WriteLine("Empty");
                return null;
            }
            object d = head.back.data;
            head.back.back.next = head;
            head.back = head.back.back;
            return d;
        }
        public void append(int nd)
        {
            Node nn = new Node(nd);

            Node last = head;

            nn.next = null;

            if (head == null)
            {
                nn.back = null;
                head = nn;
                return;
            }

            while (last.next != null)
            {
                last = last.next;
            }

            last.next = nn;

            nn.back = last;
        }
        public void deln(Node d)
        {
            if (head == null || d == null)
            {
                return;
            }

            if (head == d)
            {
                head = d.next;
            }

            if (d.next != null)
            {
                d.next.back = d.back;
            }

            if (d.back != null)
            {
                d.back.next = d.next;
            }

            return;
        }
        public void reverse()
        {
            Node n = null;
            Node bn = head;

            while (bn != null)
            {
                n = bn.back;
                bn.back = bn.next;
                bn.next = n;
                bn = bn.back;
            }

            if (n != null)
            {
                head = n.back;
            }
        }
    }
}
