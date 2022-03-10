using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_IPET.Model
{
    internal class ProductSearchFilter
    {
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int SubCategoryID { get; set; }
        public int BrandID { get; set; }
    }
    internal class CategorySearchFilter
    {
        public string CategoryName { get; set; }
    }

}
