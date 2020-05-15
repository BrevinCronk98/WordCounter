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
            string[] sentSplit = _sent.Split(' ');
            int counter = 0;
            for(int i = 0; i < sentSplit.Length; i ++)
            {
                while (sentSplit[i].EndsWith(',') || sentSplit[i].EndsWith('?') || sentSplit[i].EndsWith('!') || sentSplit[i].EndsWith('.') || sentSplit[i].EndsWith(':') || sentSplit[i].EndsWith(';'))
                {
                   sentSplit[i] = sentSplit[i].Remove(sentSplit[i].Length - 1);
                }
                if(_word == sentSplit[i]) 
                {
                    counter += 1;
                } 
            }
          return counter;
        }
    }
}