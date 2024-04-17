using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _21_Argumento_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divid, divis, quoc, res;

            divid = 8;
            divis = 3;
            quoc = divide(divid, divis, out res); //Informa que res também está envolvido na operação, buscando seu valor (out res)

            Console.WriteLine("Informacoes da divisao: \n");
            Console.WriteLine("\nDividendo {0} \nDivisor {1} \nQuociente {2} \nResto {3}", divid, divis, quoc, res);
            Console.WriteLine("\n");
        }

        static int divide(int dividendo, int divisor, out int resto) //Parâmetro "out int resto" é um argumento de saida, onde vai receber o valor de "resto" na função
        {
            int quociente;

            quociente = dividendo / divisor; //Operação do valor inteiro da divisão
            resto = dividendo % divisor; //Operação do resto da divis~]ao
            return quociente; //Return - Retorna somente um valor
        }
    }
}
