/* 2. Strings and Indexers
Create a class WordList with a string array and an indexer (no get; set; properties).
Print the word at index 1.*/


using System;

public class WordlList
{
    //Internal string array
    public string[] words = { "Sun", "Moon", "Stars" };
}

public class Program
{
    public static void Main()
    {
        WordList list = new WordList();
        Console.WriteLine("Word at index 1:" + list.words[1]);
    }
}