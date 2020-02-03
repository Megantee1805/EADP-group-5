namespace Touristation.BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Competition")]
    public partial class Competition
    {
        public int Id { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string description { get; set; }

        [StringLength(50)]
        public string judges { get; set; }

        [StringLength(50)]
        public string winners { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public int entriesNo { get; set; }

        public string JudgingCriteria { get; set; }

        public bool isDeleted { get; set; }

        public bool isCompleted { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
