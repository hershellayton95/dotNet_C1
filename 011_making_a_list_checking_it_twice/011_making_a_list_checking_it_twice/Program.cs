/*
Create a console application.
The console application should ask the user 10 times for input.
This input is added to a list
After the 10th time, the console program will print out the list twice.
Once from start to finish, the other time in reverse.

Tip: If you find yourself writing Console.ReadLine() 10 times, maybe there's a smarter way to do this
 */

//I'm choosing a list of strings because Console.ReadLine() returns a string, and the exercise doesn't ask to parse the input.
List<string> list = new List<string>();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Insert an element into the list - {10 - i} left");
    list.Add(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("From Start to End!");

foreach (string item in list)
{
    Console.WriteLine(item);
}

Console.WriteLine();
Console.WriteLine("From End to Start!");

//The exercise doesn't require creating a new reversed list, so I chose to reverse the same list.
list.Reverse();
foreach (string item in list)
{
    Console.WriteLine(item);
}