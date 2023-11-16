using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListGen
{
    class LinkListGen<T> where T : IComparable
    {
        private NodeGen<T> head;

        public LinkListGen()
        {
        }
        public void AddToHead(T item)
        {
            NodeGen<T> newNode = new NodeGen<T>(item);
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode.Next = head;
            head = newNode;
        }
        public string DisplayList()
        {
            NodeGen<T> temp = head;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                if (buffer.Length == 0)
                    buffer = buffer + temp.Data;
                else
                    buffer = buffer + "->" + temp.Data;
                temp = temp.Next;
            }
            return buffer;
        }
        public int NumberOfItems()
        {
            NodeGen<T> temp = head;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                temp = temp.Next;
                count++;
            }
            return count;
        }
        public bool IsPresentItem(T item)
        {
            {
                NodeGen<T> temp = head;
                while (temp != null)
                {
                    if (temp.Data.CompareTo(item) == 0) { return true; }
                    else { temp = temp.Next; }
                }

                return false;
            }
        }
        public void RemoveItem(T item)// remove occurrences of item from the list
        {
            NodeGen<T> temp = head;
            LinkListGen<T> newList = new LinkListGen<T>();

            while (temp != null) 
            {
                if (item.CompareTo(temp.Data) != 0) 
                {
                    newList.AppendItem(temp.Data);
                }
                temp = temp.Next;
            }
            
            head = newList.head;
        }

        public void AppendItem(T item) 
        {
            NodeGen<T> temp = head;
            NodeGen<T> newNode = new NodeGen<T>(item);

            if (head == null) 
            { 
                head = newNode;
                return;
            }
            while (temp.Next != null) 
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public void InsertInOrder(T item) 
        {
            NodeGen<T> temp = head;
            NodeGen<T> prevTemp = head;
            NodeGen<T> newNode = new NodeGen<T>(item);

            if (head == null)
            {
                AddToHead(item);
            }
            else 
            {
                while (temp.Next != null) 
                {
                    if (item.CompareTo(temp.Data) > 0)
                    {
                        prevTemp = temp;
                        temp = temp.Next;
                    }
                    else 
                    {
                        newNode.Next = temp;
                        prevTemp.Next = newNode;
                        temp = temp.Next;
                    }
                }
            }
        }
    }

   

}
