using System;

namespace MensagemTela
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo ao MensagemTela");

            Console.WriteLine("insira o primeiro numero");
            int T1 = int.Parse(Console.ReadLine());

            Console.WriteLine("insira o segundo numero");
            int T2 = int.Parse(Console.ReadLine());

            if (T1%2 == 0)
            {
                Console.WriteLine("o  primeiro resultado é par");
            }else
            {
                Console.WriteLine("o  segundo resultado é impar");
            }
            
            if(T2%2 == 0){ 
               Console.WriteLine("o segundo resultado é par");
            } else {
               Console.WriteLine(" o primeiro resultado é impar");
            }

            if(T1 > T2 ){
                Console.WriteLine($"{T1}");
            } else{
               Console.WriteLine($"{T2}");
            }

        }
    }
}
