/*
 Change the previous application to use LINQ's method syntax instead.
 */

var random = new Random();
var intList = new List<int>();

for (int i = 0; i < 1000; i++)
{
    intList.Add(random.Next(0, 1001));
}

var results = intList.Where(integer => integer % 2 == 1);

//My code to show the result
results.ToList().ForEach(result => Console.Write(result + " "));