/*
Sorting numbers is easy, just go from low to high and you're done.
But you can create your own way of sorting too.
Can you combine LINQ with a Custom Comparer to sort items based on how many characters they have?
For instance:
5 = 1 character
52 = 2 characters
364 = 3 characters
Create a list of 1000 random numbers, and sort it by the amount of characters each number has, from low to high.
*/

var random = new Random();
var intList = new List<int>();

for (int i = 0; i < 1000; i++)
{
    intList.Add(random.Next(0, 1001));
}

var results = intList.OrderBy(n => n, new SpecialComparer()).ToList();
results.ForEach(x => Console.Write(x + " "));
