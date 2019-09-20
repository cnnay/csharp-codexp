using System;

namespace CalculoMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CalculoMenu");

            Console.WriteLine("digite o primeiro numero");
            int A1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");
            int A2 = int.Parse(Console.ReadLine());


             Console.WriteLine(" (A) soma de 2 numeros");
 
             Console.WriteLine(" (B) subtração do primeiro numero");

             Console.WriteLine(" (C) subtração do segundo numero");

             Console.WriteLine(" (D) mutiplicação dos dois numeros");

             Console.WriteLine(" (E) divisão do primeiro numero");

             Console.WriteLine(" (F) divisão do segundo numero");

            string resposta = Console.ReadLine();

             switch(resposta){
                 case "A":
                 Console.WriteLine($"a soma {A1+A2}");
                 break;

                 case "B":
                 Console.WriteLine($" a primeira subtração {A1-A2}");
                 break;
                 
                  case "C":
                 Console.WriteLine($" a segunda subtração {A1-A2}");
                 break;

                  case "D":
                 Console.WriteLine($" a mutiplicação {A1*A2}");
                 break;

                  case "E":
                 Console.WriteLine($" a primeira divisão {A1/A2}");
                 break;

                  case "F":
                 Console.WriteLine($" a segunda divisão {A1/A2}");
                 break;

                 






             
             }





        }
    }
}
