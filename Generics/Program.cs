using Generics;
using System;

class Program
{
    static void Main()
    {
        GenericStack<int> stack = new();
        char choice;

        do
        {
            Console.WriteLine("Generic Stack Operations");
            Console.WriteLine("1.Push");
            Console.WriteLine("2.Pop");
            Console.WriteLine("3.Peek");
            Console.WriteLine("4.IsEmpty");
            Console.WriteLine("5.Exit");
            Console.WriteLine("Enter your choice");
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
