﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DomainClasses
{
    public class Account
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public double Summary { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Currency Currency { get; set; }
        public int CurrencyId { get; set; }
    }
}
