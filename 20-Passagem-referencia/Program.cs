using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Passagem_referencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int num2 = 10;

            dobrar1(ref num); //Chama a função dobrar1, passando o comando ref atrelado a variavel - referencia
            Console.WriteLine("Passagem por referencia: {0}", num);

            dobrar2(num2); //Chama a função, com a variavel de parâmetro
            Console.WriteLine("\nPassagem por valor: {0}", num2);

            Console.WriteLine("\n");
        }

        static void dobrar1(ref int valor) //Função do tipo void, com parâmetros "valor", que tem atrelado o comando ref
        {
            valor*=2;
        }

        static void dobrar2(int valor) //Segunda função, do jeito normal
        {
            valor*=2;
        }
    }
}
