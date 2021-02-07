using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
