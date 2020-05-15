using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;


namespace WordCounter.TestTools
{
    [TestClass]
    public class WordCounterChecks
    {
        // Test One
        [TestMethod]
        public void Constructor_CreatesObject_WordSent()
        {
            UserInput myInput= new UserInput("Lily", "lily", "Lily is the best yes");
            Assert.AreEqual(typeof(UserInput), myInput.GetType());
        }
        // Test Two
        [TestMethod]
        public void Logic_WillCorrectlyCountMatchingWords_Counter()
        {
            UserInput myInput = new UserInput("Lily","silly", "Lily Lily is silly the best best");
            Assert.AreEqual(2,myInput.CountFirstWord());
            Assert.AreEqual(1,myInput.CountSecondWord());
        }

        // Test Three
        [TestMethod]
        public void Logic_WillCorrectlyCountMatchedWordsWithCaseInsenitivity_Counter()
        {
            UserInput myInput = new UserInput("bOb", "jeff", "Bob is a really cool guy, BOB once told jeff that Bob is jeff");
            Assert.AreEqual(3,myInput.CountFirstWord());
            Assert.AreEqual(2,myInput.CountSecondWord());
        }
        // Test Four
        [TestMethod]
        public void Logic_WillNotCountSimilarWordsInSentence_Counter()
        {
            UserInput myInput = new UserInput("sea", "shirt", "Take a seat at the beach near the sea where the sea and the seat are both warm, just like your shirt, your shirt is pretty like the shire");
            Assert.AreEqual(2,myInput.CountFirstWord());
            Assert.AreEqual(2,myInput.CountSecondWord());
        }

        // Test Five
        [TestMethod]
        public void Logic_WillCountWordsThatEndWithCommonPunctuation_Counter()
        {
            UserInput myInput = new UserInput("seat","master", "Take a seat, Young Skywalker, we do not grant you the rank of master, so take a seat you're no master");
            Assert.AreEqual(2,myInput.CountFirstWord());
            Assert.AreEqual(2,myInput.CountSecondWord());
        }

        // Test Six
        [TestMethod]
        public void Logic_WillNotCountWordThatAreIncorrect_Counter()
        {
            UserInput myInput = new UserInput("Hello", "Yellow", "Hello There, my name is !Hello, its so Yellow like ?yel1ow nice to ,Hello"); 
            Assert.AreEqual(1,myInput.CountFirstWord());
            Assert.AreEqual(1,myInput.CountSecondWord());
        }
    }
}