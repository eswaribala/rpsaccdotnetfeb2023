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
    }
}
