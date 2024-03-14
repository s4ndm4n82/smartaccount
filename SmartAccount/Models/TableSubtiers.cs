using System.ComponentModel.DataAnnotations;

namespace SmartAccount.Models
{
    public class TableSubtiers
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string TierName { get; set; }

        [Required]
        public int TierTimeAmount { get; set; }

        [Required]
        public int TierUserCount { get; set; }

        [Required]
        public bool TierActive { get; set; }

        [Required]
        public DateTime TierCreateDate { get; set; }

        [Required]
        public DateTime TierModifiedDate { get; set; }        
    }
}
