﻿/*
A palindrome is a word or sentence that is the same spelled backwards.
Can you write a program that checks if the user input is a palindrome?
Palindromes are not case sensitive.
 */

using System;

Console.WriteLine("Insert a word or a sentence");
string? input = Console.ReadLine();

if (input == null || input == "")
{
    Console.WriteLine("Input not valid!");
    Environment.Exit(1);
    return;
}

input = input.Replace(" ", "").ToLower();
string reverse = new(input.Reverse().ToArray());

if (input.Equals(reverse))
{
    Console.WriteLine("It's a palindrome");
}
else
{
    Console.WriteLine("It isn't a palindrome");
}