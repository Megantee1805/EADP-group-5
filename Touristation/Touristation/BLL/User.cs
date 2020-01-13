namespace Touristation.BLL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using Touristation.DAL;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Required]
        [StringLength(256)]
        public string password { get; set; }

        [StringLength(50)]
        public string country { get; set; }

        public byte[] profilePic { get; set; }

        public bool? isAdmin { get; set; }

        public bool? isBusiness { get; set; }

       
    }
}
