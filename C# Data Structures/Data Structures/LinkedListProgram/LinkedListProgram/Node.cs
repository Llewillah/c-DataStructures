using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{

        class Node
        {
            private int data;
            private Node next;

            public Node(int item) //constructor with an item
            {
            Data = item;
            Next = null;
            }

            public int Data //property for data
            {
                set { this.data = value; }
                get { return this.data; }
            }

            public Node Next //property for next
            {
                set { this.next = value;  }
                get { return this.next; }
            }

        }

}

