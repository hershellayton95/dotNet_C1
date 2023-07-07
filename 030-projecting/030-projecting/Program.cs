/*
Create a list of 100 random numbers. For every number, create an instance of the new class NumberMetaData.
The class should contain the following properties: IsEven, NumberOfCharacters.
Try using Select() in LINQ to transform 100 numbers into 100 instances of NumberMetaData
 */

using _030_projecting;

var random  = new Random();
var numbers = new List<int>();

for  (int i = 0; i < 100; i++)
{
    numbers.Add(random.Next(0,10000));
}

var results = numbers.Select(number => new NumberMetaData(number)).ToList();

//my code to see if it works
results.ForEach(result => {
    Console.WriteLine($"Number: {result.Number}");
    Console.WriteLine($"isEven: {result.IsEven()}");
    Console.WriteLine($"Number of Character {result.NumberOfCharacters()}");
    Console.WriteLine();
});