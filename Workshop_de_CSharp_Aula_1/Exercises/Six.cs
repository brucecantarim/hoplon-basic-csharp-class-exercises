using System;
namespace BasicCSharp.Exercises
{
    public class Six : Exercise
    {
        public static void Start()
        {
            // Primeira parte: modo de registro
            int itemQuantity;

            Console.WriteLine("How many items do you wish to register?");
            itemQuantity = int.Parse(Console.ReadLine());

            // Criando as arrays para guardar os dados
            int[] itemCodes = new int[itemQuantity];
            string[] itemNames = new string[itemQuantity];
            int[] itemPrices = new int[itemQuantity];

            for (int index = 0; index < itemQuantity; index++)
            {
                Console.Write("PRODUCT CODE: ");
                itemCodes[index] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.Write("NAME: ");
                itemNames[index] = Console.ReadLine();
                Console.WriteLine();

                Console.Write("PRICE: ");
                itemPrices[index] = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("CONFIRMING -> PRODUCT CODE: " + itemCodes[index] + " - NAME: " + itemNames[index] + " - PRICE: " + itemPrices[index]);
                Console.WriteLine();

            }

            Console.Clear();

            Console.WriteLine("WELCOME TO CASH REGISTER SOFTWARE 0.1 beta");
            Console.WriteLine();

            int clientCode;
            int totalPrice = 0;
            bool continueCheck = true;
            bool codeFound = false;

            while (continueCheck)
            {
                Console.WriteLine("Which product is the client buying?");
                clientCode = int.Parse(Console.ReadLine());

                for (int i = 0; i < itemCodes.Length; i++)
                {

                    if (itemCodes[i] == clientCode)
                    {
                        totalPrice += itemPrices[i];

                        Console.WriteLine(itemNames[i] + " costs " + itemPrices[i] + " dolars.");
                        Console.WriteLine("Total cost so far:" + totalPrice);
                        Console.WriteLine();

                        codeFound = true;
                    }
                }

                if (!codeFound)
                {

                    continueCheck = ContinueCheck("Product code not found! Try again?");

                }
                else
                {

                    continueCheck = ContinueCheck("Another product? (Type Y or N)");
                }
            }

            Console.Clear();
            Console.WriteLine("The final cost is " + totalPrice + " dollars.");
            Console.WriteLine();
        }
    }
}
