using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inteiros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            foreach (int i in inteiros)
                Console.WriteLine(i);

            //Declaração de números reais em double
            double[] reais = new double[5];
            reais[0] = 24d;
            reais[1] = 24.65d;
            reais[2] = 45.9d;
            reais[3] = 22d;
            reais[4] = 221.1d;
            foreach (double i in reais)
                Console.WriteLine(i);

            //Declaração de strings em arrays
            string[] palavras = new string[] { "abc", "def", "pod", "crê" };

            foreach (string i in palavras)
                Console.WriteLine(i);

            //Verificar se existe o valor no array
            Console.WriteLine(palavras.Contains("def"));

            //Mostrar tamanho do array
            Console.WriteLine(palavras.Length);

            //Declaração de arrays multidimesionais: Primeira posição indica a linha e a segunda a coluna
            int[,] multiInteiros = new int[,] { { 1, 2, 3, 4 } , { 5, 6, 7, 8 } };
            Console.WriteLine(multiInteiros[0, 0]); //Na linha 0 e coluna 0 há o número 1

            //Declaração  arrays de arrays: jagged arrays
            int[][] jaggedInteiros = new int[3][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 6, 7, 8 }, new int[] { 9, 10, 11, 12 } };
            Console.WriteLine(jaggedInteiros[0][2]);
            
            Console.ReadKey();
        }
    }
}
