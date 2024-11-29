using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Controller
{

    public class Context : DbContext
    {
        public Context() : base(@"Server=JUN0675601W10-1\BDSENAC; Database=LojaProdutos; user id=senaclivre; password = senaclivre")
        {
            // Desabilita a criação automática de tabelas
            Database.SetInitializer<Context>(null);
        }

        public DbSet<Vendas> Vendas { get; set; }
    }
}
