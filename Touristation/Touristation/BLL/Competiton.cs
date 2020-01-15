namespace Touristation.BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Competiton")]
    public partial class Competiton
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Competiton()
        {
            Entries = new HashSet<Entry>();
        }

        public int Id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string description { get; set; }

        [StringLength(50)]
        public string judges { get; set; }

        [StringLength(10)]
        public string winners { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int entriesNo { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entries { get; set; }
    }
}
