//1.Utilize o Objeto “Math” e apresente os resultados das seguintes alíneas:
//1.1.Resultado de um número elevado à potência;
//1.2.Arredonde um número do tipo “double”;
//1.3.Retorne o valor de PI;
//1.4.Raiz quadrada de um número;
//1.5.Retorne o menor valor acima de um número inserido;
//1.6.Retorne o maior valor acima de um número inserido;
//1.7.Retorne o valor mínimo de dois números inseridos;
//1.8.Retorne o valor máximo de dois números inseridos;

// Code made by Gabriel Carvalho 11E TGPSI AEB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t-----Exercicio Objeto Math-----");

            Console.WriteLine("\n");
            
            Console.WriteLine("\tPotenciação: {0}", Math.Pow(10.5, 3)); //Base 10.5 elevado a 3
            
            Console.WriteLine("\tArredondamento: {0}", Math.Round(9.98d, 1)); //Arredonda 9.98 double para 10
            
            Console.WriteLine("\tPI π: {0}", Math.PI); //PI é apenas o PI: Neste caso não é um método é um valor fixo
            
            Console.WriteLine("\tRaiz Quadrada: {0}", Math.Sqrt(25d)); //Sqrtr: Raiz quadrada de um número
            
            Console.WriteLine("\tMenor Valor de um Número(2.5): {0}", Math.Floor(2.5)); //Retorna o menor valor acima de um número inserido
            
            Console.WriteLine("\tMaior Valor de um Número(2.5): {0}", Math.Ceiling(2.5)); //Retorna o maior valor acima de um número inserido
            
            Console.WriteLine("\tValor mínimo de dois números(2,6): {0}", Math.Min(2, 6)); //Retorna o valor mínimo de dois números inseridos
            
            Console.WriteLine("\tValor máximo de dois números(2,6): {0}", Math.Max(2, 6)); //Retorna o valor máximo de dois números inseridos
            
            Console.ReadKey(); //Pausa a execução sem fechar direto
        }
    }
}
