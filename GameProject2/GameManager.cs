using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class GameManager : IGameService
    {
        Game _game;

        public GameManager(Game game)
        {
            _game = game;
        }

        public double AddCampaign(Campaign campaign)
        {
            _game.Price = _game.Price - campaign.Rate;
            return _game.Price;
        }
    }
}
