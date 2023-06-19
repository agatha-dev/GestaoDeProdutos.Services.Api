using GestaoDeProdutos.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Infra.Data.Configurations
{
    internal class ProdutosConfiguration : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Quantidade)
                 .IsRequired();

             builder.Property(p => p.Preco)
                 .IsRequired();

            builder.HasOne(p => p.Estoque)
             .WithMany(p => p.Produtos)
             .HasForeignKey(p => p.EstoqueId);


            builder.HasOne(p => p.Categoria)
               .WithMany(p => p.Produtos)
               .HasForeignKey(p => p.CategoriaId);

        }
    }
}
