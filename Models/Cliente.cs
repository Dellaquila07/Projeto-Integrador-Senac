using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Integrador_Senac.Models
{
    public class Cliente
    {
        [Key]
        public int Cliente_ID { get; set; }

        [StringLength(30)]
        public string Cliente_Nome { get; set; }

        [StringLength(40)]
        public string Cliente_Sobrenome { get; set; }

        public DateTime Cliente_Dt_Nasc { get; set; }

        [StringLength(15)]
        public string Cliente_Celular { get; set; }

        [StringLength(70)]
        public string Cliente_Email { get; set; }

        public List<Venda>Vendas { get; set; }
    }
}
