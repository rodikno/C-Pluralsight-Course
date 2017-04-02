using System;

namespace CSharp_Pluralsight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Your name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours did you sleep last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            if (hoursOfSleep > 7)
            {
                Console.WriteLine("You are well rested");
            }
            else
            {
                Console.WriteLine("You need more sleep");
            }
        }
    }
}
