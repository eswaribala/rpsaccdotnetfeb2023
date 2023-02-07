using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CustomerApp.Models
{
    public enum CompanyType { Public,NGO,MNC}
    [Table("Corporate")]
    public class Corporate:Customer
    {
        [Column("CompanyType")]
        public CompanyType CompanyType { get; set; }

        public Corporate()
        {
        }

        public Corporate(long customerId, string? firstName, string? lastName, string? middleName, long contactNo, string? email, string? password, CompanyType companyType) : base(customerId, firstName, lastName, middleName, contactNo, email, password)
        {
            this.CompanyType= companyType;
        }


    }
}
