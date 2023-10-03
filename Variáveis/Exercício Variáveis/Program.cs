using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace Variaveis
{
    class Program
    {
        private readonly int CONSTANTE = 10;
        static void Main(string[] args)
        {
            //Declarar variáveis
            short s = 10;
            int x = 10;
            float y = 10F;
            long l = 10;
            double z = 10D;
            decimal d = 90;
            char c = 'a';
            string frase = "programação em c#";
            bool boolean = true;
            byte b = 62;

            //Leitura dos tipos das variáveis
            Console.WriteLine(s.GetType());
            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.WriteLine(l.GetType());
            Console.WriteLine(z.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(frase.GetType());
            Console.WriteLine(boolean.GetType());
            Console.WriteLine(b.GetType());

            // Tipo atribuído em compilação
            var resultado = (x + y);
            Console.WriteLine(resultado.GetType());

            // Igual ao var, indiferente um ou outro
            dynamic res = x * z;
            Console.WriteLine(Convert.GetTypeCode(res));

            Console.WriteLine(frase);
            Console.WriteLine("\"valor char do byte 62: {0}", (char)b); //Fazer o cast
            Console.WriteLine("valor char do byte 62: {0}", Convert.ToChar(b));

            //Declarar constantes
            const int CONSTANTE = 10;
            Console.WriteLine("valor da constante: {0}", CONSTANTE);

            // É um método em C# que lê o próximo caractere ou tecla
            // pressionada no teclado e retorna um objeto do tipo ConsoleKeyInfo.
            // Ele é frequentemente utilizado em programas de console para aguardar
            // a interação do usuário antes de continuar a execução do programa.
            Console.ReadKey();

        }
    }

}




