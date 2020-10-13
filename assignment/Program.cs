using System;

namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Answers answers = new Answers();
            bool result = answers.Sum();
            if (result)
            {
                Console.WriteLine("The sum is greater than 500");
            }
            else
            {
                Console.WriteLine("the sum is smaller than 500");
            }

            int pointResult = answers.Points();
            Console.WriteLine($"total score is {pointResult}");

            Console.WriteLine("enter the name");
            string name = Console.ReadLine();
            string initials = answers.GetInitials(name);
            Console.WriteLine(initials);
        }
    }
}
