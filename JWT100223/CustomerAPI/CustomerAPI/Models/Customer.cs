using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CustomerAPI.Models
{
    public class Customer
    {

      

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CustomerId")]
        public long CustomerId { get; set; }
        //public FullName? FullName { get; set; }

        [Column("FirstName")]
        public string? FirstName { get; set; }
        [Column("LastName")]
        public string? LastName { get; set; }
        [Column("MiddleName")]
        public string? MiddleName { get; set; }
        [Column("ContactNo")]
       // [StringLength(10)]
        public long ContactNo { get; set; }
        [Column("Email")]
       // [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",ErrorMessage ="Enter Valid Email Id")]
        public string? Email { get; set; }
        [Column("Password")]

        public string? Password { get; set; }

        [JsonConstructor]
        public Customer(long customerId, string? firstName, string? lastName, string? middleName, long contactNo, string? email, string? password)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            ContactNo = contactNo;
            Email = email;
            Password = password;
        }
    }
}
