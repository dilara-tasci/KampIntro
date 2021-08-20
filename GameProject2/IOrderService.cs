using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    interface IOrderService
    {
        void AddToBasket(Game game);
        void RemoveFromBasket(Game game);
        void FinalCheckout();
    }
}
