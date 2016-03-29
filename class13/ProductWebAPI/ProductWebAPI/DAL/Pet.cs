namespace ProductWebAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pet")]
    public partial class Pet
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal PetID { get; set; }

        [Required]
        [StringLength(100)]
        public string PetName { get; set; }

        [Required]
        [StringLength(3000)]
        public string PetDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PetPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime ListDT { get; set; }

        [Required]
        [StringLength(2)]
        public string AnimalTypeCD { get; set; }

        public virtual AnimalType AnimalType { get; set; }
    }
}
