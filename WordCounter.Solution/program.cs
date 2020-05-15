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
            
            start: /* The Start */
            
            // Gets First Word
            Console.WriteLine("Enter the First Word You Want Counted.");
            string wordOne = Console.ReadLine();
            
            // Gets Second Word
            Console.WriteLine("Enter Your Second Word!");
            string wordTwo = Console.ReadLine();
            
            // Gets Sentence
            Console.WriteLine("Enter You Sentence");
            string inputSent = Console.ReadLine();
            
            // Creates Object
            UserInput newInput = new UserInput(wordOne, wordTwo, inputSent);
           
            // Define Variables
            int counterOne = newInput.CountFirstWord();
            int counterTwo = newInput.CountSecondWord();
            string answer;
            

            // Checks Word Count to Display Proper Grammar
            if(counterOne == 1 && counterTwo == 1)
            {
                Console.WriteLine(wordOne + " Shows up " + counterOne + " Time and " + wordTwo + " Shows up " + counterTwo + " Time");
                Console.WriteLine("Do You Want To Do a New Word? Press 1, Y, or type Yes");
                answer = Console.ReadLine().ToLower();
            } else if(counterOne == 1 && counterTwo > 1)
            {
                Console.WriteLine(wordOne + " Shows up " + counterOne + " Time and " + wordTwo + " Shows up " + counterTwo + " Times");
                Console.WriteLine("Do You Want To Do a New Word? Press 1, Y, or type Yes");
                answer = Console.ReadLine().ToLower();
            } else if (counterOne > 1 && counterTwo == 1)
            {
                Console.WriteLine(wordOne + " Shows up " + counterOne + " Times and " + wordTwo + " Shows up " + counterTwo + " Time");
                Console.WriteLine("Do You Want To Do a New Word? Press 1, Y, or type Yes");
                answer = Console.ReadLine().ToLower();
            } else 
            {
                Console.WriteLine(wordOne + " Shows up " + counterOne + " Times and " + wordTwo + " Shows up " + counterTwo + " Times");
                Console.WriteLine("Do You Want To Do a New Word? Press 1, Y, or type Yes, or Press Enter To Leave Application");
                answer = Console.ReadLine().ToLower();
            }
        
            if(answer == "1" || answer == "y" || answer == "yes")
            {
                goto start; /* Brings User To Start*/
            }
        }
    }
}