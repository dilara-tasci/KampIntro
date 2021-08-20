using System;
using System.Collections.Generic;

namespace GameProject2
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer { Id = 1, BirthYear = 1985, FirstName = "ENGİN", LastName = "DEMİROĞ", IdentityNumber = 12345 });
            CampaignManager campaignManager = new CampaignManager(new Campaign { Id=1, Name="Yaz", Rate=10 });
            campaignManager.Add();
            Game game = new Game { Id = 3, Name = "Pacman", Price = 15 };
            GameManager gameManager = new GameManager(game);
            gameManager.AddCampaign(new Campaign { Id = 1, Name = "Yaz", Rate = 10 });
            OrderManager orderManager = new OrderManager(new Order
            {
                Id = 2,
                Games = new List<Game> { },
                Checkout = 0
            });
            orderManager.AddToBasket(game);
            orderManager.FinalCheckout();

        }
    }
}
