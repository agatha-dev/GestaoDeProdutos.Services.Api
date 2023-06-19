using GestaoDeProdutos.Domain.Interfaces;
using GestaoDeProdutos.Domain.Models;
using GestaoDeProdutos.Infra.Data.Contexts;
using GestaoDeProdutos.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Infra.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class
    {

        public void Add(TEntity entity)
        {
            using (var context = new DataContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }
        public void Update(TEntity entity)
        {
            using (var context = new DataContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new DataContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }


        public List<TEntity> GetAll()
        {
            using (var context = new DataContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(Guid id)
        {
           using(var context = new DataContext())
           {
                return context.Set<TEntity>().Find(id);
           }
        }
    }
}
