using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZortBilgisayarV1.data.Abstract;

namespace ZortBilgisayarV1.data.Concrete.SQL.EFCore
{
    public class EFCoreGenericRepository<X, TContext> : IRepository<X>
    where X : class
    where TContext : DbContext, new()
    {
        public void Create(X entity)
        {
            using (var context = new TContext())
            {
                context.Set<X>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(X entity)
        {
            using (var context = new TContext())
            {
                context.Set<X>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<X> Getall()
        {
            using (var context = new TContext())
            {
                return context.Set<X>().ToList();
            }
        }

        public X GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<X>().Find(id);
            }
        }

        public void Update(X entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}