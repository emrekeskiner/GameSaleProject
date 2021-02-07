using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DogumYili==1984 && gamer.Adi=="Emre" 
                && gamer.Soyad=="Keskiner" && gamer.TcKimlikNo ==12345)
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
