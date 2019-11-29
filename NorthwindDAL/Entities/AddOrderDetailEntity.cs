using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL.Entities
{
    public class AddOrderDetailEntity
    {
        public int orderId { get; set; }
        public int productId { get; set; }
        public int unitPrice { get; set; }
        public int quantity { get; set; }
        public int discount { get; set; }
    }
}
