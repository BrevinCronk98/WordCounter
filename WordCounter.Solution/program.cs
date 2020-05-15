using System;
using System.Collections.Generic;
using WordCounter.Models;

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
            int counter = newInput.CountWords();
            Console.WriteLine(inputWord + " Shows up " + counter + " Times!");
            Console.WriteLine("Do You Want To Do a New Word? Press 1, Y, or type Yes");
            string answer = Console.ReadLine().ToLower();
            if(answer == "1" || answer == "y" || answer == "yes")
            {
                goto start;
            }
        }
    }
}