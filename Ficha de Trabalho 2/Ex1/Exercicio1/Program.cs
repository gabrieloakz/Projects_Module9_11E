//2.Declare duas variáveis string (x , y) à sua escolha e utilize as seguintes propriedades: 
//2.1.Primeiro caractere da primeira variável “x”: Substring(0, 1)
//2.2.Último caractere da variável “y”: Substring(__.Length - 1, 1))
//2.3.Todos menos o primeiro caracter da variável “x”: Substring(1))
//2.4.O terceiro elemento “x”: Substring(3, 1) ou seja 4º caracter
//2.5. Os três primeiros elementos da variável “y”: Substring(0, 3))
//2.6.Os três últimos elementos de “y”: Substring(____.Length - 3, 3))

//Code made by Gabriel Carvalho 11E TGPSI AEB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-----Exercicio Objeto String-----");

            Console.WriteLine("\n")

            string x = "arroz";
            string y = "feijao";

            // Utiliza a propriedade Substring para obter o primeiro caractere de 'x'
            string primeiroCaractereX = x.Substring(0, 1);

            // Exiba o resultado
            Console.WriteLine($"O primeiro caractere de 'x' é: {primeiroCaractereX}");



            Console.ReadKey(); //Pausa a execução sem fechar direto
        }
    }
}
