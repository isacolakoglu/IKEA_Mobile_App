using GraphQL.IService;
using GraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Service
{
    public class ProductService : IService.IProductService
    {
      

        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            for(int i = 1; i <= 9; i++)
            {
                products.Add(new Product()
                {
                    ProductId = i,
                    Name = "Product" + i ,
                    Price = "100" + i + "₺",
                  
                }
                    ); 
            }

            return products;
        }
    }
}
