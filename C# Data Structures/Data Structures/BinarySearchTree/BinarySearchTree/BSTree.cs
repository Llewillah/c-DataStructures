using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {  //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public int Height(Node<T> tree)
        //Return the max level of the tree
        {
            if (tree == null)
            {
                return 0;
            }
            else 
            {
                return 1 + max(Height(tree.Left), Height(tree.Right));
            }

        }

        private int max(int x, int y) 
        {
            if (x > y)
            {
                return x;
            } else 
            {
                return y;
            }
        }

        public int Count(Node<T> tree)
        //Return the number of nodes in the tree
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Count(tree.Left) + Count(tree.Right);
            }
        }

        public Boolean Contains(T item, Node<T> tree)
        //Return true if the item is contained in the BSTree, false 	  //otherwise.
        {
            if (tree == null)
            {
                return false;
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                return Contains(item, tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                return Contains(item, tree.Right);
            }
            else 
            { 
                return true; 
            }
        }

        public bool Equals(BSTree<T> tree) 
        {
            if (tree == null)
            {
                return false;
            }
            else 
            {
                return equals(root, tree.GetRoot());
            }
        }

        private bool equals(Node<T> currTree, Node<T> otherTree) 
        {
            if (currTree == null && otherTree == null) 
            {
                return true;
            }else if (currTree == null || otherTree == null)
            {
                return false;   
            }

            if (currTree.Data.CompareTo(otherTree.Data) == 0)
            {
                return equals(currTree.Left, otherTree.Left) && equals(currTree.Right, otherTree.Right);
            } else 
            {
                return false;
            }
        }
  //returns true if this BSTree object contains the all same data as
  //tree with the same structure and ordering of data.


    }

}
