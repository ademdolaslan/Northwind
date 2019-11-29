using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL.Entities
{
    public class AddOrderEntity
    {
        public string customerId { get; set; }
        public int employeeId { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime requiredDate { get; set; }
        public DateTime shippedDate { get; set; }
        public int shipVia { get; set; }
        public int freight { get; set; }
        public string shipName { get; set; }
        public string shipAddress { get; set; }
        public string shipCity { get; set; }
        public string shipRegion { get; set; }
        public string shipPostalcode { get; set; }
        public string shipCountry { get; set; }

    }
}
