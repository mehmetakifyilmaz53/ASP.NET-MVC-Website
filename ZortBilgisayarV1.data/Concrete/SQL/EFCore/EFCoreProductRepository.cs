using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZortBilgisayarV1.data.Abstract;
using ZortBilgisayarV1.entity;

namespace ZortBilgisayarV1.data.Concrete.SQL.EFCore
{
    public class EFCoreProductRepository : EFCoreGenericRepository<Product, ZortContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using (var context = new ZortContext())
            {
                return context.Products.ToList();
            }
        }
    }
}