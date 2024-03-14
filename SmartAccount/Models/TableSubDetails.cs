using System.ComponentModel.DataAnnotations;

namespace SmartAccount.Models
{
    public class TableSubDetails
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid ClientId { get; set; }

        [Required]
        public Guid SubTierId { get; set; }

        [Required]
        public int SubLength { get; set; }

        [Required]
        public bool SubActive { get; set; }

        [Required]
        public DateTime SubStartDate { get; set; }

        [Required]
        public DateTime SubEndDate { get; set; }
    }
}
