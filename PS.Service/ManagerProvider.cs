using PS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PS.Service
{
    public class ManagerProvider
    {

        List<Provider> Providers;

        public ManagerProvider(List<Provider> providers)
        {
            this.Providers = providers;
        }

        public IEnumerable<Provider> GetProviderByName(string name)
        {
            var query = from P in Providers
                        where P.UserName.Contains(name)
                        select P;
            return query;
        }

        public Provider GetFirstProviderByName(string name)
        {
            var query = from P in Providers
                        where P.UserName.Contains(name)
                        select P;
            return query.FirstOrDefault();
        }

        public Provider GetProviderById(int id)
        {
            var query = from P in Providers
                        where P.Id == id
                        select P;

            return query.SingleOrDefault();
        }

    }
}
