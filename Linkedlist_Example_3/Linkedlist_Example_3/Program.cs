using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedlist D = new DoublyLinkedlist();

            D.head = new Node(10);
            Node sec = new Node(15);
            Node thi = new Node(20);
            Node fou = new Node(20);
            Node fif = new Node(30);
            Node six = new Node(40);
            Node sev = new Node(50);
            Node eig = new Node(55);
            Node nig = new Node(60);
            Node ten = new Node(70);

            D.head.back = null; D.head.next = sec;
            sec.back = D.head; sec.next = thi;
            thi.back = sec; thi.next = fou;
            fou.back = thi; fou.next = fif;
            fif.back = fou; fif.next = six;
            six.back = fif; six.next = sev;
            sev.back = six; sev.next = eig;
            eig.back = sev; eig.next = nig;
            nig.back = eig; nig.next = ten;
            ten.back = nig; ten.next = null;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Doubly Linkedlist Is :");
            D.print(D.head);
            Console.ResetColor();
            Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.WriteLine("Enter The Number To Be Add In First :");
            //int pn = int.Parse(Console.ReadLine());
            //D.push(pn);
            //Console.WriteLine("Now Doubly Linkedlist Is :");
            //D.print(D.head);
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Red;
            //D.addafter(D.head.next.next, 100);
            //Console.WriteLine("Now Doubly Linkedlist Is [ After Add In The Fourth Place Of Doubly Linkedlist ] :");
            //D.print(D.head);
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.WriteLine("Enter The Number To Be Add In End :");
            //int en = int.Parse(Console.ReadLine());
            //D.append(en);
            //Console.WriteLine("Now Doubly Linkedlist Is :");
            //D.print(D.head);
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //D.deln(D.head.next.next);
            //Console.WriteLine("Now Doubly Linkedlist After Delete Third Node Is :");
            //D.print(D.head);
            //Console.ResetColor();
            //Console.WriteLine("\n");

            //Console.ForegroundColor = ConsoleColor.DarkMagenta;
            //D.reverse();
            //Console.WriteLine("Now Linkedlist After Reversing Is : ");
            //D.print(D.head);
            //Console.ResetColor();
            //Console.WriteLine("\n");


            Console.ReadKey();
        }
    }
}
