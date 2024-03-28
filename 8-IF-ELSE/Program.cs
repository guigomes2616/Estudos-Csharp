using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_IF_ELSE
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

            if (med >=0 && med <= 4.0) {
                Console.Write("\nSua nota final e: {0} - REPROVADO!", med);

            }else if (med < 6.0){
                Console.Write("\nSua notal final e: {0} - RECUPERACAO!", med);

            }else if (med <=10)
            {
                Console.Write("\nSua nota final e: {0} - APROVADO!",med);
            }

            Console.Write("\n");
        }
    }
}
