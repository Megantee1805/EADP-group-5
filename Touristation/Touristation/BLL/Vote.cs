namespace Touristation.BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vote
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int EntryId { get; set; }

        public virtual Entry Entry { get; set; }

        public virtual User User { get; set; }
    }
}
