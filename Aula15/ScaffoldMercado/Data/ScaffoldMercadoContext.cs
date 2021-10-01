using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ScaffoldMercado.Models;

namespace ScaffoldMercado.Data
{
    public class ScaffoldMercadoContext : DbContext
    {
        public ScaffoldMercadoContext (DbContextOptions<ScaffoldMercadoContext> options)
            : base(options)
        {
        }

        public DbSet<ScaffoldMercado.Models.Produto> Produto { get; set; }

        public DbSet<ScaffoldMercado.Models.Usuario> Usuario { get; set; }
        public DbSet<ScaffoldMercado.Models.VendaItem> VendaItem { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<ScaffoldMercado.Models.Venda> Venda { get; set; }
    }
}
