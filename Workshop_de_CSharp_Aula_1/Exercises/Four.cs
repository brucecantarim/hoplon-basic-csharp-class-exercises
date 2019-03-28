using System;
namespace BasicCSharp.Exercises
{
    public class Four : Exercise
    {
        public static void Start()
        {
            string gameName;
            int gameAge;
            string p1Name;
            string p2Name;
            int p1Age;
            int p2Age;


            Console.WriteLine("What is the name of the game we will be playing?");
            gameName = Console.ReadLine();

            Console.WriteLine("And what is the minimum age to play it?");
            gameAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Person 1, Please tell me your name:");
            p1Name = Console.ReadLine();

            Console.WriteLine(p1Name + ", Please tell me your age:");
            p1Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Person 2, Please tell me your name:");
            p2Name = Console.ReadLine();

            Console.WriteLine(p2Name + ", Please tell me your age:");
            p2Age = int.Parse(Console.ReadLine());

            if (p1Age < gameAge && p2Age < gameAge)
            {
                Console.WriteLine("Call the cops!!! I'm sorry, but both " + p1Name + " and " + p2Name + " are too young to play " + gameName + "!");
                return;
            }

            if (p1Age < gameAge)
            {
                Console.WriteLine("Call the cops!!! I'm sorry, but " + p1Name + " is too young to play " + gameName + "!");
                return;
            }

            if (p2Age < gameAge)
            {
                Console.WriteLine("Call the cops!!! I'm sorry, but " + p2Name + " is too young to play " + gameName + "!");
                return;
            }

            Console.WriteLine("Okay! You guys are old enough for " + gameName + "! Have fun!");

            Console.WriteLine();
        }
    }
}
