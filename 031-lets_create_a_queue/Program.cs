/*
 * Create your own Queue class. Let's call it MyQueue<T>. We want this to be generic, so we can allow the user to define what items need to be stored. Implement the following methods:

Queue
Dequeue
Peek
*/

using _031_lets_create_a_queue;

var myQueue = new MyQueue<int>();

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