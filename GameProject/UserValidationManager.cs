using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1&&gamer.BirthYear == 1985 && gamer.FirstName == "Engin" && 
                gamer.LastName=="Demiroğ"&& gamer.IdendtityNumber==123456789)
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
