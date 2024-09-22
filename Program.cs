// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name and how are you today?");

            string userName = Console.ReadLine() ?? "Unknown User";

            Console.WriteLine("Hi," + userName + ", nice to meet you!");
   
            Console.ReadKey();
        }
       
    }
}
