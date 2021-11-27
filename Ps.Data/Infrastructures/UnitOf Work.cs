using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Data.Infrastructures
{
   public class UnitOfWork : IUnitOfWork

    {
        readonly IDataBaseFactory databaseFactory;
        public UnitOfWork(IDataBaseFactory dbFactory)
        { 
            databaseFactory = dbFactory;
        }
        public void Commit()
        { 
            databaseFactory.DataContext.SaveChanges(); }
        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(databaseFactory);
        }
        public void Dispose() 
        { 
            databaseFactory.DataContext.Dispose();
        }
    }
}
