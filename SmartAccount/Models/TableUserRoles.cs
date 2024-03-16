using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace SmartAccount.Models
{
    [Table("cstusrroles")]
    public class TableUserRoles
    {
        // The user roles table need to have needed roles.
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("rolename")]
        public string RoleName { get; set; }

        [Required]
        [Column("roleacess")]
        public JsonDocument RoleAcess { get; set; }

        [Required]
        [Column("roleactive")]
        public bool RoleActive { get; set; }
    }
}