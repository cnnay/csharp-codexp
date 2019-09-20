using System;

namespace media_escolar
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("qual é o salario");
           float salarioAtual  = float.Parse(Console.ReadLine());
           if(salarioAtual < 990){
           double reajuste = salarioAtual * 0.3;
           double seraajustado = salarioAtual + reajuste;
           Console.WriteLine($"salario reajustado fica em:{seraajustado}"); 
        }else{           
         Console.WriteLine("voce não possui direito");
        }
        }
    }
}
