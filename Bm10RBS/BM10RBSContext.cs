namespace Bm10RBS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BM10RBSContext : DbContext
    {
        public BM10RBSContext()
            : base("name=BM10RBSContext")
        {
        }

        public virtual DbSet<BM10Rain> BM10Rain { get; set; }
        public virtual DbSet<BM10Temperatuur> BM10Temperatuur { get; set; }
        public virtual DbSet<BM10V2> BM10V2 { get; set; }
        public virtual DbSet<BM10Voorspellingen> BM10Voorspellingen { get; set; }
        public virtual DbSet<BM10Wind> BM10Wind { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
