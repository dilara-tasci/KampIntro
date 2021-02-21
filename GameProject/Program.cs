using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Identity = "28861499108", DateOfBirth = 1985, FirstName = "Engin", LastName = "Demiroğ" };
            CustomerManager customerManager = new CustomerManager(new ServiceAdapter());
            customerManager.Save(customer);
            customerManager.Update(customer);
            customerManager.Delete(customer);

            Game game = new Game() { Name = "Pacman", Price = 50 };
            Discount discount = new Discount() {Name="new year", Rate=20};
            Discount discount1 = new Discount() { Name = "cyber monday", Rate = 10 };
            DiscountManager discountManager = new DiscountManager();
            discountManager.AddNewDiscount(discount1);
            GameSalesManagement gameSalesManagement = new GameSalesManagement();
            gameSalesManagement.Sales(customer, game, discount);
        }
    }
}
