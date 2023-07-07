/*
 Create an application that finds the Sum, Average and total number of items in a List of doubles.
 */

var random = new Random();
var doubleList = new List<double>();

for  (int i = 0; i < 10; i++)
{
    doubleList.Add(random.NextDouble()*10);
}

var sum = doubleList.Sum();
var avg = doubleList.Average();
var count = doubleList.Count();

Console.WriteLine($"Sum: {sum}, Avg: {avg}, Count: {count}");
