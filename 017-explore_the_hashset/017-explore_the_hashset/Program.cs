/*
Create a HashSet<string>.
Explore what happens when you add unique values to it.
Does a HashSet consider strings with different capitalisations unique?

Yes, HashSet considers strings with different capitalizations as unique elements. Infact, Hashset treated as distinct element;

 */

Console.WriteLine("Default hashset");
HashSet<string> strings = new HashSet<string>()
{
    "hello",
    "Hello",
    "HELLO",
    "HeLLo"
};

foreach (string s in strings)
{
    Console.WriteLine(s);
}

Console.WriteLine("With ignore case");
HashSet<string> strings2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase){
    "hello",
    "Hello",
    "HELLO",
    "HeLLo"
};
foreach (string s in strings2)
{
    Console.WriteLine(s);
}