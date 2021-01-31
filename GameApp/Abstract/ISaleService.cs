using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    interface ISaleService
    {
        void Sale(Gamer gamer,Game game);
        void CampaignSale(Campaign campaign, Game game,Gamer gamer);
    }
}
