using System;

namespace laço_de_repetiçaõ_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("laço de recepção while");
            Console.WriteLine("digite um numero");
            int contador = int.Parse(Console.ReadLine());
            while(contador<= 10){
                Console.WriteLine(contador);
                contador = contador + 1;
            }
            Console.WriteLine("FIm");
        }
    }
}
