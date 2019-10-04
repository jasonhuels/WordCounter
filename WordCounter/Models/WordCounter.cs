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
            string cleanWord;
            for(int i=0; i<wordArr.Length; i++)
            {
                cleanWord = wordArr[i].ToLower().Trim(charsToTrim);
                if(cleanWord == Word.ToLower())
                {
                    count++;
                }
                // Check for Plural versions of the word, ignore single character words
                else if (Word.Length > 1 && (cleanWord == Word.ToLower() + "s" || cleanWord == (Word.ToLower() + "\'s")))
                {
                    count++;
                }
            }
            return count;
        }
    }
}