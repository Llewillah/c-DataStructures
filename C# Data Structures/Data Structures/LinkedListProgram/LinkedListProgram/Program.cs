using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkList testList = new LinkList();

            testList.AddToHead(20);
            testList.AddToHead(30);


            if (testList.IsPresentItem(30))
            {
                Console.WriteLine("Item is in list, {0}", testList.DisplayItems());
            }
            else 
            {
                Console.WriteLine("Item is not in list, {0}", testList.DisplayItems());
            }

            Console.ReadKey();
        }

    }
}
