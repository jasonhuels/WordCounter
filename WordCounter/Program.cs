using System;
using WordCounter;
using System.IO;
using System.Threading;

public class Program
{
    static void Main()
    {
        RepeatCounter counter;
        string wordToFind;
        string sentenceToCheck;
        string yOrN;
        bool repeat = true;
        string gameOrCount;
        bool game = false;
        string[] textFromFile;
        string[] sentenceSplit;
        int guess = 0;
        char[] charsToTrim = { ',', '.', '\'', '\"', ' ' };

        while(repeat)
        {
            do
            {
                Console.WriteLine("\nWould you like to play a game or count the number of words? (game/count)");
                gameOrCount = Console.ReadLine();
                if (gameOrCount.ToLower() == "game")
                {
                    game = true;
                }
                else
                {
                    game = false;
                }
            }
            while (gameOrCount.ToLower() != "game" && gameOrCount.ToLower() != "count");
            
            if(game)
            {
                textFromFile = System.IO.File.ReadAllLines(@"./text.txt");
                Random rand = new Random();
                int randomIndex = rand.Next(0, textFromFile.Length);
                sentenceToCheck = textFromFile[randomIndex];
                sentenceSplit = sentenceToCheck.Split(" ");
                randomIndex = rand.Next(0, sentenceSplit.Length);
                wordToFind = sentenceSplit[randomIndex].ToLower().Trim(charsToTrim);
                Console.Clear();
                Console.WriteLine($"You have 5 seconds to count the occurances of the word: {wordToFind}");
                Console.WriteLine(sentenceToCheck);
                Thread.Sleep(5000);
                Console.Clear();
                do
                {
                    Console.WriteLine($"How many occurances of {wordToFind} did you count?");
                    int.TryParse(Console.ReadLine(), out guess);
                }
                while(guess < 0);
                counter = new RepeatCounter(wordToFind, sentenceToCheck);
                if(guess == counter.CountWords())
                {
                    Console.WriteLine($"You guessed {guess}, the correct answer is {counter.CountWords()}.");
                    Console.WriteLine("You Win!");
                }
                else 
                {
                    Console.WriteLine($"You guessed {guess}, the correct answer is {counter.CountWords()}.");
                    Console.WriteLine("You Lose!");
                }      
            }
            else
            {
                do
                {
                    Console.WriteLine("\nEnter a word to check for:");
                    wordToFind = Console.ReadLine();
                }
                while (wordToFind.Length < 1);
                do
                {
                    Console.WriteLine("\nEnter the sentence to search:");
                    sentenceToCheck = Console.ReadLine();
                }
                while (sentenceToCheck.Length < 1);

                Console.Clear();
                counter = new RepeatCounter(wordToFind, sentenceToCheck);
                Console.WriteLine($"Found {counter.CountWords()} occurances of \'{wordToFind}\' in the sentence:\n\"{sentenceToCheck}\"");
            }
            

            do
            {
                Console.WriteLine("\nWould you like to check another sentence? (y/n)");
                yOrN = Console.ReadLine();
                if (yOrN.ToLower() == "n")
                {
                    repeat = false;
                }
            }
            while(yOrN.ToLower() != "y" && yOrN.ToLower() != "n");
        }      
    }
}