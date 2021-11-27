using PS.Data;
using PS.Data.Infrastructures;
using PS.Domain;
using PS.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PS.Service.TP2
{
    public class CategoryService : Service<Category> , ICategoryService
    {

       //static  IDataBaseFactory dataBaseFactory = new DataBaseFactory();
       //Dependency Injection
        public CategoryService(IUnitOfWork utwk) : base(utwk)
        {
        }
       
    }
}
