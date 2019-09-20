using System;

namespace Agencia_de_turismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem Vindo");

            string[] nome = new string[5];
            string[] origem = new string[5];
            string[] destino= new string[5];
            DateTime[] data = new DateTime[5];
            int opcao = 0;
            int contador = 0;
            do{
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Cadastrar passagem");
                Console.WriteLine("2 - Listar passagem");
                Console.WriteLine("0 - sair");
                opcao = int.Parse(Console.ReadLine());

            switch(opcao){
                case 1:
                Console.WriteLine("vamos cadastrar Agora");
                string resposta = "";
                
                do{
                    if( contador< 2){ 
                    Console.WriteLine("Digite o nome do passageiro");
                    nome[ contador] = Console.ReadLine();

                    Console.WriteLine("Digite a origem ");
                    origem[ contador] = Console.ReadLine();

                    Console.WriteLine("Digite o destino");
                    destino[ contador] = Console.ReadLine();

                    Console.WriteLine("Digite digite a data do vôo");
                    data[ contador] = DateTime. Parse(Console.ReadLine());

                    Console.WriteLine("voce deseja cadastrar mais um? S/N");
                    resposta = Console.ReadLine();
                    contador++;
                    }else{
                        Console.WriteLine("Nimero de passans Execedida");
                        break;
                    }

                }while(resposta == "S");

                break;

                case 2:
                Console.WriteLine("Listando as passagens");
                int contadorB = 0;
                while(contadorB <2)
                {
                    Console.WriteLine($"Passageiro nome: {nome[contadorB]}, {origem[contadorB]}");
                    contadorB++;
                }
                break;
                case 0:

                Console.WriteLine("Obrigado por usar nossos Sistema");
                break;
                default:
                Console.WriteLine("Opção inválida");
                break;
            }

            }while(opcao != 0);

        }
    }
}