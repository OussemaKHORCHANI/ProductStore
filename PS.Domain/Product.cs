using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Product : Concept
    {
        [Display(Name = "Production Date")]
        [DataType(DataType.DateTime)]
        public DateTime DateProd { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "NAME IS REQUIRED")]
        [StringLength(25, ErrorMessage = "NAME DOIT AVOIR 25 CHARACTERES AU MINIMUM")]
        [MaxLength(50, ErrorMessage = "NAME DOIT AVOIR 50 CHARACTERES AU MAXIMUM")]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }

        public int? ProductId { get; set; }

        [Range(0, int.MaxValue)]
        public int Quantity { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category MyCategory { get; set; }

        public string Image { get; set; }

        public virtual IList<Provider> Providers { get; set; }

        public virtual IList<Facture> Factures { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Name: " + this.Name + ", Price: " + this.Price + ", Quantity: " + this.Quantity);
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("UNKNOWN");
        }
    }
}
