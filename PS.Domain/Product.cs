using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Product : Concept
    {
        [Display (Name ="Production date ")]
        [DataType (DataType.DateTime)]
        public DateTime DateProd { get; set; }


        [DataType(DataType.MultilineText)]
        public string Description { get; set; }


        [Required(ErrorMessage ="Name is required!")] 
        [StringLength(25, ErrorMessage ="must be less than 25 !")]
        [MaxLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public double Price { get; set; }
        
        public int ProductId { get; set; }
        [Range(0,int.MaxValue)]
        public int Quantity { get; set; }

        [ForeignKey("MyCategory")]
        public int CategoryId { get; set; }

        //[ForeignKey("CategoryId")]
        public  Category MyCategory { get; set; }

        public IList<Provider> Providers { get; set; }

        public string Image { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Name: " + this.Name + ", Price: " + this.Price + ", Quantity: "+this.Quantity);
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("UNKNOWN");
        }
    }
}
