using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Code made by Gabriel Carvalho 11E TGPSI AEB

//1.Utilize o Objeto “Math” e apresente os resultados das seguintes alíneas:
//1.1.Resultado de um número elevado à potência;
//1.2.Arredonde um número do tipo “double”;
//1.3.Retorne o valor de PI;
//1.4.Raiz quadrada de um número;
//1.5.Retorne o menor valor acima de um número inserido;
//1.6.Retorne o maior valor acima de um número inserido;
//1.7.Retorne o valor mínimo de dois números inseridos;
//1.8.Retorne o valor máximo de dois números inseridos;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pow: {0}", Math.Pow(2d, 5d));
            Console.WriteLine("Round: {0}", Math.Round(4.79, 1));
            Console.WriteLine("PI: {0}", Math.PI);
            Console.WriteLine("Raiz Quadrada: {0}", Math.Sqrt(25));
            Console.WriteLine("Retorne o menor valor acima de um número inserido: {0}", Math.Floor(5.3));
            Console.WriteLine("Retorne o maior valor acima de um número inserido: {0}", Math.Ceiling(7.8));
            Console.WriteLine("Retorne o valor mínimo de dois números inseridos: {0}", Math.Min(6, 9));
            Console.WriteLine("Retorne o valor máximo de dois números inseridos: {0}", Math.Max(6, 9));
            Console.ReadKey();

        }
    }
}
