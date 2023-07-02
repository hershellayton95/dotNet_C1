/*
Other than being hard to spell, a queue is very useful for keeping things in the right order.
Create an application that allows 3 options:
Queue
Dequeue
Peek
When the user selects 1, allow them to add a string to the queue.
Option 2 should dequeue an item and print it to the console.
Option 3 should print the result of the Peek() method.
*/



Queue<string> queue = new Queue<string>();

while (true)
{
    Console.WriteLine("Make a choise (1 - 2 - 3)");
    Console.WriteLine("1 - Queue");
    Console.WriteLine("2 - Dequeue");
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
            queue.Enqueue(input);
            Console.WriteLine($"\"{input}\" has been added to the queue");
            Console.WriteLine();
            break;
        case '2':
            bool isDequeueble = queue.TryDequeue(out string? dequeuedEl);
            if (!isDequeueble)
            {
                Console.WriteLine("No element in the queue");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine($" \"{dequeuedEl}\" has been removed from the queue");
            Console.WriteLine();
            break;
        case '3':
            bool isPeekable = queue.TryPeek(out string? peekedEl);
            if (!isPeekable)
            {
                Console.WriteLine("No element in the queue");
                Console.WriteLine();
                continue;
            }
            Console.WriteLine($"\"{peekedEl}\" is the first queue's element");
            Console.WriteLine();
            break;
        default:
            Environment.Exit(0);
            break;
    }
}