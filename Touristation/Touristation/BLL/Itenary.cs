namespace Touristation.BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Itenary")]
    public partial class Itenary
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Date { get; set; }

        [Required]
        [StringLength(10)]
        public string Time { get; set; }

        [Required]
        [StringLength(10)]
        public string NamePlace { get; set; }

        [Required]
        [StringLength(10)]
        public string Location { get; set; }
    }
}
