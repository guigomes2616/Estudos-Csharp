using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int i = 0;

            Console.WriteLine("Valores do Vetor: \n");

            while (i<vet.Length)
            {
                Console.WriteLine("Indice [{0}] = {1}", i, vet[i]);
                i++;
            }
        }
    }
}
