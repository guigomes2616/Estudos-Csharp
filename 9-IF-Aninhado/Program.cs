using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_IF_Aninhado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double notaB1, notaB2, notaB3, notaB4, med;

            Console.Write("Digite a sua nota do primeiro bimestre: ");
            notaB1 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a sua nota do segundo bimestre: ");
            notaB2 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a sua nota do terceiro bimestre: ");
            notaB3 = int.Parse(Console.ReadLine());

            Console.Write("\nDigite a sua nota do quarto bimestre: ");
            notaB4 = int.Parse(Console.ReadLine());

            med = (notaB1 + notaB2 + notaB3 + notaB4) / 4;

            Console.WriteLine("\nA sua nota final e: {0}",med);

            if(med >= 6.0)
            {
                if(med >= 9.0)
                {
                    Console.WriteLine("\nAprovado com Louvor!");
                }
                else
                {
                    Console.WriteLine("\nAprovado!");
                }
            }
            else
            {
                if (med >= 4.0)
                {
                    Console.WriteLine("\nRecuperação!");
                }
                else
                {
                    Console.WriteLine("\nReprovado!");
                }
            }

            Console.Write("\n");
        }
    }
}
