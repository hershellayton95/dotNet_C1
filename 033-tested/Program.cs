/*
I'm sure you validated the workings of your MyQueue,
but can you automate these tests?
Create a unit test project and write unit tests for all three of the methods.
Make sure to include tests that show that the queue works,
as well as tests that show where it fails
(e.g. what happens when you Dequeue and empty Queue?) 
*/

using tested;

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