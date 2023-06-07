using ZortBilgisayarV1.entity;

namespace ZortBilgisayarV1.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}