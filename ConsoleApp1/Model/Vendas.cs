using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    [Table("Vendas")]
    public class Vendas
    {
        internal object vendas;
        internal object Id;

        public int id { get; set; }

        [Column("Produto")]
        public string Produto { get; set; }

        [Column("Descricao")]
        
        public string Descricao { get; set; }

        [Column("DataVenda")]
        public DateTime Date { get; set; }


        [Column("valor")]
        public decimal Valor { get; set; }
    }
}
