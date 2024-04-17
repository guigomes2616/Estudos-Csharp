using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_FOREACH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5] { 11, 22, 33, 44, 55 };

            foreach (int num in vet) //num vai receber os valores de vet, sendo eles do mesmo tipo (int)
            {
                Console.WriteLine("Valores dos indices: {0} ",num); //Imprime os valores dentro de num
            }
        }
    }
}
