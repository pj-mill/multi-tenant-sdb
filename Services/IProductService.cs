using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using multi_tenant_sdb.Models;

namespace multi_tenant_sdb.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product CreateProduct(CreateProductRequest request);
        bool DeleteProduct(int id);
    }
}