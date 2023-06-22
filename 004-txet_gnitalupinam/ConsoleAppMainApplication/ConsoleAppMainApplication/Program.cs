/*
 * Allow a user to input some text. Display the text back to them, but in reverse!
 */
Console.WriteLine("inserisci una frase");
string input = Console.ReadLine();

Console.WriteLine(new string(input.Reverse().ToArray()));
