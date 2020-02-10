namespace Touristation.BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Event")]
    public partial class Event
    {
        public int Id { get; set; }

        [Required]
        public string location { get; set; }

        public int rate { get; set; }

        [Required]
        public string comment { get; set; }
    }
}
