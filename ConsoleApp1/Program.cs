using ConsoleApp1.Model;
using M.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.View;
namespace ConsoleApp1
{ 
    internal class Program
    {


        static void Main(string[] args)
        {


            string op;

            do
            {
                Console.WriteLine("Seja Bem Vindos \n");
                Console.WriteLine("Escolha uma Opção \n");
                Console.WriteLine("1.Adicionar Venda");
                Console.WriteLine("2.Atualizar Venda");
                Console.WriteLine("3.Remover Venda");
                Console.WriteLine("4.Listar Vendas");
                Console.WriteLine("5.Encerrar o Programa");

                int escolha = Convert.ToInt32(Console.ReadLine());

                switch (escolha)


                {

                    case 1:
                        VendasView.incluir();
                        break;


                    case 2:
                        VendasView.alterar();
                        break;


                    case 3:
                        VendasView.deletar();
                        break;

                    case 4:
                        VendasView.select();
                        break;

                        case 5:
                        VendasView.encerrar();
                        break;

                    default:
                        Console.WriteLine("Operação inválida.");

                        break;
                }

                Console.WriteLine("Deseja continuar \n");
                op = Console.ReadLine().ToLower();

            } while (op == "s");


        }
        

    }
}
