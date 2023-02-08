using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CustomerApp.Models
{
    public class Customer
    {

      

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CustomerId")]
        public long CustomerId { get; set; }
        //public FullName? FullName { get; set; }

       [RegularExpression(@"^[A-Z]+[a-zA-Z]*$",ErrorMessage ="First Name Should be in alphabets only")]
       
        [Column("FirstName")]
        [Required]
        public string? FirstName { get; set; }
        [Column("LastName")]
       [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Last Name Should be in alphabets only")]
        [Required]
        public string? LastName { get; set; }
        [Column("MiddleName")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$", ErrorMessage = "Middle Name Should be in alphabets only")]
        public string? MiddleName { get; set; }
        [Column("ContactNo")]
       // [StringLength(10)]
        public long ContactNo { get; set; }
        [Column("Email")]
       // [ReputableEmail]
        [EmailAddress]
        [Required]
        public string? Email { get; set; }
        [Column("Password")]

        public string? Password { get; set; }

        public Customer()
        {
        }

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
