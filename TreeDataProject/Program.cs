using System;
using TreeDataProject;

class Program
{
    static void Main()
    {
        BinarySearchTree tree = new BinarySearchTree();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nBinary Search Tree Menu:");
            Console.WriteLine("1. Add element");
            Console.WriteLine("2. Search element");
            Console.WriteLine("3. Traverse tree (Inorder)");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter value to add: ");
                    int addValue = int.Parse(Console.ReadLine());
                    tree.Insert(addValue);
                    Console.WriteLine("Value added.");
                    break;

                case "2":
                    Console.Write("Enter value to search: ");
                    int searchValue = int.Parse(Console.ReadLine());
                    bool found = tree.Search(searchValue);
                    Console.WriteLine(found ? "Value found." : "Value not found.");
                    break;

                case "3":
                    Console.Write("Tree traversal: ");
                    tree.InOrderTraversal();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
