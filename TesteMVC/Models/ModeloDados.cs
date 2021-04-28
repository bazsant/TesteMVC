using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TesteMVC.Models
{
    public partial class ModeloDados : DbContext
    {
        public ModeloDados()
            : base("name=ModeloDados")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Compra> Compra { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nome)
                .IsUnicode(false);
        }
    }
}
