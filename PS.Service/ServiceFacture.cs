using PS.Data.Infrastructures;
using PS.Domain;
using PS.ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Service
{
   public class ServiceFacture : Service<Facture> , IFactureService
    {
      
        public ServiceFacture(IUnitOfWork utwk) : base(utwk)
        {
        }

    }
}
