using PS.Data.Infrastructures;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PS.ServicePattern
{
    public class Service<T> : IService<T> where T : class
    {

        static IDataBaseFactory dataBaseFactory = new DataBaseFactory();
        // IUnitOfWork unitOfWork = new UnitOfWork(dataBaseFactory);
        public readonly IUnitOfWork utwk;
        public Service(IUnitOfWork utwk)
        {
            this.utwk = utwk;
        }
        public void Add(T entity)
        {
            utwk.getRepository<T>().Add(entity);
            Commit();
        }

        public void Commit()
        {
            utwk.Commit();
        }

        public void Delete(T entity)
        {
            utwk.getRepository<T>().Delete(entity);
            Commit();
        }

        public void Delete(Expression<Func<T, bool>> where)
        {
            utwk.getRepository<T>().Delete(where);
            Commit();
        }

        public void Dispose()
        {
            utwk.Dispose();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
           return utwk.getRepository<T>().Get(where);
            
        }

        public T GetById(long id)
        {
            return utwk.getRepository<T>().GetById(id);
        }

        public T GetById(string id)
        {
           return utwk.getRepository<T>().GetById(id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null)
        {
            return utwk.getRepository<T>().GetMany(where);
        }

        public void Update(T entity)
        {
            utwk.getRepository<T>().Update(entity);
        }
    }
}
