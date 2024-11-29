using ConsoleApp1.Model;
using M.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    public class VendasView
    {

        public static void incluir()
        {
            string vProduto, vDescricao;
            DateTime vDate;
            decimal vValor;

            Console.WriteLine("Digite o produto : ");
            vProduto = Console.ReadLine();
            Console.WriteLine("Descrição do produto : ");
            vDescricao = Console.ReadLine();
            Console.WriteLine("Data da venda : ");
            vDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Valor da venda ");
            vValor = Decimal.Parse(Console.ReadLine());



            using (var contexto = new Context())
            {
                contexto.Vendas.Add(new Vendas()
                {

                    Produto = vProduto,
                    Descricao = vDescricao,
                    Date = vDate,
                    Valor = vValor
                });
                contexto.SaveChanges();
                Console.WriteLine("Produto adicionado ");


            }

            Console.ReadKey();


        }

        public static void alterar()
        {
            using (var contexto = new Context())
            {

                Console.WriteLine("Digite o ID que deseja alterar: ");
                var busca = contexto.Vendas.Find(int.Parse(Console.ReadLine()));
                Console.WriteLine(busca.Produto);
                Console.WriteLine(busca.Descricao);
                Console.WriteLine(busca.Date);
                Console.WriteLine(busca.Valor);
                Console.WriteLine("Alterar produto: ");
                busca.Produto = Console.ReadLine();
                Console.WriteLine("Alterar descricao do produto: ");
                busca.Descricao = Console.ReadLine();
                Console.WriteLine("Alterar a data do produto : ");
                busca.Date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Alterar Valor do produto : ");
                busca.Valor = decimal.Parse(Console.ReadLine());

                contexto.SaveChanges();
                Console.WriteLine("Produto alterado com sucesso ");

            }
        }




       public static void deletar()
        {

            using (var contexto = new Context())
            {
                Console.WriteLine("Digite ID que deseja apagar: ");
                var busca = contexto.Vendas.Find(int.Parse(Console.ReadLine()));
                Console.WriteLine($"Voçê esta prestes a apagar o usuario:  {busca.Produto}");
                Console.WriteLine("Tem certeza que deseja apagar, digite S para apagar ou qualquer tecla para anular ");
                var apaga = Console.ReadLine();

                if (apaga == "S")

                {

                    contexto.Vendas.Remove(busca);
                    contexto.SaveChanges();
                    Console.WriteLine("Prod");
                }

                else
                {
                    Console.WriteLine("Operação anulada");


                }

            }


        }









        public static void select()
        {
            using (var contexto = new Context())
            {
                // Exemplo de consulta simples para selecionar todos os usuários da agenda


                var Vendas = contexto.Vendas.ToList();
                //  var agenda = contexto.Agenda.Where(p=>p.Id==1).ToList();
                //var agenda = from a in contexto.Agenda    
                //    where a.Nome=="Marcos"
                //    select a;

                foreach (var listaVendas in Vendas)
                {
                    Console.WriteLine($"ID: {listaVendas.Id} Produto: {listaVendas.Produto} Descricao:{listaVendas.Descricao} Data Venda:{listaVendas.Date} Valor: {listaVendas.Valor}"
                        );
                }

            }

        }

        internal static void encerrar()
        {
            Console.WriteLine("O programa vai ser encerrado.");
            Environment.Exit(0);  // Encerra o programa com código de saída 0
        }
    
    
    
    
    }

}
