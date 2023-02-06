using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp.Models
{
    public record Customer
    {
        public long CustomerId { get; init; }
        public string? Name { get; init; }
        public DateTime DOB { get; init; }

    }
}
