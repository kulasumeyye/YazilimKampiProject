using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void add(Campaign campaign)
        {
            Console.WriteLine("Campaign added");
        }

        public void delete(Campaign campaign)
        {
            Console.WriteLine("Campaign deleted");
        }

        public void update(Campaign campaign)
        {
            Console.WriteLine("Campaign Updated");
        }
    }
}
