/*
Create a console application that checks whether all elements in a list of integers meet a specific condition (e.g., are even)
and whether any elements meet another condition (e.g., are odd) using LINQ.
*/

var intList = new List<int>();
var random = new Random();

for (int i = 0; i < 100; i++)
{
    intList.Add(random.Next(0,101));
}

var allEven = intList.All(x => x % 2 == 0);
var anyOdd = intList.Any(x => x % 2 == 1);

Console.WriteLine($"Are all element even? {allEven}");
Console.WriteLine($"Is there any odd element? {anyOdd}");