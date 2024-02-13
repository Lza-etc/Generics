using Generics;
using System;

class Program
{
    static void DisplayMenu()
    {
        Console.WriteLine("\nGeneric Stack Operations");
        Console.Write("1.Push");
        Console.Write("    2.Pop");
        Console.Write("    3.Peek");
        Console.Write("    4.IsEmpty");
        Console.WriteLine("   5.Exit");
    }
    static void Main()
    {
        Console.Write("Enter the stack size: ");
        int size=Convert.ToInt32(Console.ReadLine());
        GenericStack<int> stack = new(size);
        char choice;
        do
        {
            DisplayMenu();
            Console.Write("Enter your choice: ");
            choice = Console.ReadKey().KeyChar;
            Console.WriteLine();

            try
            {
                switch (choice)
                {
                    case '1':
                        Console.Write("Enter the item: ");
                        if (int.TryParse(Console.ReadLine(), out int item))
                        {
                            stack.Push(item);
                        }
                        break;
                    case '2':
                        if (!stack.IsEmpty())
                        {
                            stack.Pop();
                            Console.WriteLine("Top element deleted");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty. No top element.");
                        }
                        break;
                    case '3':
                        if (!stack.IsEmpty())
                        {
                            int topElement = stack.Peek();
                            Console.WriteLine($"Top element in stack is: {topElement}");
                        }
                        else
                        {
                            Console.WriteLine("Stack is empty. No top element.");
                        }
                        break;
                    case '4':
                        Console.WriteLine($"The stack is empty: {stack.IsEmpty()}");
                        break;
                    case '5':
                        Console.WriteLine("Exited successfully");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"{e.Message}");
            }

        } while (choice != '5');
    }
}
