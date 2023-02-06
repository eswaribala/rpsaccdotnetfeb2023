using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerAPI.Models
{
    [Owned]
    public class FullName
    {
        [Column("FirstName")]
        public string? FirstName { get; set; }
        [Column("LastName")]
        public string? LastName { get; set; }
        [Column("MiddleName")]
        public string? MiddleName { get; set; }
        
    }
}
