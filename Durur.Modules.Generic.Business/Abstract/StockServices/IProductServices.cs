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

        Task<Product> GetProductByIDAsync(int id);

        Task AddProductAsync(Product product);

        Product UpdateProduct(Product productToUpdate,Product product);

        Task RemoveProduct(int id);
        Task RemoveProduct(Product product);
    }
}
