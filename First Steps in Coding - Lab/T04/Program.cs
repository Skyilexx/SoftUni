using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double centimeters = double.Parse(Console.ReadLine());

            double convertor = centimeters * 2.54;
            Console.WriteLine(convertor);
        }
    }
}