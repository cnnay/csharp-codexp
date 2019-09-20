using System;

namespace Do_While_com_array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do while com Array 2");

            string[] nomes = new string[5];
            string[] telefone = new string[5];
            string[] Email = new string[5];

            int contador = 0;
            while(contador < 5){
                Console.WriteLine("Digite o seu nome");
                nomes[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu telefone");
                telefone[contador] = Console.ReadLine();

                Console.WriteLine("Digite o seu Email");
                Email[contador] = Console.ReadLine();
                contador ++;
                }
                
                int contadorB = 0;
                while(contadorB <= 2){
                        Console.WriteLine($"O cliente numero" {contadorB+1} - nome: {nomes[contador]}, Tel: {telefones[contadorB]}, Email: {Emails[contadorB]}");
                        contadorB++;
                    

                }

            }
            
        }
    }

