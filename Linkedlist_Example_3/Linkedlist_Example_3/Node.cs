using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedlist_Example_3
{
    class Node
    {
        public int data;
        public Node next;
        public Node back;

        public Node(int data)
        {
            this.data = data;
            next = null;
            back = null;
        }
    }
}
