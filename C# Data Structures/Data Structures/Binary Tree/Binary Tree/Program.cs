using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node<int> rootnode = new Node<int>(10);
            Node<int> leftchild = new Node<int>(4);
            Node<int> rightchild = new Node<int>(40);

            rootnode.Left = leftchild;
            rootnode.Right = rightchild;

            // create a BinTree with root = rootnode
            BinTree<int> mytree = new BinTree<int>(rootnode);

            string buffer = "";
            mytree.PostOrder(ref buffer);

            // display the content of the tree
            Console.WriteLine("in-order visit of BinTree " + buffer);

            Console.ReadKey();
        }
    }
}
