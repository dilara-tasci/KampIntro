using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject2
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
