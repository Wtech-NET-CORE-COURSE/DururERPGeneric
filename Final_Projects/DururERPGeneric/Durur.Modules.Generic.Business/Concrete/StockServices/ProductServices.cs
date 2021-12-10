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

        public async Task AddProductAsync(Product product)
        {
            await _unitOfWork.Products.AddAsync(product);
        }

        public async Task<Product> GetProductByIDAsync(int id)
        {
            var product =await _unitOfWork.Products.GetByIDAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return products;
        }

        public async Task RemoveProduct(int id)
        {
            _unitOfWork.Products.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveProduct(Product product)
        {
            _unitOfWork.Products.Remove(product);
            await _unitOfWork.CommitAsync();
        }

        public Product UpdateProduct(Product productToUpdate, Product product)
        {
            throw new NotImplementedException();
        }
    }
}
