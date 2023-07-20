/*
Now that you've spent some time programming,
let's enable all the recommended analyzers.
Follow the steps in the video to do so.
Can you fix all the warnings that come out?
Do you need to disable some rules?
Try to understand each warning before making a decision.
*/

//CA1711: Identifiers should not have incorrect suffix - I suppressed it because the excersice require MyQueue as class name
using analyzeAndEnhance;

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