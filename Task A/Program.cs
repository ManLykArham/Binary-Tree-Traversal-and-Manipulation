using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializes a boolean flag to control the loop
            bool finished = false;
            // Creates an instance of the Binary Search Tree (BST) to store strings
            BSTree<string> wordTree = new BSTree<string>();

            // Begins a loop that will run until the user chooses to exit
            do
            {
                // Prompts the user to press ENTER and waits for input
                Console.WriteLine("Press ENTER");
                Console.ReadKey(); // Waits for the user to press a key
                Console.Clear(); // Clears the console

                // Displays the menu options to the user
                Console.WriteLine("1. Insert a Word");
                Console.WriteLine("2. Display Tree");
                Console.WriteLine("3. Display Height");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\n Choose a function");

                // Reads the user's choice
                string option = Console.ReadLine();

                // Executes the corresponding function based on the user's choice
                switch (option)
                {
                    // Inserts a word into the BST
                    case "1":
                        Console.WriteLine("Please insert a word:");
                        wordTree.InsertItem(Console.ReadLine());
                        break;

                    // Calls the traversal method to display the tree in a selected order
                    case "2":
                        traversal();
                        break;

                    // Displays the height of the BST
                    case "3":
                        Console.WriteLine("Height of the Tree: {0}", wordTree.Height());
                        break;

                    // Sets the finished flag to true, exiting the loop
                    case "4":
                        finished = true;
                        break;
                }
            } while (!finished); // Continues looping until finished is true

            // Defines the traversal method to display the tree
            void traversal()
            {
                // Displays the traversal options to the user
                Console.WriteLine("1. in-order");
                Console.WriteLine("2. post-order");
                Console.WriteLine("3. pre-order");
                Console.WriteLine("\nChoose a tree traversal method:");

                string buffer = ""; // Initializes an empty buffer to store the traversal result
                string option = Console.ReadLine(); // Reads the user's choice of traversal

                // Executes the corresponding traversal method based on the user's choice
                switch (option)
                {
                    // Performs in-order traversal
                    case "1":
                        wordTree.InOrder(ref buffer);
                        Console.WriteLine(buffer);
                        break;

                    // Performs post-order traversal
                    case "2":
                        wordTree.PostOrder(ref buffer);
                        Console.WriteLine(buffer);
                        break;

                    // Performs pre-order traversal
                    case "3":
                        wordTree.PreOrder(ref buffer);
                        Console.WriteLine(buffer);
                        break;
                }
            }
        }
    }
}
