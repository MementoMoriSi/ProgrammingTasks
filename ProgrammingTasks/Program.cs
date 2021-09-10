using System;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(1);
            while (true)
            {
                Console.Write("\nPress P - print the list " +
                                "\nL - add last " +
                                "\nF - add First " +
                                "\nI - insert to any position " + 
                                "\nand other key to quit: \n");
                char key = Char.ToUpper(Console.ReadKey(true).KeyChar);
                switch (key)
                {
                    case 'P':
                        list.PrintList(); break;
                    case 'L': 
                        EnterANumber(list, 'L'); break;
                    case 'F':
                        EnterANumber(list, 'F'); break;
                    case 'I':
                        EnterANumber(list, 'I'); break;

                    default: return;     
                }
            }

            static void EnterANumber(LinkedList list, char key)
            {
                Console.Write("\nPlease enter the number you want to add: ");
                string str = Console.ReadLine();

                if (Int32.TryParse(str, out int data))
                    switch (key)
                    {
                        case 'L': list.AddToEnd(data); break;
                        case 'F': list.AddFirst(data); break;
                        case 'I': Insert(list, data);  break;
                    }
                else
                    Console.WriteLine("\nInvalid input");
            }

            static void Insert(LinkedList list, int data)
            {
                Console.Write($"\nEntet position where the node will be inserted(between 1 and {list.CountOfMembers}): ");
                string str = Console.ReadLine();
                if (int.TryParse(str, out int position))
                {
                    if (position >= list.CountOfMembers)
                        Console.WriteLine("\nNumber is too big!");
                    else
                        list.Insert(data, position);
                }
                else
                    Console.WriteLine("\nInvalid input");
            }
        }
    }
}
