using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace SmartAccount.Models
{
    [Table("cstusers")]
    public class TableUsers
    {
        [Key]
        [Column ("id")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Column ("username")]
        public string UserName { get; set; }

        [Column ("usrsecid")]
        public  Guid UsrSecId { get; set; } // Need to be created when adding the user.

        [Required]
        [MaxLength(255)]
        [Column ("firstname")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(255)]
        [Column ("lastname")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        [Column ("useremail")]
        public string UserEmail { get; set; }

        [Required]
        [Column ("userrole")]
        public Guid UserRole { get; set; }        

        [Required]
        public Guid CstViewId { get; set; }

        [Required]
        public JsonDocument UserSettings { get; set; }

        [Required]
        public bool UsrGlobal { get; set; }

        [Required]
        public bool Banned { get; set; }

        [Required]
        public DateTime UserCreationDate { get; set; }

        [Required]
        public DateTime UserModifyDate { get; set; }        
    }
}
