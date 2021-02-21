using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class DiscountManager
    {
        List<Discount> discounts = new List<Discount>();
        public void AddNewDiscount(Discount discount)
        {
            Console.WriteLine(discount.Name + "New Discount Added");
            discounts.Add(discount);
        }
        public void UpdateDiscount(Discount discount)
        {
            Console.WriteLine(discount.Name + "Discount Updated");
        }
        public void DeleteDiscount(Discount discount)
        {
            Console.WriteLine(discount.Name + "Discount Deleted");
        }
    }
}
