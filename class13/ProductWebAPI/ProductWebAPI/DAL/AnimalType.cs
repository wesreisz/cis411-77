namespace ProductWebAPI.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AnimalType")]
    public partial class AnimalType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnimalType()
        {
            Pets = new HashSet<Pet>();
        }

        [Key]
        [StringLength(2)]
        public string AnimalTypeCD { get; set; }

        [Required]
        [StringLength(100)]
        public string AnimalName { get; set; }

        [Required]
        [StringLength(3000)]
        public string AnimalDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pet> Pets { get; set; }
    }
}
