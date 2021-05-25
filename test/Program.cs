using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string namn = Console.ReadLine();

            bool isIntString = namn.Any(c => char.IsDigit);
            while(isIntString = true)
            {
                Console.WriteLine("ge mig ditt namn");
                Console.ReadLine();
            }
        }
    }
}
