using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Order(Game game, Gamer gamer)
        {
            Console.WriteLine(game.Id + " numaralı oyun," + gamer.FirstName + " adlı oyuncu tarafından sipariş verildi.");
        }

        public void OrderWithCampaign(Campaign campaign, Game game, Gamer gamer)
        {
            Console.WriteLine(game.Id + " numaralı oyun," + gamer.FirstName + " adlı oyuncu tarafından " + "("+
                campaign.Name+")"+ " kapsamında sipariş verildi.");
        }
    }
}
