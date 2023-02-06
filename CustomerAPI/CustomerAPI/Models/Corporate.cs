using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerAPI.Models
{
    public enum CompanyType { Public,NGO,MNC}
    [Table("Corporate")]
    public class Corporate:Customer
    {
        [Column("CompanyType")]
        public CompanyType CompanyType { get; set; }
    }
}
