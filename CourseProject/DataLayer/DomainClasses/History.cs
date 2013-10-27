using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DomainClasses
{
    public class History
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
