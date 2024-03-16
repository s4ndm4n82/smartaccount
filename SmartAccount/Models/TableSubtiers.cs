using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAccount.Models
{
    [Table("cstsubtiers")]
    public class TableSubtiers
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("tiername")]
        public string TierName { get; set; }

        [Required]
        [Column("tiertimeamount")]
        public int TierTimeAmount { get; set; }

        [Required]
        [Column("tierusercount")]
        public int TierUserCount { get; set; }

        [Required]
        [Column("tieractive")]
        public bool TierActive { get; set; }

        [Required]
        [Column("tiercreatedate")]
        public DateTime TierCreateDate { get; set; }

        [Required]
        [Column("tiermodifieddate")]
        public DateTime TierModifiedDate { get; set; }        
    }
}
