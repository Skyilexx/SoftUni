using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double dogFood = double.Parse(Console.ReadLine()) * 2.5;
            double catFood = double.Parse(Console.ReadLine()) * 4;

            double sum = dogFood + catFood;

            Console.WriteLine($"{sum} lv.");

        }
    }
}
