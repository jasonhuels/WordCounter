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
            string[] wordArr = Sentence.Split(" ");
            for(int i=0; i<wordArr.Length; i++)
            {
                if(wordArr[i] == Word)
                {
                    count++;
                }
            }
            return count;
        }
    }
}