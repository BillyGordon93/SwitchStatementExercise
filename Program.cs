using System;

namespace SwitchStatementExercize
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Hi What is your favorite subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Do you like math? I always found numbers annoying!");
                    break;
                case "Science":
                    Console.WriteLine("No Way!!! Science is my favorite also!");
                    break;
                case "lunch":
                    Console.WriteLine("The only class I ever passed");
                    break;
                default:
                    Console.WriteLine("wierd I have never heard of that class before?");
                    break;
            }
        }
    }
}
