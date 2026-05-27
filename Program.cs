// Instructions for said form :Create a C# application that displays the following :
// Welcome to  the structure C#  Program demo:
// Enter your name : Junior
// Hello Junior 
// Program structure Demonstrated :
// 1.	Using systems() improves functionality 
// 2.	Namespace :organizes code 
// 3.	Class Program: Container for code 
// 4.	Main (): entry point of program
// 5.	Comments: explain logic and documentation
// Program Executed successfully
using System;

namespace StructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display welcome message
            Console.WriteLine("Welcome to the structure C# Program demo:");

            // Prompt user for their name
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // Greet the user
            Console.WriteLine($"Hello {name}");

            // Display program structure information
            Console.WriteLine("Program structure Demonstrated:");
            Console.WriteLine("1. Using systems() improves functionality");
            Console.WriteLine("2. Namespace: organizes code");
            Console.WriteLine("3. Class Program: Container for code");
            Console.WriteLine("4. Main(): entry point of program");
            Console.WriteLine("5. Comments: explain logic and documentation");

            // Indicate successful execution
            Console.WriteLine("Program Executed successfully");
        }
    }
}