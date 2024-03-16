using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAccount.Models
{
    [Table("cstsubdetails")]
    public class TableSubDetails
    {
        [Key]
        [Column ("id")]
        public Guid Id { get; set; }

        [Required]
        [Column ("clientid")]
        public Guid ClientId { get; set; }

        [Required]
        [Column ("subtierid")]
        public Guid SubTierId { get; set; }

        [Required]
        [Column ("sublength")]
        public int SubLength { get; set; }

        [Required]
        [Column ("subactive")]
        public bool SubActive { get; set; }

        [Required]
        [Column ("substartdate")]
        public DateTime SubStartDate { get; set; }

        [Required]
        [Column ("subenddate")]
        public DateTime SubEndDate { get; set; }
    }
}
