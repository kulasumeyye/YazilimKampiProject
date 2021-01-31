using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;

        }
        

       

        //MicroService
        public void Add(Gamer gamer)
        {
            if(_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Gamer is added");
            }
            else
            {
                Console.WriteLine("GAmer is not added");
            }
        }

          

        public void Delete(Gamer gamer)
        {
                Console.WriteLine("Gamer is deleted");
            
        }

   

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer is Updated");
        }
    }
}
