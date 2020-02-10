namespace Touristation.BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entry")]
    public partial class Entry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entry()
        {
            Votes1 = new HashSet<Vote>();
        }

        public int Id { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string fileLink { get; set; }

        public double score { get; set; }

        public int votes { get; set; }

        public int rank { get; set; }

        public bool isDeleted { get; set; }

        public int ComId { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vote> Votes1 { get; set; }
    }
}
