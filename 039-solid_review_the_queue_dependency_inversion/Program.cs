/*

Change your queue so that it can log the operations to the Console.
After you're done, does your class still conform to the Dependency Inversion principle?
 
*/

using dip;

var consoleLogger = new ConsoleLogger();
var myQueue = new IntQueue(consoleLogger);

myQueue.Queue(1);
myQueue.Queue(2);
myQueue.Queue(3);
myQueue.Queue(4);
myQueue.Queue(5);

var result1 = myQueue.Peek();
Console.WriteLine(result1);

var result2 = myQueue.Dequeue();
Console.WriteLine(result2);

myQueue.Dequeue();
myQueue.Dequeue();
