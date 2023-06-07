using ZortBilgisayarV1.entity;

namespace ZortBilgisayarV1.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        
        List<Product> GetPopularProducts();
    }
}