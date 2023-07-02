/*
Let's do the same for a Stack. The options are:

Push
Pop
Peek 
*/

Stack<string> stack = new Stack<string>();

while (true)
{
    Console.WriteLine("Make a choise (1 - 2 - 3)");
    Console.WriteLine("1 - Push");
    Console.WriteLine("2 - Pop");
    Console.WriteLine("3 - Peek");
    Console.WriteLine("Press another key to end the program");
    Console.WriteLine();
    char inputChar = Console.ReadKey(true).KeyChar;
    switch (inputChar)
    {
        case '1':
            Console.WriteLine("Type a string:");
            string? input = Console.ReadLine();
            if (input == null || input == "")
            {
                Console.WriteLine("Input not valid!");
                Console.WriteLine();
                continue;
            }
            stack.Push(input);
            Console.WriteLine($"\"{input}\" has been added to the stack");
            Console.WriteLine();
            break;
        case '2':
            bool isPoppable = stack.TryPop(out string? poppedEl);
            if (!isPoppable)
            {
                Console.WriteLine("No element in the stack");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine($" \"{poppedEl}\" has been removed from the stak");
            Console.WriteLine();
            break;
        case '3':
            bool isPeekable = stack.TryPeek(out string? peekedEl);
            if (!isPeekable)
            {
                Console.WriteLine("No element in the stack");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine($"\"{peekedEl}\" is the last stack's element");
            Console.WriteLine();
            break;
        default:
            Environment.Exit(0);
            break;
    }
}