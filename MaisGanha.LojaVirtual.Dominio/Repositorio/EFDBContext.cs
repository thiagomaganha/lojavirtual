using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaisGanha.LojaVirtual.Dominio.Entidades;

namespace MaisGanha.LojaVirtual.Dominio.Repositorio
{
    public class EFDBContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produto");
        }
    }
}
