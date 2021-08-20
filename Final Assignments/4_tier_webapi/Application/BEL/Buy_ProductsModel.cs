using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class Buy_ProductsModel
    {
        public int Id { get; set; }
        public int Category_Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> bPrice { get; set; }
        public Nullable<int> sPrice { get; set; }
        public Nullable<int> User_Id { get; set; }
        public string Date { get; set; }
    }
}
