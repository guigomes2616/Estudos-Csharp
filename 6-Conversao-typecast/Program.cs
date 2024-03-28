using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Conversao_typecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão segura (explicita)");
            int A = 10;
            float B = A;

            Console.WriteLine(B);

            Console.WriteLine("Conversão não segura (implicita) - TYPECAST");

            float n1 = 15.3f; //Float recebe um f no final do valor atribuido
            int n2 = (int)n1; //Conversão TypeCast -> indica o tipo antes "(int)n1"

            Console.WriteLine(n2);
        }
    }
}
