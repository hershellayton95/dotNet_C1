/*
Create a console application that filters a list of integers.
It should only select uneven numbers from a list of 1000 random integers.
Use LINQ's query syntax to solve this exercise.
*/

var random = new Random();
var intList = new List<int>();

for (int i = 0; i < 1000; i++)
{
    intList.Add(random.Next(0, 1001));
}

var results =
    from integer in intList
    where integer % 2 == 1
    select integer;
;

//My code to show the result
results.ToList().ForEach(result => Console.Write(result + " "));