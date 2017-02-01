using System;

namespace Speeding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in speed limit and the speed of the car.");
            Console.WriteLine("Speed Limit (km/h): ");
            var entered1 = Console.ReadLine();
            Console.WriteLine("Speed of the Car (km/h): ");
            var entered2 = Console.ReadLine();

            var first = 0;
            var second = 0;

            int.TryParse(entered1, out first);
            int.TryParse(entered2, out second);

            var demeritPoints = 0;

            if (first >= second)
            {
                Console.WriteLine("Okay.");
            }
            else
            {
                Console.WriteLine("The car is speeding.");
                demeritPoints = second - first;
                demeritPoints /= 5;
                Console.WriteLine("License now has " + demeritPoints + " demerit points.");
                if (demeritPoints >= 12)
                {
                    Console.WriteLine("License has been suspended.");
                }
            }

        }
    }
}
