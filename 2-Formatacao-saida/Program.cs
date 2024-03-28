using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Formatacao_saida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCompra = 5.50;
            double valorVenda;
            double lucro = 0.1;
            string produto = "Pastel";

            valorVenda = valorCompra + (valorCompra * lucro);

            Console.Write("Produto: {0}\n", produto); //"{0}" indica o indice da variavel na ordem da impressão
            Console.Write("Valor de compra: {0:c}\n", valorCompra); //"{0:c}" o C formata o valor da variavel em valor monetário, adiconando o R$
            Console.Write("Lucro: {0:p}\n", lucro); //"{0:p}" o P formata o valor da variavek em porcentagem
            Console.Write("Valor de venda: {0:c}\n", valorVenda);

            Console.Write("\n");
        }
    }
}
