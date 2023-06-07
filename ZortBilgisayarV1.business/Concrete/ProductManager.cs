using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZortBilgisayarV1.business.Abstract;
using ZortBilgisayarV1.data.Abstract;
using ZortBilgisayarV1.entity;


namespace ZortBilgisayarV1.business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public List<Product> Getall()
        {
            return _productRepository.Getall();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}