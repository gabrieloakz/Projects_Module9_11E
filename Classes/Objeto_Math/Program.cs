using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objeto_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Potenciação: {0}", Math.Pow(5d, 2d)); //Pow é potenciação: 2 elevado a 3 em double
            Console.WriteLine("Arredondamento: {0}", Math.Round(2.35d, 1)); //Round arrendoda cassas decimais: 2,35 arredonda 1ª casa pra cima
            Console.WriteLine("PI π: {0}", Math.PI); //PI é apenas o PI: Neste caso não é um método é um valor fixo
            Console.WriteLine("Raiz QUadrada: {0}", Math.Sqrt(25d)); //Sqrtr: Raiz quadrada dum número
            Console.ReadKey(); //Pausa a execução sem fechar direto
        }

        
    }
    
}
