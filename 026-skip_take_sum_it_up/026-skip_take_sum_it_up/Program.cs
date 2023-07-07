/*
Change the previous application.
Allow the user to input 2 numbers.
Use the first number to Skip and the second number to Take.
Now do the Sum, Average and total number of items calculations on that subset of items.
 */

var random = new Random();
var doubleList = new List<double>();

for (int i = 0; i < 1000; i++)
{
    doubleList.Add(random.NextDouble() * 10);
}

Console.WriteLine($"Element number in the list {doubleList.Count()}");
Console.WriteLine("Type a number of elements to skip");
int input1 = int.Parse(Console.ReadLine());
Console.WriteLine("Type a number of elements to take");
int input2 = int.Parse(Console.ReadLine());

var skipedTakedList = doubleList.Skip(input1).Take(input2);

var sum = skipedTakedList.Sum();
var avg = skipedTakedList.Average();
var count = skipedTakedList.Count();

Console.WriteLine($"Sum: {sum}, Avg: {avg}, Count: {count}");