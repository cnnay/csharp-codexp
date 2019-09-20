using System;

namespace rodizioVeicular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App rodizioVeicular");
            Console.WriteLine("bem vindo ao rodizio");

            Console.WriteLine("digite o ultimo numero da placa");
           string placa = Console.ReadLine();

           int caracteres = placa.Length;

          int final = int.Parse(placa.Substring(caracteres - 1));
          Console.WriteLine("$ A posição 0 é: {final}");

            if (placa ==0 || placa == 1)
            {
                Console.WriteLine("seu dia é segunda-feira");
            }
            else if(placa ==2 || placa == 3){
                Console.WriteLine("seu dia é terça-feira");
            }
            else if(placa ==4 || placa == 5){
                Console.WriteLine("seu dia é quarta-feira");
            }
            else if(placa ==6 || placa ==7){
                Console.WriteLine("seu dia é quinta-feira");
            }
            else if(placa ==8 || placa ==9){
                 Console.WriteLine("seu dia é sexta-feira");
            }
            Console.WriteLine("digite o ultimo digito");
            





        }
    }
}
