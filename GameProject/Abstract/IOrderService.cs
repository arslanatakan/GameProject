using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IOrderService
    {
        void OrderWithCampaign(Campaign campaign, Game game, Gamer gamer);
        void Order(Game game,Gamer gamer);
    }
}
