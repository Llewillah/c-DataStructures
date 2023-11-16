using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGen
{
    class NodeGen<T>
    {
        private T data;
        private NodeGen<T> next;

        public NodeGen(T item)
        {
            Data = item;
            Next = null;
        }
        public NodeGen<T> Next
        {
            set { this.next = value; }
            get { return next; }
        }

        public T Data
        {
            set { this.data = value; }
            get { return data; }
        }
    }

}
