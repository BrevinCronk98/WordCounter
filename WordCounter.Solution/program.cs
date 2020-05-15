using System;
using System.Collections.Generic;
using WordCounter.Models;
using Counter.Models;
namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            start:
            Console.WriteLine("Enter the First Word You Want Counted.");
            string wordOne = Console.ReadLine();
            Console.WriteLine("Enter Your Second Word!");
            string wordTwo = Console.ReadLine();
            Console.WriteLine("Enter You Sentence");
            string inputSent = Console.ReadLine();
            UserInput newInput = new UserInput(wordOne, wordTwo, inputSent);
            int counterOne = newInput.CountFirstWord();
            int counterTwo = newInput.CountSecondWord();
            Console.WriteLine(wordOne + " Shows up " + counterTwo + " Times and " + wordTwo + " Shows up " + counterTwo + " Times!");
            Console.WriteLine("Do You Want To Do a New Word? Press 1, Y, or type Yes");
            string answer = Console.ReadLine().ToLower();
            if(answer == "1" || answer == "y" || answer == "yes")
            {
                goto start;
            }
        }
    }
}