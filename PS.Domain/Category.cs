using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PS.Domain
{
    public class Category : Concept
    {
        [Key]
        public int CategoryId { get; set; }
        
        public string Name { get; set; }

        public  virtual IList<Product> Products { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("ID: " + this.CategoryId + ", Name: " + this.Name);
        }
    }
}
