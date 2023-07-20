/*
 Create a program that writes user input to a file.
Then read from that file and print the results.
Make sure to use the Async() methods of the File class to do so.
 */

string? input;
string fileName = "../../../output.txt";

Console.Write("Type something: ");
input = Console.ReadLine();
try
{
    if (input == null) throw new ArgumentNullException(nameof(input));

    Task task = File.WriteAllTextAsync(fileName, input);
    await task;

    Console.Write("From File: ");
    var task2 = File.ReadAllTextAsync(fileName);
    await task2;
    Console.WriteLine(task2.Result);
}
catch (ArgumentNullException exc)
{
    Console.WriteLine(exc.Message);
}