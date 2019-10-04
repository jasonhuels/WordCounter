using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
    {
        public string Word {get; set;}
        public string Sentence {get; set;}
        public RepeatCounter(string word, string sentence)
        {
            Word = word;
            Sentence = sentence;
        }

        public int CountWords()
        {
            int count = 0;
            char[] charsToTrim = {',', '.', '\'', '\"', ' '};
            string[] wordArr = Sentence.Split(" ");
            for(int i=0; i<wordArr.Length; i++)
            {
                if(wordArr[i].ToLower().Trim(charsToTrim) == Word.ToLower())
                {
                    count++;
                }
                // Check for Plural versions of the word, ignore single character words
                else if (Word.Length > 1 && (wordArr[i].ToLower().Trim(charsToTrim) == Word.ToLower() + "s" || wordArr[i].ToLower().Trim(charsToTrim) == (Word.ToLower() + "\'s")))
                {
                    count++;
                }
            }
            return count;
        }
    }
}