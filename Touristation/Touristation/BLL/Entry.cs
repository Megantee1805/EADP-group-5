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
        public int Id { get; set; }

        [Column(TypeName = "text")]
        public string name { get; set; }

        [Column(TypeName = "text")]
        public string description { get; set; }

        public byte[] fileLink { get; set; }

        public double score { get; set; }

        public int rank { get; set; }

        public int votes { get; set; }

        public int ComId { get; set; }

        public int UserId { get; set; }

        public virtual Competiton Competiton { get; set; }

        public virtual User User { get; set; }
    }
}
