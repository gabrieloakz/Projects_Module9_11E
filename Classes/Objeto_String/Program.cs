using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = " Progamaçao em C#";

            // Diz o tamanho do objetivo string
            Console.WriteLine("Tamanho:" + frase.Length);

            // Deixa a string maiscula
            Console.WriteLine("Maiuscula:" + frase.ToUpper());

            // Deixa a string minuscula
            Console.WriteLine("Maiuscula:" + frase.ToLower());

            // Retira espaço do inicio
            Console.WriteLine("Sem espaço no inicio:" + frase.TrimStart());

            // Substitui uma parte da string por outra definida aa seguir
            Console.WriteLine("Substituiçao:" + frase.Replace("C#", "C# by AEB"));

            // Deixa um caractere n da string
            Console.WriteLine("Caracter nº15:" + frase.Substring(15));

            // Remove uma parte da string, essa parte dentro do indexof e depois o número que quer subtrair
            Console.WriteLine("Remove:" + frase.Remove(frase.IndexOf("C#") - 1));

            // Junta uma nova string na nossa string frase
            Console.WriteLine("Concatenar:" + string.Concat(frase, "-PSI"));

            Console.WriteLine("Ambos a seguiur comnparam se sao strings iguais e retorna true ou false:");
            
            // Compara strings
            Console.WriteLine( frase == "Progamçao em c#");

            // Remove uma parte da string, essa parte dentro do indexof e depois o número que quer subtrair
            Console.WriteLine(frase.Equals("Progamaçao em c#, StringComparison.ordinal"));

            Console.ReadKey();
        }
    }
}
