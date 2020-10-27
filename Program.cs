using System;

namespace Lab1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double V, h, r;
            double Pi = 3.14;
            Console.WriteLine("Enter height: ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter r: ");
            r = Convert.ToDouble(Console.ReadLine());
            V = (h / 3) * Pi * Math.Pow(r, 2);
            Console.WriteLine($"V = {V}");
            Console.ReadKey();
        }
    }
}
