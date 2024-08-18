using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {  // Initializes an empty binary search tree
        public BSTree()
        {
            root = null;
        }

        // Inserts an item into the binary search tree
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        // Recursively inserts an item into the correct position in the tree
        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null) // Checks if the tree is null
                tree = new Node<T>(item); // Creates a new node

            else if (item.CompareTo(tree.Data) < 0) // Compares item with current node data
                insertItem(item, ref tree.Left); // Inserts item in the left subtree

            else if (item.CompareTo(tree.Data) > 0) // Compares item with current node data
                insertItem(item, ref tree.Right); // Inserts item in the right subtree
        }

    }
}