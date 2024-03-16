using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartAccount.Models
{
    [Table("cstdetails")]
    public class TableCstDetails
    {
        [Key]
        [Column("id")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Column ("clientname")]
        public string ClientName { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("addressline1")]
        public string AddressLine1 { get; set; }

        [MaxLength(50)]
        [Column("addressline2")]
        public string AddressLine2 { get; set; }

        [Required]
        [MaxLength(10)]
        [Column("zipcode")]
        public string ZipCode { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("city")]
        public string City { get; set; }

        [Required]
        [MaxLength(2)]
        [Column("country")]
        public string Country { get; set; }

        [Required]
        [MaxLength(255)]
        [Column("contactname")]
        public string ContactName { get; set; }

        [Required]
        [MaxLength(20)]
        [Column("contactnumber")]
        public string ContactNumber { get; set; }

        [Required]
        [MaxLength(255)]
        [EmailAddress]
        [Column("contactemail")]
        public string ContactEmail { get; set; }

        [Required]
        [Column("subtype")]
        public Guid SubType { get; set; }

        [Required]
        [Column ("cstglobal")]
        public bool CstGlobal { get; set; }

        [Required]
        [Column("active")]
        public bool Active { get; set; }

        [Required]
        [Column("clientcreateddate")]
        public DateTime ClientCreatedDate { get; set; }

        [Required]
        [Column("clientmodifydate")]
        public DateTime ClientModifyDate { get; set; }
    }
}