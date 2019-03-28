using System;
namespace BasicCSharp.Exercises
{
    public class Zero : Exercise
    {
        public static void Start()
        {
            string name;
            string surname;
            int age;

            name = ReadString("Please tell me your name:");

            surname = ReadString("Now tell me your surname:");

            age = ReadNumber("Please tell me your age:");

            Console.WriteLine(surname + ", " + name);
            Console.WriteLine("Age: " + age);

            Console.WriteLine();
        }
    }
}