using System;
using WordCounter;
using WordGame;

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
                Game.PlayGame();
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