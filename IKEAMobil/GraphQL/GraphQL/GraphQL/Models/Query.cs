using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL.IService;

namespace GraphQL.Models
{
    public class Query
    {
        IProductService _productService= null;

        public Query(IProductService productService)
        {
            _productService = productService;
        }

        public List<Product> Products => _productService.GetProducts();




    }
}
