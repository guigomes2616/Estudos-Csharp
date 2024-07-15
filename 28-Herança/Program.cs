using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Herança
{

    class Veiculo //Classe Base
    {
        public int velocidadeMax;
        private bool ligado;
        public int rodas;

            public void ligar()
            {
                ligado = true;
            }
            
            public void desligar()
            {
                ligado = false;
            }

            public string getLigado()
            {
                if (ligado)
                {
                    return "Sim";
                }
                else
                {
                    return "Não";
                }
            }
    }

    class Carro:Veiculo //Classe Carro (derivada) herda as propriedades da classe Veiculo (base)
    {
        public string nome;
        public string cor;

            public Carro(string nome, string cor) //Metodo construtor de Carro, com argumentos (serão inseridos pelo usuario)
            {
                desligar();
                rodas = 4;
                velocidadeMax = 120;

                this.nome = nome; //Referencia as variaveis
                this.cor = cor;
            }  
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro("Ideia", "Cinza"); //Cria um objeto car1

            Console.WriteLine("Nome: {0}", car1.nome);
            Console.WriteLine("Cor: {0}", car1.cor);
            Console.WriteLine("Quantidade de rodas: {0}", car1.rodas);
            Console.WriteLine("Velocidade Maxima: {0}", car1.velocidadeMax);
            Console.WriteLine("Ligado?: {0}", car1.getLigado()); //Objeto car1 chama o metodo de Veiculo
        }
    }
}
