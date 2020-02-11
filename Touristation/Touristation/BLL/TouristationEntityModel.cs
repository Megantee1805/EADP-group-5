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

        public virtual DbSet<Competition> Competitions { get; set; }
        public virtual DbSet<Entry> Entries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Itinerary> Itineraries { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Competition>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Competition>()
                .Property(e => e.prize)
                .IsUnicode(false);

            modelBuilder.Entity<Competition>()
                .Property(e => e.JudgingCriteria)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .Property(e => e.fileLink)
                .IsUnicode(false);

            modelBuilder.Entity<Entry>()
                .HasMany(e => e.Votes1)
                .WithRequired(e => e.Entry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<Event>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<Itinerary>()
                .Property(e => e.NamePlace)
                .IsUnicode(false);

            modelBuilder.Entity<Itinerary>()
                .Property(e => e.Location)
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
                .HasMany(e => e.Competitions)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Entries)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Votes)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
