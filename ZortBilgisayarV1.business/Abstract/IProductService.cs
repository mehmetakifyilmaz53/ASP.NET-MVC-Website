using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZortBilgisayarV1.entity;
namespace ZortBilgisayarV1.business.Abstract
{
    public interface IProductService
    {
        List<Product> Getall();
        public Product GetById(int id);
        public void Create (Product entity);
        public void Update (Product entity);
        public void Delete (Product entity);
    }
}