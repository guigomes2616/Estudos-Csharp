using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _18_Metodo_ARRAYS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]vet1 = new int[5];
            int[]vet2 = new int[5];
            int[]vet3 = new int[5];

            int[,] mat = new int[2, 5] { { 11, 22, 00, 44, 55 },
                                         { 66, 77, 88, 99, 00 }};

            Random random = new Random(); //Objeto random do tipo Ranom - gerar numeros aleatórios
            for (int i=0; i<vet1.Length; i++)
            {
                vet1[i] = random.Next(0,50); // A cada posição do vet1, recebe o objeto, que chama a função "Next()" que gera numeros de 0 até 50 
            }

            Console.WriteLine("Elementos do Vetor 1:");

            for(int i=0; i<vet1.Length; i++)
            {
                Console.WriteLine("Indice [{0}] = {1}", i, vet1[i]); 
            }

            //public static int BinarySearch(array, valor) //Vai retornar a posição do valor no vetor
            Console.WriteLine("\nBinarySearch---------------------------------------\n");

            int procu = 34; //Variavel prou, refere ao valor procurado no vetor
            int posi = Array.BinarySearch(vet1, procu); //Variavel posi recebe a Classe "Array", que chama o metodo BinarySearch, com os parametros(vetor1, procu)

            Console.WriteLine("Valor {0} esta na posicao [{1}]\n", procu, posi);

            //public static void Copy(Array_origem, Array_destino, Qtd_elementos) //Vai copiar os elementos de um array para o outro
            Console.WriteLine("Copy---------------------------------------\n");

            Array.Copy(vet1, vet2, vet1.Length); //A partir da Classe "Array", chama o metodo Copy, com os parametros()
            Console.WriteLine("Elementos do Vetor 2: \n");

            for (int i=0; i<vet2.Length; i++)
            {
                Console.WriteLine("Valor copiado do Vetor 1: {0}", vet2[i]);
            }

            //public static void CopyTo(Array_destino, A partir desta posição) //Vai copiar os elementos de um array para o outro a partir de um determinada posição    
            Console.WriteLine("\nCopyTo---------------------------------------\n");

            vet1.CopyTo(vet3, 0); //Vet1 chama o metodo CopyTo, com os prametros ()
            Console.WriteLine("Elementos do Vetor 3: \n");

            for (int i=0; i<vet3.Length; i++)
            {
                Console.WriteLine("Valor copiado do Vetor 1: {0}", vet3[i]);
            }

            //public int GetLongLength (dimensão) // Vai retornar a qunatidade de elementos
            Console.WriteLine("\nGetLongLength---------------------------------------\n");
            int quant_elem_vet = vet1.GetLength(0); //Variavel recebe vet1, que chama o metodo GetLongLength, com o parametro 0 (primeira posição)

            Console.WriteLine("Qunatidade de elementos do vetor 1: {0}", quant_elem_vet);
          
            //public int GetLowerBound(dimensão) // Vai retornar o menor indice desse array(0)/matriz
            Console.WriteLine("\nGetLowerBound---------------------------------------\n");
            int menor_ind_vet = vet1.GetLowerBound(0); //Variavel recebe vet1, que chama o metodo GetLowerBound, com o parametro 0 (primeira linha)
            int menor_ind_mat = mat.GetLowerBound(1); //Variavel recebe mat, que chama o metodo GetLowerBound, com o parametro 1 (segunda linha)

            Console.WriteLine("Menor indice do vetor 1: {0}", menor_ind_vet);
            Console.WriteLine("\nMenor indice da matriz: {0}\n", menor_ind_mat);

            //public int GetUpperBound(dimensão) // Vai retornar o maior valor desse array/matriz
            Console.WriteLine("\nGetUpperound---------------------------------------\n");
            int maior_ind_vet = vet1.GetUpperBound(0); //Variavel recebe vet1, que chama o metodo GetUpperBound, com o parametro 0 (primeira linha)
            int maior_ind_mat = mat.GetUpperBound(1); //Variavel recebe mat, que chama o metodo GetUpperBound, com o parametro 1 (segunda linha)
          
            Console.WriteLine("Maior indice do vetor 1: {0}", maior_ind_vet);
            Console.WriteLine("Maior indice da matriz: {0}", maior_ind_mat);

            //public objetc GetValue (long indice) // Vai retornar um valor a partir de um indice
            Console.WriteLine("\nGetValue---------------------------------------\n");
            int valor0 = Convert.ToInt32(vet1.GetValue(3)); //Variavel valor0 recebe a conversão para inteiro, o valor do indice 3 do vet1 (que chama o metado)
            int valor1 = Convert.ToInt32(mat.GetValue(1,3));//Variavel valor1 recebe a conversão para inteiro, o valor da linha 1, coluna 3 da mat (que chama o metado)

            Console.WriteLine("Valor da posição 3 do Vetor 1: {0}", valor0);
            Console.WriteLine("Valor da linha 1(2), coluna 3 da Matriz: {0}", valor1);

            //public static IndexOf (array, valor) // Vai retornar o indice do primeiro valor procurado
            Console.WriteLine("\nIndexOf---------------------------------------\n");
            int indice1 = Array.IndexOf(vet1,3); //Variavel indice1 recebe o metodo, com os parametros(vetor, valor procurado)

            Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);

            //public static int LastIndexOf (array,valor) // Vai retornar o indice do ultimo valor procurado
            Console.WriteLine("\nLastIndexOf---------------------------------------\n");
            int indice2 = Array.LastIndexOf(vet1, 3); //Variavel indice2 recebe o metodo, com os parametros(vetor, valor procurado)

            Console.WriteLine("Indice do ultimo valor 3: {0}", indice1);

            //public static void Reverse (array) // Vai inverter a ordem dos elementos de um array
            Console.WriteLine("\nReverse---------------------------------------\n");

            Array.Reverse(vet1); //Chama a classe Array, que chama o metodo, com o parametro (vetor)

            foreach(int i in vet1) //Looping onde i recebe os valores de vet1
            {
                Console.WriteLine(i); //Imprime os valores de i
            }

            //public static void SetValue (objetc valor, posição) // Vai definir (setar) um valor para uma posição do vetor
            Console.WriteLine("\nSetValue---------------------------------------\n");

            vet2.SetValue(99, 0); //Vet2 chama o metodo, que vai definir 99 na posição 0

            for(int i = 0; i<vet2.Length; i++)
            {
                vet2.SetValue(0, i); //Dentro do For, o vet2 chama o metodo, que vai definir 0 para todas as posições percorridas do vetor
            }

            Console.WriteLine("\nVetor 2 Setado: "); //Imprimindo os valores de vet2
            foreach(int i in vet2)
            {
                Console.WriteLine(i);
            }

            //public static void Sort (array) // Ordernar de ordem crescente os valores do vetor
            Console.WriteLine("\nSort---------------------------------------\n");
            Array.Sort(vet1); //Classe Array, chama o metodo, com parametro o vet1
            Array.Sort(vet2);
            Array.Sort(vet3);

            Console.WriteLine("\nVetor 1: "); //Impressão do Vet1
            foreach (int i in vet1) //Looping, onde i recebe os valores de vet1
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nVetor 2: ");//Impressão do Vet2
            foreach (int i in vet2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nVetor 3: ");//Impressão do Vet3
            foreach (int i in vet3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n");
        }
    }
}
