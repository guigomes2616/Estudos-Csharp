using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Lendo_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1, valor2, soma;

            Console.Write("Digite o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine()); //int.Parse faz a conversão dos tipos, por ser: double.parse/string.parse...

            Console.Write("\nDigite o segundo valor: ");
            valor2 = Convert.ToInt16(Console.ReadLine()); //Convert.toint16 faz a conversão para o tipo indicado (int) - 16 = tamanho do int

            soma = valor1 + valor2;

            Console.Write("\nA soma entre {0} e {1} e igual a: {2}", valor1, valor2, soma);
            
            Console.Write("\n");
        }
    }
}
