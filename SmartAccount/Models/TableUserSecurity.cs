using System.ComponentModel.DataAnnotations;

namespace SmartAccount.Models
{
    public class TableUserSecurity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public byte[] UserPassword { get; set; }
    }
}
