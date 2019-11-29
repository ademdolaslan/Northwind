using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDAL.Entities
{
    public class OrderBetweendateEntity
    {
        private string _productSales;
        private string _productName;
        private string _categoryName;
        public string categoryName { get => _categoryName; set => _categoryName = value; }
        public string productName { get => _productName; set => _productName = value; }
        public string productSales { get => _productSales; set => _productSales = value; }
    }
}
