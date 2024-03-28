using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = { 1, 2, 3 }; //Neste formato, o tamanho do vetor é indicado pelos valores já declarados -> 3
            int[] num2 = new int[5] { 10, 20, 30, 40, 50 }; //Neste formato, é preciso usar o New int, que delclara o tamanho do vetor, e declara os valores
            int[] num3 = new int[5]; //Neste formato, inicializa o vetor de tamanho 5, mas sem declarar os valores

         //  Tipo[]    Nome   =  New tipo[tam] {valores};
            string[] veiculos = new string[3] {"Carro", "Aviao", "Navio"};

            Console.Write("Valor da posicao [0] do vetor: {0} \n ", veiculos[0]);
            Console.Write("\n");
        }
    }
}
