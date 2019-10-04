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
            Assert.AreEqual(count, result);
        }
        [TestMethod]
        public void CountWords_FindSingleLetter_1()
        {
            // Arrange
            string word = "a";
            string sentence = "This is a test sentence.";
            int count = 1;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(count, result);
        }
        [TestMethod]
        public void CountWords_FindMultiCharacterWord_1()
        {
            // Arrange
            string word = "test";
            string sentence = "This is a test sentence.";
            int count = 1;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(count, result);
        }
        [TestMethod]
        public void CountWords_FindMultiMatches_2()
        {
            // Arrange
            string word = "is";
            string sentence = "This is a test sentence. It is just for testing.";
            int count = 2;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(count, result);
        }
        [TestMethod]
        public void CountWords_IgnoreCase_1()
        {
            // Arrange
            string word = "this";
            string sentence = "This is a test sentence. It is just for testing.";
            int count = 1;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(count, result);
        }
        [TestMethod]
        public void CountWords_IgnorePartialMatch_1()
        {
            // Arrange
            string word = "test";
            string sentence = "This is a test sentence. It is just for testing.";
            int count = 1;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(count, result);
        }
        [TestMethod]
        public void CountWords_IgnorePunctuation_1()
        {
            // Arrange
            string word = "sentence";
            string sentence = "This is a test sentence. It is just for testing.";
            int count = 1;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(count, result);
        }
        [TestMethod]
        public void CountWords_CatchPluralWord_1()
        {
            // Arrange
            string word = "test";
            string sentence = "This is a test sentence, it tests sentences.";
            int count = 2;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(count, result);
        }
        [TestMethod]
        public void CountWords_CatchPluralWordWithApostrophe_1()
        {
            // Arrange
            string word = "Jason";
            string sentence = "This is a Jason's final test.";
            int count = 1;
            RepeatCounter counter = new RepeatCounter(word, sentence);

            // Act
            int result = counter.CountWords();

            // Assert
            Assert.AreEqual(count, result);
        }
    }

}