/*
Create a simple calculator that allows the user to input two numbers. Then add the two numbers together and display the sum to the user.
*/
string input1 = "";
string input2 = "";
double input1Parsed = 0;
double input2Parsed = 0;


Console.WriteLine("Inserisci il primo numero");
input1 = Console.ReadLine();
Console.WriteLine("Inserisci il secondo numero");
input2 = Console.ReadLine();

input1Parsed = double.Parse(input1);
input2Parsed = double.Parse(input2);



Console.WriteLine($"the sum is {input1Parsed + input2Parsed}");