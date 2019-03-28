using System;
namespace BasicCSharp.Exercises
{
    public class One : Exercise
    {
        public static void Start()
        {
            string p1Name;
            string p2Name;
            string p1Surname;
            string p2Surname;
            int p1Age;
            int p2Age;

            Console.WriteLine("Person 1, please tell me your name:");
            p1Name = Console.ReadLine();

            Console.WriteLine(p1Name + ", now tell me your surname:");
            p1Surname = Console.ReadLine();

            Console.WriteLine(p1Name + ", please tell me your age:");
            p1Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Person 2, Please tell me your name:");
            p2Name = Console.ReadLine();

            Console.WriteLine(p2Name + ", Now tell me your surname:");
            p2Surname = Console.ReadLine();

            Console.WriteLine(p2Name + ", Please tell me your age:");
            p2Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Person 2 is " + p2Surname + ", " + p2Name);
            Console.WriteLine("Age: " + p2Age);

            Console.WriteLine("Person 1 is " + p1Surname + ", " + p1Name);
            Console.WriteLine("Age: " + p1Age);

            Console.WriteLine();
        }
    }
}
