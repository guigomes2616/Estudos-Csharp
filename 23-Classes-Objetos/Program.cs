using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Classes_Objetos
{
    public class Jogador //Criação da Classe Jogador
    {
        public int energia; //Atributo publico do tipo int chamado energia
        public bool vivo;
        public string nome;

        public Jogador(string n) // Método Construtor - recebe o mesmo nome da classe, com parametro (string n -> nome)
        {
            energia = 100;
            vivo = true;
            nome = n; // Atributo nome recebe o parametro local do metodo
        }

        ~Jogador() //Método Destrutor - Quando o programa encerrar
        {
            Console.WriteLine("Jogador Destruido! \n");

        }
    }

    internal class Program
    {
        static void Main(string[] args) // Main -----------------------------------
        {
            Console.Write("Criação de Classes: \n");

            string nom1; //Cria variavel nom1

            Console.Write("\nDigite o nome do Jogador 1:"); //Pedi ao usuario digitar o nome
            nom1 = Console.ReadLine(); //nom1 recebe

            string nom2; //Cria variavel nom2

            Console.Write("\nDigite o nome do Jogador 2: "); //Pedi ao usuario digitar o nome 
            nom2 = Console.ReadLine(); //nom2 recebe

            Jogador j1 = new Jogador(nom1); //Cria um objeto j1 do tipo Jogador - New Jogador()
            Jogador j2 = new Jogador(nom2); //Cria um objeto j2 do tipo Jogador - New Jogador - parametro (variavel local "nom2)

            Console.WriteLine("\nNome do jogador 1: {0} ", j1.nome); //Imprime, buscando o atributo do objeto
            Console.WriteLine("Nome do jogador 2: {0} ", j2.nome);

            Console.WriteLine("\nEnergia do jogador 1: {0}", j1.energia);
            Console.WriteLine("Energia do jogador 2: {0}\n", j2.energia);
        }
    }
}
