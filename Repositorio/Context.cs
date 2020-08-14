using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Dominio;

namespace Repositorio
{
    class Context : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaProduto> VendaProdutos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=mercado;User Id=sa;Password=12345;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VendaProduto>(vendaProduto => { 
                
                vendaProduto.HasKey(vp => new { vp.VendaId, vp.ProdutoId });

                vendaProduto.HasOne(vp => vp.Produto)
                            .WithMany(p => p.VendaProdutos)
                            .HasForeignKey(vp => vp.ProdutoId)
                            .IsRequired();

                vendaProduto.HasOne(vp => vp.Venda)
                            .WithMany(v => v.VendaProdutos)
                            .HasForeignKey(vp => vp.VendaId)
                            .IsRequired();
            });

            

           
        }
    }
}
