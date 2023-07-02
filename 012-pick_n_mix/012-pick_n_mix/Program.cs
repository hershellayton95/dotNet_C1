/*
An ArrayList is an interesting data collection. It allows any object to be added.
Create a console app where you make an ArrayList.
Try adding numbers and text, then add anything you want.
Try printing the contents out to the console. Do you notice anything about how items are printed.
 */

//Since the exercise doesn't require asking the user for input, this exercise does not include Console.ReadLine().
using System.Collections;

ArrayList arrayList = new ArrayList()
{
    "string",
    1,
    1.05f,
    1.0000005d,
    1.000000000000005m,
    new int[]{1,2, 3, 4, 5, 6, 7}
};

Console.WriteLine();
Console.WriteLine("Printing the Arraylist");

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}