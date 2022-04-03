using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double r = Convert.ToDouble(Console.ReadLine());
            double rez = pi * r*r;
            Console.WriteLine("rezultat raven {0}", rez);
        }
    }
}
