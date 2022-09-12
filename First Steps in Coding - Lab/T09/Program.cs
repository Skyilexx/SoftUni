using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double meters2 = double.Parse(Console.ReadLine());

            double expense = meters2 * 7.61;

            double discount = expense * 0.18;

            double finalPrice = expense - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
