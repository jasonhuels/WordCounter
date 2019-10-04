using System;
using WordCounter;

public class Program
{
    static void Main()
    {
        RepeatCounter counter;
        string wordToFind;
        string sentenceToCheck;
        string yOrN;
        bool repeat = true;

        while(repeat)
        {
            do
            {
                Console.WriteLine("\nEnter a word to check for:");
                wordToFind = Console.ReadLine();
            }
            while(wordToFind.Length < 1);
            do
            {
                Console.WriteLine("\nEnter the sentence to search:");
                sentenceToCheck = Console.ReadLine();
            }
            while(sentenceToCheck.Length < 1);

            Console.Clear();
            counter = new RepeatCounter(wordToFind, sentenceToCheck);
            Console.WriteLine($"Found {counter.CountWords()} occurances of \'{wordToFind}\' in the sentence:\n\"{sentenceToCheck}\"");

            do
            {
                Console.WriteLine("\nWould you like to check another sentence? (y/n)");
                yOrN = Console.ReadLine();
                if(yOrN.ToLower()[0] == 'n')
                {
                    repeat = false;
                }
            }
            while(yOrN.ToLower()[0] != 'n' && yOrN.ToLower()[0] != 'y');
        }      
    }
}