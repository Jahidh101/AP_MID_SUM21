using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {
        static MFCSEntities context = new MFCSEntities();
        public static List<Product> GetAllProducts()
        {
            
            var p = context.Products.ToList();
            return p;
        }
        public static List<Product_Type> GetProductTypeDetails()
        {
            return context.Product_Type.ToList();
        }
        public static List<Product_Type> GetAllProductType()
        {
            return context.Product_Type.ToList();
        }
        public static void AddProductType(Product_Type p)
        {
            context.Product_Type.Add(p);
            context.SaveChanges();
        }
        public static void AddProduct(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }
        public static void AddBuy_Product(Buy_Products bp)
        {
            context.Buy_Products.Add(bp);
            context.SaveChanges();
        }
        public static List<User> GetAllFarmerBuyer()
        {
            return context.Users.ToList();
        }
    }
}
