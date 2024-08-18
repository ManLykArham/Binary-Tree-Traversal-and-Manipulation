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
        // Public method to count the number of items in the BSTree
        public void Count(ref int Items)
        {
            count(root, ref Items); // Calls the private method to count the items
        }

        // Private method to recursively count the items in the BSTree
        private void count(Node<T> tree, ref int Items)
        {
            if (tree != null) // Checks if the current node is not null
            {
                count(tree.Left, ref Items); // Recursively counts the items in the left subtree
                Items = Items + 1; // Increments the count for the current node
                count(tree.Right, ref Items); // Recursively counts the items in the right subtree
            }
        }

        // Public method to check if an item is contained in the BSTree
        public Boolean Contains(ref T item)
        {
            return contains(root, ref item); // Calls the private method to check for the item
        }

        // Private method to recursively check if an item is contained in the BSTree
        private Boolean contains(Node<T> tree, ref T item)
        {
            if (tree != null) // Checks if the current node is not null
            {
                if (item.CompareTo(tree.Data) == 0) // Compares the item with the current node's data
                {
                    return true; // Returns true if the item is found
                }
                else if (item.CompareTo(tree.Data) < 0) // Checks if the item is less than the current node's data
                {
                    return contains(tree.Left, ref item); // Recursively checks in the left subtree
                }
                else if (item.CompareTo(tree.Data) > 0) // Checks if the item is greater than the current node's data
                {
                    return contains(tree.Right, ref item); // Recursively checks in the right subtree
                }
            }
            return false; // Returns false if the item is not found
        }

    }
}