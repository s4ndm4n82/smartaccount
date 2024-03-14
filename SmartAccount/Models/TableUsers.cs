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
        [Column ("cstviewid")]
        public Guid CstViewId { get; set; }

        [Required]
        [Column ("subviewid")]
        public JsonDocument UserSettings { get; set; }

        [Required]
        [Column ("usrglobal")]
        public bool UsrGlobal { get; set; }

        [Required]
        [Column ("banned")]
        public bool Banned { get; set; }

        [Required]
        [Column ("usercreationdate")]
        public DateTime UserCreationDate { get; set; }

        [Required]
        [Column ("usermodifydate")]
        public DateTime UserModifyDate { get; set; }        
    }
}
