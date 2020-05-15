using System;
using System.Collections.Generic;

namespace Counter.Models
{
    public class CountWords
    {
        private int _counterOne;
        private int _counterTwo;
   

        public CountWords()
        {
            _counterOne = 0;
            _counterTwo = 0;
        }

        public int GetCounterOne()
        {
            return _counterOne;
        }
        public int GetCounterTwo()
        {
            return _counterTwo;
        }
    }
}