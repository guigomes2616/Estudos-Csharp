using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Constantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string nome = "Guilherme";
            const double pi = 3.1415;

            //nome = "Giulia"; //Não se altera Constantes

            Console.Write("Nome: {0}\n",nome);
            Console.Write("Pi: {0}\n", pi);

            Console.Write("\n");
        }
    }
}
