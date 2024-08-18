using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Node<T> where T : IComparable
    {
        // Holds the data of the node
        private T data;

        // Holds references to the left and right child nodes
        public Node<T> Left, Right;

        // Initializes a node with a given item and sets child nodes to null
        public Node(T item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        // Gets or sets the data of the node
        public T Data
        {
            set { data = value; }
            get { return data; }
        }

    }
}
