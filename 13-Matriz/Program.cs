using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipo[l,c] Nome = New tipo[tam l, tam c]{ {valores}, {valores}  }

            int[,] num = new int[2, 3] { {1, 2, 3}, // Matriz do tipo int com [2 linhas, 3 colunas] com os valores já declarados, NA ORDEM
                                         {4, 5, 6} };

            Console.Write("O valor da linha [2] e coluna [3] e: {0} \n", num[1,2]);
            Console.Write("\n");
            

        }
    }
}
