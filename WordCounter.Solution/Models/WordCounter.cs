using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
    public class UserInput
    {
        private string _word {get;set;}
        private string _sent {get;set;}
        
        public UserInput (string word, string sent)
        {
            _word = word.ToLower();
            _sent = sent.ToLower();
        }

        public  int CountWords()
        {
            int counter = 0;
            for(int i = 0; i < _sent.Length; i ++)
            {
                if(_word == _sent)
                {
                    counter += 1;
                }
            }
            return counter;
        }
    }
}