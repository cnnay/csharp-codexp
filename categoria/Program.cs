using System;

namespace categoria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("qual sua idade");
            int idade = int.Parse(Console.ReadLine());
            if(idade<=7){
                Console.WriteLine("categoria infatil A");

            }else if(idade<=10){
                Console.WriteLine("categoria infantil B");

            }else if(idade<=13){
              Console.WriteLine("categoria juvenil A"); 

            }else if(idade<=17){
                Console.WriteLine("categoria juvenil B");
                
            }else{
                Console.WriteLine("categoria adulto");
            }
        }
    }
}
