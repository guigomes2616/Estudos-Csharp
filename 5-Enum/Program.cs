using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _5_Enum
{
    internal class Program
    {

        enum diasSemana {Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado}; //Cria um enum(enumerador personalizado) com os valores "dias da semana"

        static void Main(string[] args)
        {
            diasSemana ds = (diasSemana)5; //Variavel ds, do tipo (diasSemana) que recebe o indice di enum convertido

            Console.Write(ds); //Imprime o valor de ds

            Console.Write("\n");
        }
    }
}
