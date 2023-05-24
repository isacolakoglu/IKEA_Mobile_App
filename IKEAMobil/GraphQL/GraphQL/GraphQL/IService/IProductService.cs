using GraphQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.IService
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
