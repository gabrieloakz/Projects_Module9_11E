using System;

namespace ConsoleApp0
{
    internal class Progam
    {
        static void Main(string[] args)
        {
            Console.Write("Como se chama? ");
            //criar uma variável para o nome a seguir
            string NomePropio = Console.ReadLine();
            Console.WriteLine("Bem vindo(a) {0}.", NomePropio);
        }
    }
}