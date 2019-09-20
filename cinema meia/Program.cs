using System;

namespace cinema_meia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App cinema meia");
            Console.WriteLine("bem vindo ao cinema");

            Console.WriteLine("digite a primeira idade");
            int idade1 = int.Parse(Console.ReadLine());

            if (idade1 <= 18 && idade1 >= 60)
            {

                Console.WriteLine("entrada meia aprovada");

            }
            else
            {
                Console.WriteLine("entrada meia negada");

            }


        }
    }
}
