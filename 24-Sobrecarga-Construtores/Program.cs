using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Sobrecarga_Construtores
{
    public class Jogador //Classe Jogador
    {
        public int energia; //Atributos
        public bool vivo;
        public string nome;

        public Jogador() //Metodo 1 - Sem parametros
        {
            energia = 100;
            vivo = true;
            nome = "Jogador";
        }

        public Jogador(string n, int ene, bool vi) //Metodo 2 - parametros(n(nome), ene(energia), vi(vivo))
        {
            energia = ene;
            vivo = vi;
            nome = n;
        }

        public Jogador(string n) //Metodo 3 - parametro (n(nome))
        {
            energia = 100;
            vivo = true;
            nome = n; 
        }

        public void info() //Metodo 4 - Impresssão
        {
            Console.WriteLine("\nNome do Jogador: {0} ",nome);
            Console.WriteLine("Energia do Jogador: {0} ", energia);
            Console.WriteLine("Status do Jogador: \n {0} ", vivo);
        } 

        ~Jogador() //Método 5 (Destrutor) - Quando o programa encerrar
        {
            Console.WriteLine("\nJogador Destruido! \n");

        }
    }

    internal class Program
    {
        static void Main(string[] args) // Main -----------------------------------
        {
            Console.Write("Criação de Classes: \n");

            Jogador j1 = new Jogador(); //Cria um objeto j1 do tipo Jogador - New Jogador() - Sem parametros (metodo1)
            Jogador j2 = new Jogador("Ace", 0, false); //Cria um objeto j2 do tipo Jogador - New Jogador() - (metodo2
            Jogador j3 = new Jogador("Luffy"); //Cria um objeto j3 do tipo Jogador - New Jogador() - (metodo3)

            j1.info(); //Objeto chama o Metodo4 - info()
            j2.info() ;
            j3.info();
        }
    }
}
