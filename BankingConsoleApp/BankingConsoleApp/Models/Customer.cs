﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingConsoleApp.Models
{
    public class Customer
    {
        public long CustomerId { get; set; }
        public string? Name { get; set; }
        public DateTime DOB { get; set; }

    }
}
