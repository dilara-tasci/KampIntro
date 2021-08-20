using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class Order
    {
        public int Id { get; set; }
        public double Checkout { get; set; }
        public List<Game> Games { get; set; }
    }
}
