using System;
namespace BasicCSharp.Exercises
{
    public class Three : Exercise
    {
        public static void Start()
        {
            DateTime birthday;

            Console.WriteLine("Please tell me your birthday... (Format: MM/DD/YEAR)");
            birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();

            int days = DateTime.Today.Subtract(birthday).Days;

            Console.WriteLine("You have lived " + days + " days so far!");

            Console.WriteLine();

        }
    }
}
