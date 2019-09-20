using System;

namespace primeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            // aqui é onde iremos inserir o código
            Console.WriteLine("soma de dois números");
            int n1;
            int n2;
            int n3;

            Console.WriteLine("'digite o primeiro numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero");
            n3 = int.Parse(Console.ReadLine());
            int resultado = (n1+n2+n3)/3;
            Console.WriteLine($"o resutado é: {resultado}");





        }
    }
       
}
