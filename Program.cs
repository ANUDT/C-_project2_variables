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

            int num01;
            int numb02;
            Console.Write("input a number: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("input a second number: ");
            numb02 = Convert.ToInt32(Console.ReadLine());
            //this is to store the result
            int result = num01 * numb02;
            // Showing the outcome
            Console.WriteLine("The result is " + result);


            double num03;
            double numb04;
            Console.Write("input a number: ");
            num03 = Convert.ToDouble(Console.ReadLine());
            Console.Write("input a second number: ");
            numb04 = Convert.ToDouble(Console.ReadLine());
            //this is to store the result
            double results = num03 * numb04;
            // Showing the outcome
            Console.WriteLine("The result of this is  " + results);
            Console.ReadKey();

            int num05;
            int numb06;
            int numb07;
            Console.Write("Can you input a number: ");
            num05 = Convert.ToInt32(Console.ReadLine());
            Console.Write("There is input a second number: ");
            numb06 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please give me input of the third number: ");
            numb07 = Convert.ToInt32(Console.ReadLine());
            //this is to store the result
            int finalResult = num05 + numb06 + numb07 / 3;
            // Showing the outcome
            Console.Write("The Final result is " + finalResult);

        }

    }
}
