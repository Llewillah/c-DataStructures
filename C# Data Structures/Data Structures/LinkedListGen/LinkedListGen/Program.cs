using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkListGen<string> testList = new LinkListGen<string>();

            testList.AppendItem("Apple: Genesis");
            testList.AppendItem("Pizza: The Founding");
            testList.AppendItem("Zebra: the history");

            testList.InsertInOrder("GOAT: John");
            testList.InsertInOrder("Lacking: The guide to success");



            Console.WriteLine("Item is in list, {0}", testList.DisplayList());

            Console.ReadKey();
        }
    }
}
