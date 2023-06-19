using GestaoDeProdutos.Domain.Models;
using GestaoDeProdutos.Infra.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        ///Meotod que define o banco de dados acessado pelo ef
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "BDApiUsuarios");
        }

        ///metodo para adicionar as classes de mapeamento do projeto
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutosConfiguration());
        }

        ///propriedade para fornecer os métodos do repositorio
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Estoque> Estoques { get; set;}
        public DbSet<Categoria> Categorias { get; set; }
    }
}
