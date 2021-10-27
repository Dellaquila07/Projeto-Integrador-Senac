using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Integrador_Senac.Models
{
    public class Venda
    {
        [Key]
        public int Venda_ID { get; set; }

        public int Cliente_ID { get; set; }
        public virtual Cliente Cliente { get; set; }

        public int Produto_ID { get; set; }
        public virtual Produto Produto { get; set; }

        public int Venda_Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Venda_Preco { get; set; }

        public DateTime Venda_Data { get; set; }
    }
}
