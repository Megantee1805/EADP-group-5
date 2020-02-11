namespace Touristation.BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Itinerary")]
    public partial class Itinerary
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public TimeSpan Time { get; set; }

        [Required]
        public string NamePlace { get; set; }

        [Required]
        public string Location { get; set; }
    }
}
