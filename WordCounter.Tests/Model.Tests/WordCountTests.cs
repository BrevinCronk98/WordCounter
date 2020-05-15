using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.TestTools
{
    [TestClass]
    public class CounterChecks
    {
        // Test One
        [TestMethod]
        public void Constructor_CreatesObject_WordSent()
        {
            UserInput myInput= new UserInput("Lily", "Lily is the best yes");
            Assert.AreEqual(typeof(UserInput), myInput.GetType());
        }
        // Test Two
        [TestMethod]
        public void Logic_WillCorrectlyCountMatchingWords_Counter()
        {
            UserInput myInput = new UserInput("Lily", "Lily Lily is the best best");
            Assert.AreEqual(2,myInput.CountWords());
        }

        // Test Three
        [TestMethod]
        public void Logic_WillCorrectlyCountMatchedWordsWithCaseInsenitivity_Counter()
        {
            UserInput myInput = new UserInput("bOb", "Bob is a really cool guy, BOB once told bOb that Bob");
            Assert.AreEqual(4,myInput.CountWords());
        }
        // Test Four
        [TestMethod]
        public void Logic_WillNotCountSimilarWordsInSentence_Counter()
        {
            UserInput myInput = new UserInput("sea", "Take a seat at the beach near the sea where the sea and the seat are both warm");
            Assert.AreEqual(2,myInput.CountWords());
        }

        // Test Five
        [TestMethod]
        public void Logic_WillCountWordsThatEndWithCommonPunctuation_Counter()
        {
            UserInput myInput = new UserInput("seat", "Take a seat, Young Skywalker, seat, seat, seat");
            Assert.AreEqual(4, myInput.CountWords());
        }

        // Test Six
        [TestMethod]
        public void Logic_WillNotCountWordThatAreIncorrect_Counter()
        {
            UserInput myInput = new UserInput("Hello", "Hello There, my name is !Hello, its so nice to ,Hello"); 
            Assert.AreEqual(1, myInput.CountWords());
        }
    }
}