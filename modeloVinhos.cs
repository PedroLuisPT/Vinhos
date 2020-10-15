namespace gestaoVinho
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class modeloVinhos : DbContext
    {
        public modeloVinhos()
            : base("name=modeloVinhos")
        {
        }

        public virtual DbSet<Casta> Castas { get; set; }
        public virtual DbSet<Enologo> Enologoes { get; set; }
        public virtual DbSet<Produtor> Produtors { get; set; }
        public virtual DbSet<Regiao> Regiaos { get; set; }
        public virtual DbSet<Vinho> Vinhoes { get; set; }
        public virtual DbSet<VinhoCasta> VinhoCastas { get; set; }
        public virtual DbSet<VinhoEnologo> VinhoEnologoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Casta>()
                .HasMany(e => e.VinhoCastas)
                .WithOptional(e => e.Casta1)
                .HasForeignKey(e => e.Casta);

            modelBuilder.Entity<Enologo>()
                .HasMany(e => e.VinhoEnologoes)
                .WithOptional(e => e.Enologo1)
                .HasForeignKey(e => e.Enologo);

            modelBuilder.Entity<Produtor>()
                .HasMany(e => e.Vinhoes)
                .WithOptional(e => e.Produtor1)
                .HasForeignKey(e => e.Produtor);

            modelBuilder.Entity<Regiao>()
                .HasMany(e => e.Vinhoes)
                .WithOptional(e => e.Regiao1)
                .HasForeignKey(e => e.Regiao);

            modelBuilder.Entity<Vinho>()
                .Property(e => e.Volume)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Vinho>()
                .Property(e => e.TeorAlcoolico)
                .HasPrecision(4, 2);

            modelBuilder.Entity<Vinho>()
                .HasMany(e => e.VinhoCastas)
                .WithOptional(e => e.Vinho1)
                .HasForeignKey(e => e.Vinho);

            modelBuilder.Entity<Vinho>()
                .HasMany(e => e.VinhoEnologoes)
                .WithOptional(e => e.Vinho1)
                .HasForeignKey(e => e.Vinho);

            modelBuilder.Entity<VinhoCasta>()
                .Property(e => e.Percentagem)
                .HasPrecision(4, 2);
        }
    }
}
