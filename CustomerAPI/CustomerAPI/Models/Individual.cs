using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerAPI.Models
{
    public enum Gender { MALE,FEMALE,TRANSGENDER}
    [Table("Individual")]
    public class Individual:Customer
    {
        [Column("Gender")]
        public Gender Gender { get; set; }
        [Column("DOB")]
        public DateTime DOB { get; set; }
    }
}
