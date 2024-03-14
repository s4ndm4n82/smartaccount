using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace SmartAccount.Models
{
    public class TableUserRoles
    {
        // The user roles table need to have needed roles.
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