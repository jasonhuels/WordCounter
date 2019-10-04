using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{

    [TestClass]
    public class RepeatCounterTests
    {
        [TestMethod]
        public void CountWords_FindNoMatches_0()
        {
            // Arrange
            string word = "I";
            string sentence = "This is a test sentence.";
            int count = 0;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(result, count);
        }
        [TestMethod]
        public void CountWords_Find1Match_1()
        {
            // Arrange
            string word = "a";
            string sentence = "This is a test sentence.";
            int count = 1;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(result, count);
        }
    }

}