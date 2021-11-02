using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PS.Service
{
    public class ManageProvider
    {
        List<Provider> Providers;
        public ManageProvider(List<Provider> p)
        {
            this.Providers = p;
        }
        public IEnumerable<Provider> GetProviderByName(string name)
        {
           var  linqQuery = from p in Providers
                            where p.UserName.Contains(name)
                            select p;

            return linqQuery;
        }

        public IEnumerable<Provider> GetFirstProviderByName(string name)
        {
            var linqQuery = from p in Providers
                            where p.UserName.Contains(name)
                            select p;


            return (IEnumerable<Provider>)linqQuery.FirstOrDefault();
        }

        public IEnumerable<Provider> GetProviderById(int id)
        {
            var linqQuery = from p in Providers
                            where p.Id==id
                            select p;
            return (IEnumerable<Provider>)linqQuery.SingleOrDefault();
        }



    }
}
