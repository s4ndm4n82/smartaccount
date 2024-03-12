using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace SmartAccount.Models
{
    public class TableUsers
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; }

        [Required]
        public Guid UserRole { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string UserEmail { get; set; }

        [Required]
        public Guid CstViewId { get; set; }

        [Required]
        public JsonDocument UserSettings { get; set; }

        [Required]
        public DateTime UserCreationDate { get; set; }

        [Required]
        public DateTime UserModifyDate { get; set; }

        [Required]
        public bool Banned { get; set; }

        [Required]
        public Guid CstSecId { get; set; }
    }
}
