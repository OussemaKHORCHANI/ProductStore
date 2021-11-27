using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PS.Domain
{
    public class Provider : Concept
    {
        //public string ConfirmPassword { get; set; }
        
        public DateTime DateCreated { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Key]
        public int Id { get; set; }
        
        public bool IsApproved { get; set; }
        
        //public string Password { get; set; }

        private string password;

        [DataType(DataType.Password)]
        [MinLength(8)]
        [Required]
        public string Password
        {
            get { return password; }
            set { 
                if (value.Length >= 5 && value.Length <= 20)
                {
                    password = value;
                }
                else
                {
                    Console.WriteLine("Password doit être compris entre 5 et 20");
                }
            }
        }

        private string confirmPassword;

        [Required]
        [DataType(DataType.Password)]
        [NotMapped]
        [Compare("Password")]
        public string ConfirmPassword
        {
            get { return confirmPassword; }
            set { 
                if (password.Equals(value))
                {
                    confirmPassword = value;
                }
                else
                {
                    Console.WriteLine("Password et Confirm Password ne sont pas identiques");
                }
            }
        }



        public string UserName { get; set; }

        public virtual IList<Product> Products { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Email: " + this.Email + ", Creation Date: " + this.DateCreated + ", Approved? : "+this.IsApproved);

            if(Products != null)
            {
                foreach (Product p in Products)
                {
                    p.GetDetails();
                }
            }

        }

        public static void SetIsApproved(Provider P)
        {
                P.IsApproved = P.ConfirmPassword.Equals(P.Password);   
        }


        //EXERCICE "e"
        //public static void SetIsApprovedBeta(ref string password, ref string confirmPassword, ref bool isApproved)
        //{
        //    isApproved = confirmPassword.Equals(password);
        //}


        //public bool Login(string username, string password)
        //{
        //    return this.UserName.Equals(username) && this.Password.Equals(password);
        //}

        //public bool Login(string username, string password,string email)
        //{
        //    return this.UserName.Equals(username) && this.Password.Equals(password) && this.Email.Equals(email);
        //}


        public bool Login(string userName, string password, string email = null)
        {
            return string.Compare(this.UserName, userName) == 0
                && string.Compare(this.Password, password) == 0
                && email != null ? string.Compare(this.Email, email) == 0 : true;
        }

        public void GetProducts(string filterType, string filterValue)
        {
            if (this.Products != null)
            {
                switch (filterType)
                {
                    case "Production Date":
                        {
                            foreach (Product p in Products)
                            {
                                if (p.DateProd.Equals(DateTime.Parse(filterValue)))
                                {
                                    p.GetDetails();
                                }
                            }

                            break;
                        }

                    case "Name":
                        {
                            foreach (Product p in Products)
                            {
                                if (p.Name.Equals(filterValue))
                                {
                                    p.GetDetails();
                                }
                            }

                            break;
                        }

                    case "Prix":
                        {
                            foreach (Product p in Products)
                            {
                                if(p.Price == Double.Parse(filterValue))
                                {
                                    p.GetDetails();
                                }
                            }

                            break;
                        }

                }
            }
        }

    }
}
