using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DO_WHILE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhauser;
            int tent = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("Digite a senha: \n");
                senhauser = Console.ReadLine();
                tent++;

            } while (senhauser!= senha);

            Console.Write("\nSenha Correta, tentativa [{0}]\n", tent);

        }
    }
}
