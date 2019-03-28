using System;
namespace BasicCSharp
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            bool continueCheck = true;

            while (continueCheck)
            {
                Run();
                continueCheck = Exercises.Exercise.ContinueCheck("Another exercise? (Type Y or N)");
            }

        }

        public static void Run()
        {

            Console.Clear();
            Console.Title = "Hoplon's Basic C# Class Exercises";

            Console.WriteLine("WELCOME TO HOPLON'S BASIC C# CLASS EXERCISES");
            Console.WriteLine();
            Console.WriteLine("Please choose the exercise number to run:");
            Console.WriteLine("0) Name and age");
            Console.WriteLine("1) Name and age for 2 persons");
            Console.WriteLine("2) Sum and multiplication between 2 numbers");
            Console.WriteLine("3) How many days have you lived?");
            Console.WriteLine("4) Age check for gaming");
            Console.WriteLine("5) What is the biggest and lowest number?");
            Console.WriteLine("6) Product register");
            Console.WriteLine("7) Factual factorial factory");
            Console.WriteLine("8) The final countdown");
            Console.WriteLine("9) Salesman simulator");
            Console.WriteLine("10) The Inverted Array");
            Console.WriteLine("11) Average, Median, Highest, Lowest");
            Console.WriteLine("12) Bank Software");
            Console.WriteLine("13) The BIG List Showdown");
            Console.WriteLine("14) Hang in there, man!");

            string exercise = Console.ReadLine();

            Console.Clear();

            switch (exercise)
            {
                case "0":
                    Exercises.Zero.Start();
                    break;
                case "1":
                    Exercises.One.Start();
                    break;
                case "2":
                    Exercises.Two.Start();
                    break;
                case "3":
                    Exercises.Three.Start();
                    break;
                case "4":
                    Exercises.Four.Start();
                    break;
                case "5":
                    Exercises.Five.Start();
                    break;
                case "6":
                    Exercises.Six.Start();
                    break;
                case "7":
                    Exercises.Seven.Start();
                    break;
                case "8":
                    Exercises.Eight.Start();
                    break;
                case "9":
                    Exercises.Nine.Start();
                    break;
                case "10":
                    Exercises.Ten.Start();
                    break;
                case "11":
                    Exercises.Eleven.Start();
                    break;
                case "12":
                    Exercises.Twelve.Start();
                    break;
                case "13":
                    Exercises.Thirteen.Start();
                    break;
                case "14":
                    Exercises.Fourteen.Start();
                    break;
                default:
                    Console.WriteLine("Congratulations, you broke the app! Now, run it again!");
                    break;
            }
        }
    }
}
