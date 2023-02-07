using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CustomerApp.Models
{
    public enum Gender { MALE,FEMALE,TRANSGENDER}
    [Table("Individual")]
    public class Individual:Customer
    {
        [Column("Gender")]
        public Gender Gender { get; set; }
        [Column("DOB")]
        public DateTime DOB { get; set; }

        public Individual()
        {
        }

        public Individual(long customerId, string? firstName, string? lastName, string? middleName, long contactNo, string? email, string? password,DateTime DOB, Gender gender) : base(customerId, firstName,  lastName, middleName, contactNo, email, password)
        {
            this.Gender = gender;
            this.DOB = DOB;
        }
        
    }
}
