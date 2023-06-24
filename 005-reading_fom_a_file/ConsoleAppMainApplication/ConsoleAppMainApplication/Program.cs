/*
Create a program, prompt the user for a file path.
Then the program should read that file and print out the contents of that file.
What happens when you point it to a text file?
What happens when you point it to the PowerPoint file for this unit?
Bonus points: make it work for both absolute and relative paths.
 */

Console.WriteLine("Inserisci il percorso del file:");
string filePath = Console.ReadLine();

try
{
    string fileContents = File.ReadAllText(filePath);
    Console.WriteLine(fileContents);
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e);
}

//What happens when you point it to a text file?
//The file.txt can be read clearly;

//What happens when you point it to the PowerPoint file for this unit?
//Power Point file can be read clearly;

//Bonus points: make it work for both absolute and relative paths.
//I can't understand the point. This simple algorithm works for both cases.