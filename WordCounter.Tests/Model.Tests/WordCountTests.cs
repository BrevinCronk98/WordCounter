using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.TestTools
{
    [TestClass]
    public class CounterChecks
    {
        [TestMethod]
        public void Constructor_CreatesObject_WordSent()
        {
            UserInput myInput= new UserInput("Lily", "Lily is the best yes");
            Assert.AreEqual(typeof(UserInput), myInput.GetType());

        }
    }
}