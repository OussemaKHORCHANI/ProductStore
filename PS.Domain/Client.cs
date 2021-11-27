using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PS.Domain
{
   public  class Client
    {
        [Key]
        public int   Cin { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Mail { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public virtual IList<Facture> Factures { get; set; }

    }
}
