 using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSalesManagement: IDiscountCheck
    {
        Double price;
        Double discoun;
        /* public GameSalesManagement(Customer customer)
         {
             Console.WriteLine("Müşteri: " + customer.FirstName);
         }*/
        public void Sales(Customer customer, Game game, Discount discount)
        {
            if (IsDiscount())
            {
                discoun = (game.Price * discount.Rate)/100;
                price = game.Price - discoun;
                Console.WriteLine(customer.FirstName + " adlı kullanıcı " + game.Name +
                    " adlı oyunu " + price + " tl'ye aldı.");
            }
            else
            {
                Console.WriteLine(customer.FirstName + " adlı kullanıcı " + game.Name +
                    " adlı oyunu " + game.Price + " fiyata aldı.");
            }
            
        } 
       /* public double ApplyDiscount(Discount discount)
        {
            return discount.Rate;
        }*/
        public bool IsDiscount()
        {
            return true;
        }
    }
}
