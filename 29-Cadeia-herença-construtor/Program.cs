using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _29_Cadeia_herença_construtor
{

    class Veiculo //Classe Base
    {
        public int velocidadeMax;
        private bool ligado;
        private int rodas;

        public void ligar()
        {
            ligado = true;
        }

        public void desligar()
        {
            ligado = false;
        }

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

        public string getLigado()
        {
            return (ligado ? "Sim" : "Não"); //If ternário -> Teste se uma variavel"?" é true ":" false (verdadeiro ou falso)

            /*if (ligado)
            {
                return "Sim";
            }
            else
            {
                return "Não";
            }*/
        }

        public int getRodas()
        {
            return rodas;
        }

        public void setRodas(int rodas)
        {
            if(rodas < 0)
            {
                this.rodas = 0;
            } 

            if(rodas > 40)
            {
                this.rodas = 40;
            }
            else
            {
                this.rodas = rodas;
            }
        }
    }

    class Carro : Veiculo //Classe Carro (derivada) herda as propriedades da classe Veiculo (base)
    {
        public string nome;
        public string cor;

        public Carro(string nome, string cor): base(4)//Metodo construtor de Carro -> "base(4)" vai inicializar o construtor da classe Base, que precisa de um argumento "(4)"
        {
            desligar();

            velocidadeMax = 120;
            this.nome = nome; //Referencia as variaveis
            this.cor = cor;
        }
    }

    class CarroCombate : Carro //Classe CarroCombate herda de Carro, que herda de Veiculo (Cadeia de herança)
    {
        public int municao;

        public CarroCombate():base("Carro de combate", "Vermelho") //Construtor que inicializa tambem o construtor de Veiculo (fornece as informações na instanciação) 
        {
            municao = 100;
            setRodas(6); //Altera o numero de rodas por meio do metodo setRodas
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro("Ideia", "Cinza"); //Cria um objeto car1

            Console.WriteLine("Nome: {0}", car1.nome);
            Console.WriteLine("Cor: {0}", car1.cor);
            Console.WriteLine("Quantidade de rodas: {0}", car1.getRodas()); //Objeto car1 chama o metodo de Veiculo
            Console.WriteLine("Velocidade Maxima: {0}", car1.velocidadeMax);
            Console.WriteLine("Ligado?: {0}", car1.getLigado()); //Objeto car1 chama o metodo

            Console.WriteLine("\n---------------------------------");

            CarroCombate carCombate1 = new CarroCombate();

            Console.WriteLine("\nNome: {0}", carCombate1.nome);
            Console.WriteLine("Cor: {0}", carCombate1.cor);
            Console.WriteLine("Quantidade de rodas: {0}", carCombate1.getRodas());
            Console.WriteLine("Velocidade Maxima: {0}", carCombate1.velocidadeMax);
            Console.WriteLine("Ligado?: {0}", carCombate1.getLigado());
            Console.WriteLine("Municao: {0}", carCombate1.municao);
        }
    }
}

