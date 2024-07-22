using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Membros_Protected
{
    class Veiculo
    {
        public int velAtual;
        private int velMax; //Private -> Restinge o acesso dos membros a classe (metodos dessa classe)
        protected bool ligado; //Protected -> Permite acesso aos membros pelas classes derivadas

        public Veiculo(int velMax) //Metodo Construtor
        {
            velAtual = 0;
            this.velMax = velMax; //Uso do this para referenciar a variavel
            ligado = false; //Acesso permitido (protected)
        }

        public bool getLigado() //Metodo que retorna ligado
        {
            return ligado;
        }

        public int getVelMax() //Metodo que retorna velMax
        {
            return velMax;
        }
    }

    class Carro : Veiculo //Classe derivada de Veiculo
    {
        public string nome;

        public Carro(string nome, int vm):base(vm) //Inicia os parametros (nome)de Carro e (vm) do construtor da classe base Veiculo
        {
            this.nome = nome;
            ligado=true; //Permitido acesso (protected) pois está sendo acessada pela classe derivada
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Carro car1 = new Carro("Bonitao", 120);
            Console.WriteLine("Nome: {0}", car1.nome);
            Console.WriteLine("Velocidade Max: {0}", car1.getVelMax());
            //Console.WriteLine("Velocidade Max: {0}", car1.velMax); -> Não permite acesso (private)
            Console.WriteLine("Ligado: {0}", car1.getLigado());
            //Console.WriteLine("Velocidade Max: {0}", car1.ligado); -> Não permite acesso (protected)
        }
    }
}
