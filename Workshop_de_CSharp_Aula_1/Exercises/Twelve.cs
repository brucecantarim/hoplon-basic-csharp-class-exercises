using System;
namespace BasicCSharp.Exercises
{
    public class Twelve : Exercise
    {
        public static void Start()
        {
            // Vários Bancos
            // Vários Clientes

            // Cliente -> CPF, Nome e Limite de Crédito

            // Ex.: Banco 2030
            // Total de contas + 1 : 0
            // Joãozinho CPF 123.456.789.0 Limite 1.000 Saldo 0 (Limite + Saldo definem o máximo da transação)
            // Número da conta: 20301
            // Dígito verificador: (2*1) (0*2) (3*3) (0*4) (1*5)
            //                       2     0     9     0     5   =  16 % 11
            // Número final da conta: 20301-5

            // Ler a quantidade de Bancos
            // Ler os clientes do Banco
            // para cada cliente, calcular a conta
            // Mostrar opções de transação - Creditar, Saldo e Debitar (Limitador)

            // int[] Bancos, string[] CPFs, int[] Limites, string[] Nomes, string[] Contas, int[] Saldo

            int[] banks = ReadIntArray("How many banks will you register?", "Enter the bank code:");

            int totalClients = ReadNumber("How many clients will you register?");
            int totalAccounts = 0;

            string[] names = new string[totalClients];
            string[] contas = new string[totalClients];
            string[] cpfs = new string[totalClients];
            int[] limit = new int[totalClients];
            int[] balance = new int[totalClients];


            for (int i = 0; i < totalClients; i++)
            {

                names[i] = ReadString("What is the name of the client?");
                cpfs[i] = ReadString("Enter the client's social number:");
                limit[i] = ReadNumber("Enter the client's credit limit:");
                balance[i] = ReadNumber("Enter the client's current balance");

                totalAccounts++;



            }



        }
    }
}
