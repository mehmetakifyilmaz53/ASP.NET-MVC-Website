using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZortBilgisayarV1.entity;

namespace ZortBilgisayarV1.business.Abstract
{
    public interface ICategoryService
    {
        public List<Category> GetAll();
        public Category GetById(int id);
        public void Create(Category entity);
        public void Update (Category entity);
        public void Delete (Category entity);
    }
}