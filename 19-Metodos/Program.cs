using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1, num2, res;

            Console.Write("Metodo soma() -> Vai somar dois valores \n");

            Console.Write("\nDigite o primeiro valor: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nDigite o segundo valor: ");
            num2 = int.Parse(Console.ReadLine());

            res = soma(num1, num2); //Variavel res recebe a chamada do metodo

            Console.WriteLine("\nA soma entre {0} + {1} = {2}", num1, num2, res);
        }

        static int soma(int n1, int n2) //Metodo, tipo do retorno(int), nome (Soma) e os parametros
        {
            int res = n1 + n2;
            return res; //Return pq neste metodo, existe um retorno --- se não tivesse retorno, seria VOID
        }
    }
}
