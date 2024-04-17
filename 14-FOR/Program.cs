using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10]{1,2,3,4,5,6,7,8,9,10};

            Console.WriteLine("Valores do Vetor: \n");

            for(int i=0; i<vet.Length; i++) //Vet.Length vai pegar o tamanho do vetor
            {
                Console.WriteLine("Indice[{0}] = {1}",i, vet[i]);
            }
        }
    }
}
