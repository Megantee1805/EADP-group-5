namespace Touristation.BLL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TouristationEntityModel : DbContext
    {
        public TouristationEntityModel()
            : base("name=TouristationEntityModel")
        {
        }

        public virtual DbSet<Competiton> Competitons { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competiton>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Competiton>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Competiton>()
                .Property(e => e.judges)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Competiton>()
                .Property(e => e.winners)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Competiton>()
                .HasMany(e => e.Entries)
                .WithRequired(e => e.Competiton)
                .HasForeignKey(e => e.ComId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.fileLink)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.country)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Competitons)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Entries)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
