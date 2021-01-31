using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    class SaleManager : ISaleService
    {
        public void CampaignSale(Campaign campaign, Game game, Gamer gamer)
        {
            Console.WriteLine("CampaignSale");
        }

        public void Sale(Gamer gamer, Game game)
        {
            Console.WriteLine("Sale");
        }
    }
}
