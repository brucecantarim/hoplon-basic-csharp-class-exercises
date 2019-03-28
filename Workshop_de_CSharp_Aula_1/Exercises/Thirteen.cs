using System;
using System.Collections.Generic;

namespace BasicCSharp.Exercises
{
    public class Thirteen : Exercise
    {
        /*
         *  1 - Encontrar N#
         *  2 - Mostrar < N#
         *  3 - Remover N#
         *  4 - Remover Repetidos
         *  5 - Sair
         */

        public static void Start()
        {
            List<int> numberList = GetNumberList();

            int choice = GetUserOption();

            Console.WriteLine("Processing...");
        }

        public static List<int> GetNumberList() {

            bool continueCheck = true;
            List<int> numberList = new List<int>();

            while(continueCheck) {
                int number = ReadNumber("Please input a number: ");
                numberList.Add(number);
                continueCheck = ContinueCheck("Add another number? (Y or N)");
            }

            return numberList;
        }

        public static int GetUserOption()
        {
            Console.Clear();
            Console.Title = "The BIG List Showdown!";

            Console.WriteLine();
            Console.WriteLine("What do you wanna do with your list:");
            Console.WriteLine("1) Let's search for a number");
            Console.WriteLine("2) I wanna see the biggest number");
            Console.WriteLine("3) I feel like deleting something today");
            Console.WriteLine("4) No clones in my list, please!");
            Console.WriteLine("5) Nothing, I just wanna exit.");
            Console.WriteLine();

            int choice = ReadNumber("Input the number: ");

            return choice;
        }

        public static string FindNumber(List<int> numberList) {
            int number = ReadNumber("Which number do you wanna search for?");
            bool numberFound = numberList.Contains(number);

            string answer = numberFound ? "Yes, the number is in the list!" : "Sorry, nothing found!";

            return answer;

        }
    }
}
