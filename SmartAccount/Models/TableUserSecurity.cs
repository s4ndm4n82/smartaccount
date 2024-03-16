using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAccount.Models
{
    [Table ("cstusrsecurity")]
    public class TableUserSecurity
    {
        [Key]
        [Column ("id")]
        public Guid Id { get; set; }

        [Required]
        [Column ("userid")]
        public Guid UserId { get; set; }

        [Required]
        [Column ("userpassword")]
        public byte[] UserPassword { get; set; }
    }
}
