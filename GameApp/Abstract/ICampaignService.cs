using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    interface ICampaignService
    {
        void add(Campaign campaign);
        void update(Campaign campaign);
        void delete(Campaign campaign);
    }
}
