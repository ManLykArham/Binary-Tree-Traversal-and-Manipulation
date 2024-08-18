using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class BinTree<T> where T : IComparable
    {
        // Declares the root of the tree, protected so it can be accessed by child classes
        protected Node<T> root;

        // Initializes an empty binary tree
        public BinTree()
        {
            root = null;
        }

        // Initializes a binary tree with a given node as the root
        public BinTree(Node<T> node)
        {
            root = node;
        }

        // Performs in-order traversal and appends the result to the buffer
        public void InOrder(ref string buffer)
        {
            inOrder(root, ref buffer);
        }

        // Recursively performs in-order traversal on the tree
        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null) // Checks if the tree is not null
            {
                inOrder(tree.Left, ref buffer); // Visits left subtree
                buffer += tree.Data.ToString() + ","; // Adds current node data to buffer
                inOrder(tree.Right, ref buffer); // Visits right subtree
            }
        }

        // Performs pre-order traversal and appends the result to the buffer
        public void PreOrder(ref string buffer)
        {
            preOrder(root, ref buffer);
        }

        // Recursively performs pre-order traversal on the tree
        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null) // Checks if the tree is not null
            {
                buffer += tree.Data.ToString() + ","; // Adds current node data to buffer
                preOrder(tree.Left, ref buffer); // Visits left subtree
                preOrder(tree.Right, ref buffer); // Visits right subtree
            }
        }

        // Performs post-order traversal and appends the result to the buffer
        public void PostOrder(ref string buffer)
        {
            postOrder(root, ref buffer);
        }

        // Recursively performs post-order traversal on the tree
        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null) // Checks if the tree is not null
            {
                postOrder(tree.Left, ref buffer); // Visits left subtree
                postOrder(tree.Right, ref buffer); // Visits right subtree
                buffer += tree.Data.ToString() + ","; // Adds current node data to buffer
            }
        }

        // Returns the height of the tree (maximum level)
        public int Height()
        {
            return height(root);
        }

        // Recursively calculates the height of the tree
        private int height(Node<T> tree)
        {
            if (tree == null) // Checks if the tree is null
                return 0;
            else
                return 1 + Math.Max(height(tree.Left), height(tree.Right)); // Calculates the height
        }

    }
}

