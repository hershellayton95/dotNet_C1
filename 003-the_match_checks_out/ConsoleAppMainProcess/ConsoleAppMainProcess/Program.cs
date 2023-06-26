/*
Create a simple calculator that allows the user to input two numbers. Then add the two numbers together and display the sum to the user.
*/
string? input1 = null;
string? input2 = null;
double input1Parsed = 0;
double input2Parsed = 0;


Console.WriteLine("Inserisci il primo numero");
input1 = Console.ReadLine();
Console.WriteLine("Inserisci il secondo numero");
input2 = Console.ReadLine();

bool try1 = double.TryParse(input1, out input1Parsed);
bool try2 = double.TryParse(input2, out input2Parsed);


if (try1 && try2)
{
    Console.WriteLine($"the sum is {input1Parsed + input2Parsed}");
}
