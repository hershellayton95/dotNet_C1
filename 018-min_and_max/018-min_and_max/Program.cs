/*
Create a List<int>.
The list should have 1000 random numbers.
Write a program that finds the minimum and maximum numbers in that list. 
 */

using System.Collections.Generic;

Random random = new Random();
List<int> intList = new List<int>();


for (int i = 0; i < 1000; i++)
{
    intList.Add(random.Next(int.MinValue, int.MaxValue));
}

int max = int.MinValue;
int min = int.MaxValue;

foreach (int i in intList)
{
    if (i > max)
    {
        max = i;
    }
    if (i < min)
    {
        min = i;
    }
}

Console.WriteLine($"the maximum value in the list is: {max}");
Console.WriteLine($"the minimum value in the list is: {min}");