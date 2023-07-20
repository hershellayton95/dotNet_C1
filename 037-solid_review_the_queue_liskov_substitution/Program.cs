/*
Create two subclasses of your MyQueue<T>.
Call them IntQueue and StringQueue.
Do these Queues conform to the Liskov Substitution Principle?

- I think it could respect the ls principle.
*/

using lsp;

var myQueue = new IntQueue();

Console.WriteLine("Enqueue...");
myQueue.Queue(1);
myQueue.Queue(2);
myQueue.Queue(3);
myQueue.Queue(4);
myQueue.Queue(5);

foreach (int item in myQueue)
{
    Console.WriteLine(item + " ");
}
Console.WriteLine("Peeking...");
var result1 = myQueue.Peek();
Console.WriteLine(result1);

Console.WriteLine("Dequeue...");
Console.WriteLine("Tryng return...");
var result2 = myQueue.Dequeue();
Console.WriteLine(result2);

Console.WriteLine("Continuing dequeue...");
myQueue.Dequeue();
myQueue.Dequeue();

foreach (int item in myQueue)
{
    Console.WriteLine(item + " ");
}