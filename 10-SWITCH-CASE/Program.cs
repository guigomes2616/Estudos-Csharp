using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_SWITCH_CASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo;
            char escolha;

            Console.Write("Viagem: de Sao Paulo /SP até Fortaleza /CE \n");
            Console.Write("\nEscola o meio de transporte: \n");
            Console.Write("\nDigite [a] para Aviao \n");
            Console.Write("\nDigite [b] para Carro \n");
            Console.Write("\nDigite [c] para Onibus \n");

            Console.Write("\nQual a sua escolha? ");

            escolha = char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;

                case 'b':
                case 'B':
                    tempo = 480;
                    break;

                case 'c':
                case 'C':
                    tempo = 660;
                    break;

                default:
                    tempo = -1;
                    break;
            }

            if(tempo <= 0)
            {
                Console.Write("\nTransporte invalido!\n");

            }
            else
            {
                Console.Write("\nO tempo de viagem de acordo com o transporte indicado e de: {0} minutos \n", tempo);
            }
            Console.Write("\n");
        }
    }
}
