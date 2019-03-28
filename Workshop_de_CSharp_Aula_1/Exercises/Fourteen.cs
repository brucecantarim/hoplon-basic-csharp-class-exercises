using System;
using System.IO;
namespace BasicCSharp.Exercises
{
    public class Fourteen
    {

        // Criar um arquivo
        // Usuário vai cadastrar palavras/dicas
        // Forca - errou 3x, perdeu o jogo
        // Menu - 1) Mostra a Dica - 2) Jogar
        // Informações separadas por ;

        public void Start()
        {
            string[] lines = File.ReadAllLines(@"c:\tmp\text.txt");

            Random random = new Random();
            int index = random.Next(lines.Length);
            string line = lines[index];

            string[] parsedLine = lines.Split(';');
            string word = parsedLine[0];
            string tip = parsedLine[1];


        }
    }
}
