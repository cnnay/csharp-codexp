using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Array");

            string[] lista = new string[6];
            
            int contador = 0;
            while(contador <6){
                Console.WriteLine($"Digite o produto {contador + 1}");
                lista[contador] = Console.ReadLine();
                contador ++;
            }

            int contadorA = 0;
            Console.WriteLine("---------- LIsta de Compras ---------- ");
            while(contadorA <6){
                Console.WriteLine(lista[contadorA]);
                contadorA ++;

            }
            
        }
    }
}
