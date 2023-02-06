using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerAPI.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("AddressId")]
        public long Id { get; set; }
        [Column("DoorNo")]
        public string? DoorNo { get; set; }
        [Column("StreetName")]
        public string? StreetName { get; set; }
        [Column("City")]
        public string? City { get; set; }
        [Column("PostalCode")]
        public int? PostalCode { get; set; }   
        
        [ForeignKey("CustomerId")]
        [Column("CustomerId_FK")]
        public long CustomerId { get; set; }
        public Customer? Customer { get; set; }
    }
}
