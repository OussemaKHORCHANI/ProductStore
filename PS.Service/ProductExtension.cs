using System;
using System.Collections.Generic;
using System.Text;
using PS.Domain;

namespace PS.Service
{
    public static class ProductExtension
    {
        public static void UpperName(this ManageProduct Mp, Product P)
        {
            P.Name = P.Name.ToUpper();
        }

        public static bool InCategory(this ManageProduct Mp, Product P, Category C)
        {
            return P.MyCategory.Name == C.Name;
        }
    }
}
