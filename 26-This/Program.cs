using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_This
{
    class Calculos
    {
        public int v1;
        public int v2;

        public Calculos(int v1, int v2)
        {
            this.v1 = v1; //This serve para referenciar as variaveis (propriedades) que são aos do objeto (classe) 
            this.v2 = v2;
        }

        public int Somar()
        {
            return v1 + v2;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculos calculos = new Calculos(10, 2);

            Console.WriteLine(calculos.Somar());
        }
    }
}   
