namespace Touristation.BLL
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Itinerary")]
    public partial class Itinerary
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
