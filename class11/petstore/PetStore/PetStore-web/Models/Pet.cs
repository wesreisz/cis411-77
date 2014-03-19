using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PetStore_web.Models
{
    [Table("Pet")]
    public class Pet
    {
        [Key]
        public int petId { get; set; }
        public String name { get; set; }
        public String description { get; set; }
        public int quanity { get; set; }
        public double price { get; set; }
        public DateTime lastUpdateDate { get; set; }
        public String smlPicture { get; set; }
        public String lrgPicture { get; set; }
        public int personId { get; set; }
        [ForeignKey("personId")]
        public virtual Person person { get; set; }
    }

    [Table("Person")]
    public class Person
    {
        [Key]
        public int personId { get; set; }
        public String displayName { get; set; }
        public DateTime lastUpdateDate { get; set; }
        public String uid { get; set; }
        public String password { get; set; }

    }

    public class PetDBContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Person> Persons { get; set; }
    }
}