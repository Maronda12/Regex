using System;
using System.Text.RegularExpressions;

namespace RegexLab
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //1. Write a method that will validate names. Names can only have alphabets, they should start with a capital letter, and have a maximum of length of 30.

            Regex name = new Regex("^[A-Z]{1}[a-z]{1,29}$");
            string input;

            Console.WriteLine("Enter your name: ");
            input = Console.ReadLine();

            while (name.Match(input).Success == false)
            {
                Console.WriteLine("Invalid. Please enter your name. ");
                input = Console.ReadLine();
            }
            Console.WriteLine("Validated!");

            
        }
        
    }
    
}
