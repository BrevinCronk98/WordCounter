using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Counter.Models;

namespace Counter.TestTools
{
    [TestClass]
    public class CounterGetters
    {
        // Test One
        [TestMethod]
        public void Constructor_MakesTwoCounters_Counters()
        {
            CountWords testCount = new CountWords();
            Assert.AreEqual(typeof(CountWords), testCount.GetType());
        }
        // Test Two
        [TestMethod]
        public void Constructor_GetCounterOne_CounterOne()
        {
            CountWords testCount = new CountWords();
            Assert.AreEqual(0, testCount.GetCounterOne()); 
        }
        // Test Three
        [TestMethod]
        public void Constructor_GetCounterTwo_CounterTwo()
        {
            CountWords testCount = new CountWords();
            Assert.AreEqual(0, testCount.GetCounterTwo()); 
        }
    }
}