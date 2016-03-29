namespace ProductWebAPI.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SampleModel : DbContext
    {
        public SampleModel()
            : base("name=SampleModel")
        {
        }

        public virtual DbSet<AnimalType> AnimalTypes { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnimalType>()
                .Property(e => e.AnimalTypeCD)
                .IsUnicode(false);

            modelBuilder.Entity<AnimalType>()
                .Property(e => e.AnimalName)
                .IsUnicode(false);

            modelBuilder.Entity<AnimalType>()
                .Property(e => e.AnimalDescription)
                .IsUnicode(false);

            modelBuilder.Entity<AnimalType>()
                .HasMany(e => e.Pets)
                .WithRequired(e => e.AnimalType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pet>()
                .Property(e => e.PetID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pet>()
                .Property(e => e.PetName)
                .IsUnicode(false);

            modelBuilder.Entity<Pet>()
                .Property(e => e.PetDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Pet>()
                .Property(e => e.PetPrice)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Pet>()
                .Property(e => e.AnimalTypeCD)
                .IsUnicode(false);
        }
    }
}
