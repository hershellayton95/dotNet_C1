/*
Create another list of 1000 random integers.
Can you sort them from low to high?
Print out the result.
Bonus points if you can do it in reverse too.
*/

var random = new Random();
var intList = new List<int>();
ConsoleApp1024-unnatural_sorting
for (int i = 0; i < 1000; i++)
{
    intList.Add(random.Next(0,1001));
}

var ordered =
    from integer in intList
    orderby integer
    select integer;

Console.WriteLine("Ordered List");
ordered.ToList().ForEach(x => Console.Write(x + " "));
Console.WriteLine();
Console.WriteLine();

var reversed =
    from integer in intList
    orderby integer descending
    select integer;

Console.WriteLine("Reversed List");
reversed.ToList().ForEach(x => Console.Write(x + " "));
Console.WriteLine();