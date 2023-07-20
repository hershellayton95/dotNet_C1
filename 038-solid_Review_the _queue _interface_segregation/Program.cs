/*
    Does your Queue conform to the Interface Segregation Principle?
    If your class does not have an interface, you can create one now.
 */

using isp;

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