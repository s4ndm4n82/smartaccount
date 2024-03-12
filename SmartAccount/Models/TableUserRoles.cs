using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace SmartAccount.Models
{
    public class TableUserRoles
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string RoleName { get; set; }

        [Required]
        public JsonDocument RoleAcess { get; set; }

        [Required]
        public bool RoleActive { get; set; }
    }
}