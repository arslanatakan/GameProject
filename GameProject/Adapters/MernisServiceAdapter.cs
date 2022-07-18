using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.MernisServiceReference;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            
            return client.TCKimlikNoDogrula(gamer.IdentityNumber, gamer.FirstName.ToUpper(), 
                                            gamer.LastName.ToUpper(), gamer.BirthYear);
        }
    }
}
