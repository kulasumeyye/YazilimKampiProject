using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
