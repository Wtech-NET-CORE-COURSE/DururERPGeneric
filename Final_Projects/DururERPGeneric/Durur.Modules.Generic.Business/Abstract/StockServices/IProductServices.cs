using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetProductsAsync();

        Product GetProductByID(int id);

        void AddProduct(Product product);

        Product UpdateProduct(Product product);

        void DeleteProduct(int id);
    }
}
