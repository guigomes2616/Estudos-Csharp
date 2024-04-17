using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_Argumento_PARAMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //soma();
            //(10);
            soma(5, 9, 7, 2, 83, 66, 22, 4, 10, 100, 0); //Entrada (valores do vetor - flexivel de acordo com a quantidade de entradas)
        }
        static void soma(params int[] num) //Metodo soma -- params serve para entrar com mais valores -- vetor (int[sem tamanho definido]num)
        {
            int res = 0; //Inicializa res valendo 0

            if (num.Length < 1) //Se a entrada de num (tamanho do vetor) for menor que 1
            {
                Console.WriteLine("Nao existem valores a serem somados!");
            }
            else if (num.Length < 2) //Se a entrada de num (tamanho do vetor) for menor de 2
            {
                Console.WriteLine("Valores insuficientes para soma: {0}", num[0]);
            }
            else //Caso contrario
            {
                for (int i = 0; i < num.Length; i++) // Percorre o vetor num
                {
                    res += num[i]; //Vai acrescentar (somar) à res o valor da posição atual do vetor "num"
                }

                Console.WriteLine("A soma dos valores e: {0}", res);
            }
            Console.WriteLine("\n");
        }
    }
}
