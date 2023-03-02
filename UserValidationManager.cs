using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "Furkan" 
                && gamer.LastName == "KARATAŞ" && gamer.IdentityNumber == 9874654)
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
