using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Integrador_Senac.Models
{
    public class Produto
    {
        [Key]
        public int Produto_ID { get; set; }

        [StringLength(50)]
        public string Produto_Descricao { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Produto_Preco_Custo { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Produto_Preco_Venda { get; set; }

        public int Produto_Quantidade_Estoque { get; set; }

        public bool Produto_Ativo { get; set; }

        public List<Venda>Vendas { get; set; }
    }
}
