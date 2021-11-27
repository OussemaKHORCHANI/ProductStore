using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Facture
    {

        public DateTime DateAchat { get; set; }

        public float Prix { get; set; }

        [ForeignKey("MyClient")]
        public int ClientFK { get; set; }

        public virtual Client MyClient { get; set; }

        [ForeignKey("MyProduct")]
        public int ProductFK { get; set; }

        public virtual Product MyProduct { get; set; }

    }
}
