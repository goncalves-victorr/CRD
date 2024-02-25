using CRD.Data.Map;
using CRD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRD.Data
{
    public class GerenciamentoUsuarioDBContex : DbContext
    {
        public GerenciamentoUsuarioDBContex(DbContextOptions<GerenciamentoUsuarioDBContex> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}

//Add-Migration initialDB -Context GerenciamentoUsuarioDBContex