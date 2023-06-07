using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZortBilgisayarV1.business.Abstract;
using ZortBilgisayarV1.data.Abstract;
using ZortBilgisayarV1.entity;

namespace ZortBilgisayarV1.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
         private ICategoryRepository _categoryRepository;

        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.Getall();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}