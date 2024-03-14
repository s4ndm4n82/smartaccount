using System.ComponentModel.DataAnnotations;

namespace SmartAccount.Models
{
    public class TableCstDetails
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string ClientName { get; set; }

        [Required]
        [MaxLength(50)]
        public string AddressLine1 { get; set; }

        [MaxLength(50)]
        public string AddressLine2 { get; set; }

        [Required]
        [MaxLength(10)]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        public string Country { get; set; }

        [Required]
        [MaxLength(255)]
        public string ContactName { get; set; }

        [Required]
        [MaxLength(20)]
        public string ContactNumber { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required]
        public Guid SubType { get; set; }

        [Required]
        public bool CstGlobal { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public DateTime ClientCreatedDate { get; set; }

        [Required]
        public DateTime ClientModifyDate { get; set; }
    }
}
