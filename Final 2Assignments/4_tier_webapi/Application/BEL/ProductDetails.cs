using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ProductDetails
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Buying_Price { get; set; }
        public Nullable<int> Selling_price { get; set; }
        public Nullable<int> Stored { get; set; }
        public virtual Product_TypeModel Product_Type { get; set; }
    }
}
