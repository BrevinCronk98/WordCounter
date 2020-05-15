using System;
using System.Collections.Generic;
using Counter.Models;

namespace WordCounter.Models
{
    public class UserInput
    {
        private string _wordOne {get; set;}
        private string _wordTwo {get; set;}
        private string _sent {get;set;}
        
        public UserInput (string wordOne, string wordTwo, string sent)
        {
            _wordOne = wordOne.ToLower();
            _wordTwo = wordTwo.ToLower();
            _sent = sent.ToLower();
        }


        public  int CountFirstWord()
        {
            string[] sentSplit = _sent.Split(' ');
            CountWords newCounters = new CountWords();
            int counterOne = newCounters.GetCounterOne();
            for(int i = 0; i < sentSplit.Length; i ++)
            {
                while (sentSplit[i].EndsWith(',') || sentSplit[i].EndsWith('?') || sentSplit[i].EndsWith('!') || sentSplit[i].EndsWith('.') || sentSplit[i].EndsWith(':') || sentSplit[i].EndsWith(';'))
                {
                   sentSplit[i] = sentSplit[i].Remove(sentSplit[i].Length - 1);
                }
                if(_wordOne == sentSplit[i]) 
                {
                    counterOne  += 1;
                }
        
            }
            return counterOne;
        }
        
        
        public  int CountSecondWord()
        {
            string[] sentSplit = _sent.Split(' ');
            CountWords newCounters = new CountWords();
            int counterTwo = newCounters.GetCounterTwo();
            for(int i = 0; i < sentSplit.Length; i ++)
            {
                while (sentSplit[i].EndsWith(',') || sentSplit[i].EndsWith('?') || sentSplit[i].EndsWith('!') || sentSplit[i].EndsWith('.') || sentSplit[i].EndsWith(':') || sentSplit[i].EndsWith(';'))
                {
                   sentSplit[i] = sentSplit[i].Remove(sentSplit[i].Length - 1);
                }
                if(_wordTwo == sentSplit[i]) 
                {
                    counterTwo  += 1;
                }
        
            }
            return counterTwo;
        }

    }
}