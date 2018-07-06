using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {
    [TestClass]
    public class WordCounterTest {
        [TestMethod]
        public void IsSameWord_True () {
            //Arrange
            WordCount sameWord = new WordCount ("confirm", "confirm");

            //Act
            bool isSameWord = sameWord.IsSameWord ();

            //Assert
            Assert.AreEqual (true, isSameWord);
        }

        [TestMethod]
        public void CorrectCount () {
            //Arrange
            WordCount count = new WordCount ("confirm", "confirm confirm");

            //Act
            int correctCount = 2;
            int returnCount = count.GetCount ();
            //Assert
            Assert.AreEqual (correctCount, returnCount);
        }

        [TestMethod]
        public void CorrectCountWithCaps () {
            //Arrange
            WordCount count = new WordCount ("confirm", "Confirm confirm Confirm confirm");

            //Act
            int correctCount = 4;
            int returnCount = count.GetCount ();
            //Assert
            Assert.AreEqual (correctCount, returnCount);
        }

        [TestMethod]
        public void CorrectCountWithPunctuation () {
            //Arrange
            WordCount count = new WordCount ("confirm", "confirm, confirm! confirm");

            //Act
            int correctCount = 3;
            int returnCount = count.GetCount ();
            //Assert
            Assert.AreEqual (correctCount, returnCount);
        }
    }
}