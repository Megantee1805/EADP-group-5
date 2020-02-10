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

        public int? judges { get; set; }

        public int? winners { get; set; }

        public string prize { get; set; }

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
