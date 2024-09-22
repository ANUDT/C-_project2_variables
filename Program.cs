// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");

            string userName = Console.ReadLine() ?? "Unknown User";
            Console.WriteLine("Hello" + userName + ", nice to meet you!");
            Console.ReadKey();
        }
       
    }
}
