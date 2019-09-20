using System;

namespace calculo_media_e_faltas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App calculo de media e faltas");
            Console.WriteLine("bem vindo a escola Senai de Informatica");

            Console.WriteLine("digite a primeira nota");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a segunda nota");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a quantidade de faltas");
            int faltas = int.Parse(Console.ReadLine());

            double media = (nota1 = nota2) / 2;

            if (media >= 50 && faltas <= 30)
            {
                Console.WriteLine("parabens voce foi aprovado");
            }
            else
            {
                Console.WriteLine("voce foi reprovado");
            }
        }
    }
}
