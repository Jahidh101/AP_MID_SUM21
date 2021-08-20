using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEL;
using BLL.MapperConfig;
using DAL;

namespace BLL
{
    public class ProductService
    {
        public static List<ProductDetails> GetAllProducts()
        {
            var data = ProductRepo.GetAllProducts();
            var pDetails = AutoMapper.Mapper.Map<List<Product>, List<ProductDetails>>(data);
            return pDetails;
        }
        public static List<Product_TypeDetails> GetProductTypeDetails()
        {
            var data = ProductRepo.GetProductTypeDetails();
            var ptDetails = AutoMapper.Mapper.Map<List<Product_Type>, List<Product_TypeDetails>>(data);
            return ptDetails;
        }
        public static List<Product_TypeModel> GetAllProductType()
        {
            var data = ProductRepo.GetAllProductType();
            var ptDetails = AutoMapper.Mapper.Map<List<Product_Type>, List<Product_TypeModel>>(data);
            return ptDetails;
        }
        public static void AddProductType(Product_TypeModel pt)
        {
            //var ptDetails = AutoMapper.Mapper.Map<Product_TypeModel, Product_Type>(pt);
            var ptDetails = new Product_Type();
            ptDetails.Id = pt.Id;
            ptDetails.Title = pt.Title;
            ProductRepo.AddProductType(ptDetails);
        }
        public static void AddProduct(Buy_ProductsModel bpm)
        {
            //var ptDetails = AutoMapper.Mapper.Map<Product_TypeModel, Product_Type>(pt);
            var p = new Product();
            p.Id = bpm.Id;
            p.Category_Id = bpm.Category_Id;
            p.Name = bpm.Name;
            p.Buying_Price = bpm.bPrice;
            p.Selling_price = bpm.sPrice;
            p.Stored = bpm.Quantity;
            ProductRepo.AddProduct(p);

            var bp = new Buy_Products();
            bp.Id = bpm.Id;
            bp.Name = bpm.Name;
            bp.Quantity = bpm.Quantity;
            bp.Price = bpm.bPrice;
            bp.User_Id = bpm.User_Id;
            bp.Date = bpm.Date;
            var data = ProductRepo.GetAllProductType();
            var i = 0;
            foreach (object d in data){
                if (data[i].Id == bpm.Category_Id)
                {
                    bp.Type = data[i].Title;
                }
                i++;    
            }
            ProductRepo.AddBuy_Product(bp);
        }
        public static List<Farmer_BuyerModel> GetAllFarmerBuyer()
        {
            var data = ProductRepo.GetAllFarmerBuyer();
            List<Farmer_BuyerModel> fb = new List<Farmer_BuyerModel>();
            var i = 0;
            foreach (object d in data)
            {
                if (data[i].Type == "Farmer" || data[i].Type == "Buyer")
                {
                    var f = new Farmer_BuyerModel
                    {
                        Id = data[i].Id,
                        Type = data[i].Type,
                        Name = data[i].Name,
                        NID = data[i].NID,
                        Password = "*",
                        Email = data[i].Email,
                        Address = data[i].Address ,            
                    };
                    fb.Add(f);
                }
                i++;
            }
            return fb;
        }
    }
}
