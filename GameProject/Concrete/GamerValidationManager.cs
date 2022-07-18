using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerValidationManager : IGamerValidationService
    {
        //Burası kendi doğrulama servisim. ((Test amaçlı))
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
