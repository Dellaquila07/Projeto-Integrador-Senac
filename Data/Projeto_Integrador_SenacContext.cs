using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_Integrador_Senac.Models;

namespace Projeto_Integrador_Senac.Data
{
    public class Projeto_Integrador_SenacContext : DbContext
    {
        public Projeto_Integrador_SenacContext (DbContextOptions<Projeto_Integrador_SenacContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_Integrador_Senac.Models.Cliente> Cliente { get; set; }

        public DbSet<Projeto_Integrador_Senac.Models.Produto> Produto { get; set; }

        public DbSet<Projeto_Integrador_Senac.Models.Venda> Venda { get; set; }
    }
}
