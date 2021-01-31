using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if(gamer.DateOfBirth==1997 && gamer.Name=="Sümeyye"&&gamer.Surname=="Kula"&&gamer.TcNo=="1234560")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
