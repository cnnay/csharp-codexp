using System;

namespace E_mail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo!");

            string email;
            do{
                Console.WriteLine("Digite seu E-mail");
                email = Console.ReadLine();
            } while (!email.Contains("@") || !email.Contains("."));

            string senha;
            do{
                Console.WriteLine("Digite a senha");
                senha = Console.ReadLine();
            }while (senha.Length <=6);

        }
    }
}
