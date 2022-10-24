using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameWorkshop
{
    public class UserValidationManager : IUserValidationService
    {
        

        public bool Validation(Gamer gamer) 
        {
            if (gamer.BirthYear == 1990 && gamer.FirstName == "Hasan" && gamer.LastName == "Büyük" && gamer.NationalityId == 5984859)
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
