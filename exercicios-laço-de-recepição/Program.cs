using System;

namespace exercicios_laço_de_recepição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("exercicios-laço-de-recepição");

            Console.WriteLine("digite o numero inicial");
            int contador = int.Parse(Console.ReadLine());

            int v1 = 0;
            while(v1 <=10)
            {
                Console.WriteLine($"{contador} * {v1} = {contador*v1} ");
                v1 = v1 +1;
            }
        }
    }
}
