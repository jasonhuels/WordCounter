using System;
using WordCounter;
using System.IO;
using System.Threading;

namespace WordGame
{
    public class Game
    {
        private static string[] _textFromFile = File.ReadAllLines(@"./text.txt");
        private static char[] _charsToTrim = { ',', '.', '\'', '\"', ' ' };
        public Game()
        {

        }

        public static void PlayGame()
        {
            RepeatCounter counter;
            string wordToFind;
            string sentenceToCheck;            
            string[] sentenceSplit;
            int guess = 0;
            Random rand = new Random();
            int randomIndex = rand.Next(0, _textFromFile.Length);

            sentenceToCheck = _textFromFile[randomIndex];
            sentenceSplit = sentenceToCheck.Split(" ");
            randomIndex = rand.Next(0, sentenceSplit.Length);
            wordToFind = sentenceSplit[randomIndex].ToLower().Trim(_charsToTrim);

            Console.Clear();
            Console.WriteLine($"You have 5 seconds to count the occurances of the word: {wordToFind}");
            Thread.Sleep(1500);
            Console.WriteLine(sentenceToCheck);
            Thread.Sleep(5000);
            Console.Clear();
            do
            {
                Console.WriteLine($"How many occurances of {wordToFind} did you count?");
                int.TryParse(Console.ReadLine(), out guess);
            }
            while (guess < 0);
            counter = new RepeatCounter(wordToFind, sentenceToCheck);
            if (guess == counter.CountWords())
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
    }
}