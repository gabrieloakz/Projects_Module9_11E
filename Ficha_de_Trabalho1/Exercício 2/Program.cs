// Code made by Gabriel Carvalho 11E TGPSI AEB

//2.Elabora um programa que peça dois números inteiros ao utilizador e efetue as 
//seguintes operações: 
//a.Soma
//b.Multiplicação
//c.Divisão
//d.Subtração
//e.Média
//f.O resto da divisão

using System;

namespace Exercício2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o 1º número:");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o 2º número:");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma é: {0}", primeiroNumero + segundoNumero);
            Console.WriteLine("A Multiplicação é: {0}", primeiroNumero * segundoNumero);
            Console.WriteLine("A Divisão é: {0}", primeiroNumero / segundoNumero);
            Console.WriteLine("A Subtração é: {0}", primeiroNumero - segundoNumero);
            Console.WriteLine("A Média é: {0}", (primeiroNumero + segundoNumero)/2);
            Console.WriteLine("O resto da divisão é: {0}", primeiroNumero % segundoNumero);
        }
    }
}
