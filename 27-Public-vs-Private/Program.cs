using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Public_vs_Private
{
    class Jogador
    {
        private int energia; //Private - Só pode ser acesso dentro da classe
        private string nome;

        public Jogador(string nome)
        {
            this.nome = nome;
            energia = 100;
        }

        public int getEnergia() //Metodo para Obter a propriedaade energia da classe
        {
            return energia;
        }

        public string getNome() //Meotodo para Obter a propriedade nome da classe
        {
            return nome;
        }

        public void setEnergia(int energ) 
        {
            if (energ < 0) //Se energia for menor que 0
            {
                if(energia+energ < 0) //Se energia(100) + energ (valor inserido) for menor que 0
                 {
                    energ = 0; //Atribui o valor minino - não aceita energia negativa
                }
                else
                {
                    energia += energ; //Energia recebe o valor inserido
                }
            }
            else if (energ > 0)
            {
                if(energia+energ > 100) //Se energia(100) + energ(valor inserido) for maior que 100
                {
                    energ = 100; //Atribui o valor máximo
                }
                else
                {
                    energia += energ;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Guilherme");
            j1.setEnergia(-30); //Acessa o metodo setEnergia para alterar o valor

            //Imprime

            Console.WriteLine("Nome...: {0}", j1.getNome()); //Os objetos chamam os metodos -> forma privada
            Console.WriteLine("Energia...: {0}", j1.getEnergia());
          //Console.WriteLine("Energia...: {0}", j1.energia); -> A propriedade é chamada de forma publica
        }
    }
}
