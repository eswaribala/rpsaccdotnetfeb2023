using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpFundamentals.Models
{
    public class CurrentAccount:Account
    {
        public long OverDraftLimit { get; set; }
    }
}
