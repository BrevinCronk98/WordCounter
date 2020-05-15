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
            Console.WriteLine("Enter the Word You Want to Be Counted");
            string inputWord = Console.ReadLine();
            Console.WriteLine("Your Word is " + inputWord);
            Console.WriteLine("Enter Your Sentence");
            string inputSent = Console.ReadLine();
            Console.WriteLine(inputSent);
            UserInput newInput = new UserInput(inputWord, inputSent);
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