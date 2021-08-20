using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class OrderManager : IOrderService
    {
        Order _order;

        public OrderManager(Order order)
        {
            _order = order;
        }

        public void AddToBasket(Game game)
        {
            _order.Games.Add(game);
            Console.WriteLine("Sepete eklendi");
        }

        public void FinalCheckout()
        {
            foreach (var game in _order.Games)
            {
                Console.WriteLine(game.Price);
            }
        }

        public void RemoveFromBasket(Game game)
        {
            _order.Games.Remove(game);
        }
    }
}
