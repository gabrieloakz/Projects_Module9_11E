// Code made by Gabriel Ferreira Carvalho 11E TGPSI AEB

//2.Declare duas variáveis string (x , y) à sua escolha e utilize as seguintes propriedades: 
//2.1.Primeiro caractere da primeira variável “x”: Substring(0, 1)
//2.2.Último caractere da variável “y”: Substring(__.Length - 1, 1))
//2.3.Todos menos o primeiro caracter da variável “x”: Substring(1))
//2.4.O terceiro elemento “x”: Substring(3, 1) ou seja 4º caracter
//2.5. Os três primeiros elementos da variável “y”: Substring(0, 3))
//2.6.Os três últimos elementos de “y”: Substring(____.Length - 3, 3))

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

            string x = "arroz";
            string y = "feijao";

            Console.WriteLine("\t-----Exercicio Objeto String-----");

            Console.WriteLine(" \n\tstring x = \"arroz\";\r\n        string y = \"feijao\";");

            Console.WriteLine("\n\tPrimeiro caractere da primeira variável “x”:" + x.Substring(0, 1));
            Console.WriteLine("\tÚltimo caractere da variável 'y': " + y.Substring(y.Length - 1, 1));
            Console.WriteLine("\tTodos menos o primeiro caracter da variável 'x':" + x.Substring(1));
            Console.WriteLine("\tO terceiro elemento 'x':" + x.Substring(3, 1));
            Console.WriteLine("\tOs três primeiros elementos da variável 'y':" + y.Substring(0, 3));
            Console.WriteLine("\tOs três últimos elementos de 'y':" + y.Substring(y.Length -3, 3));
            Console.ReadKey(); //Pausa a execução sem fechar direto
        }
    }
}

