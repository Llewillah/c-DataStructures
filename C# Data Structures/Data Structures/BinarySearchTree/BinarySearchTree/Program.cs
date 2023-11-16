using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BSTree<int> bSTree = new BSTree<int>();
            BSTree<int> bsTree = new BSTree<int>();

            bSTree.InsertItem(10);
            bSTree.InsertItem(20);
            bSTree.InsertItem(8);
            bSTree.InsertItem(9);
            bSTree.InsertItem(12);
            bSTree.InsertItem(52);
            bSTree.InsertItem(4);
            bSTree.InsertItem(6);
            bSTree.InsertItem(13);

            bsTree.InsertItem(10);
            bsTree.InsertItem(20);
            bsTree.InsertItem(8);
            bsTree.InsertItem(9);
            bsTree.InsertItem(12);
            bsTree.InsertItem(52);
            bsTree.InsertItem(4);
            bsTree.InsertItem(6);

            string buffer = "";
            bSTree.InOrder(ref buffer);

            Console.WriteLine(bSTree.Height(bSTree.GetRoot()));
            Console.WriteLine(bSTree.Count(bSTree.GetRoot()));
            Console.WriteLine(bSTree.Contains(5, bSTree.GetRoot()));
            Console.WriteLine(bSTree.Equals(bsTree));
            Console.ReadKey();
        }
    }
}
