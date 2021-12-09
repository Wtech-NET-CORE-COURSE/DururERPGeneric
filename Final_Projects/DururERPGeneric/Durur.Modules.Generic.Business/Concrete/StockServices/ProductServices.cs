using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class ProductServices : IProductServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task AddProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product UpdateProduct(Product productToUpdate, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
