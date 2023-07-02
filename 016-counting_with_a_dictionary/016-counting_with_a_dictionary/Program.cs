/*
Create an application that allows a user to give a path to a .txt file.
That file should contain a lot of words, with some duplicates.
The application should create a Dictionary<string, int> to store every unique word, and how often they appear in the file.
For this purpose, words are not case-sensitive.
 */
using System.Text.RegularExpressions;

Console.WriteLine("Insert a file *.txt path");
string input = Console.ReadLine();

string text = File.ReadAllText(input).ToLower();
text = Regex.Replace(text, @"[\p{P}<>]+", " ").Replace("  ", " ");
string[] words = text.Split(" ");

Dictionary<string, int> occurences = new Dictionary<string, int>();

foreach (string word in words)
{
    if (word == "")
    {
        continue;
    }

    if (occurences.ContainsKey(word))
    {   
        occurences[word] += 1;
    } else {
        occurences.Add(word, 1);
    }
}


foreach(KeyValuePair<string, int> word in occurences)
{
    Console.WriteLine($"{word.Key}: {word.Value}");
}