using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_A;

namespace Task_B
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool finished = false;
            BSTree<string> wordTree = new BSTree<string>();
            do
            {
                Console.WriteLine("Press ENTER");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("1. Insert a Word");
                Console.WriteLine("2. Display Tree");
                Console.WriteLine("3. Display Height");
                Console.WriteLine("4. Display the total number of words present in the tree");
                Console.WriteLine("5. Check Word");
                Console.WriteLine("6. Exit");
                Console.WriteLine("\n Choose a function");

                string option = Console.ReadLine();
                int items = 0;

                switch (option)
                {

                    case "1":
                        Console.WriteLine("Please insert a word:");
                        wordTree.InsertItem(Console.ReadLine());
                        break;
                    case "2":
                        traversal();
                        break;
                    case "3":
                        Console.WriteLine("Height of the Tree: {0}", wordTree.Height());
                        break;
                    case "4":
                        wordTree.Count(ref items);
                        Console.WriteLine("Number of items in the Tree: {0}", items);
                        break;
                    case "5":
                        Console.WriteLine("Which word would you like to check?");
                        string check = Console.ReadLine();
                        wordTree.Contains(ref check);
                        Console.WriteLine(wordTree.Contains(ref check));
                        break;
                    case "6":
                        finished = true;
                        break;
                }
            } while (!finished);
            void traversal()
            {
                Console.WriteLine("1. in-order");
                Console.WriteLine("2. post-order");
                Console.WriteLine("3. pre-order");
                Console.WriteLine("\nChoose a tree traversal method:");

                string buffer = "";
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        wordTree.InOrder(ref buffer);
                        Console.WriteLine(buffer);
                        break;
                    case "2":
                        wordTree.PostOrder(ref buffer);
                        Console.WriteLine(buffer);
                        break;
                    case "3":
                        wordTree.PreOrder(ref buffer);
                        Console.WriteLine(buffer);
                        break;
                }
            }
        }

    }
}
