using GameApp.Abstract;
using GameApp.Concrete;
using GameApp.Entities;
using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                Name="Sümeyye",
                Surname="Kula",
                TcNo="1234560",
                DateOfBirth=1997
            });
            Gamer gamer2 = new Gamer
            {
                Id = 2,
                Name = "Ahmet",
                Surname = "Yılmaz",
                TcNo = "12345",
                DateOfBirth = 1996
            };
            GamerManager gamerManager2 = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer2);

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                Name = "Campaign1"
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.add(campaign1);

            Game game1 = new Game() { Id = 1, Name = "Game1", Price = 28 };
            ISaleService sale = new SaleManager();
            sale.CampaignSale(campaign1, game1, gamer2);

           

        }
    }
}
