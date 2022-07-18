using GameProject.Concrete;
using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Adapters;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            
            OrderManager orderManager = new OrderManager();
            orderManager.OrderWithCampaign(
                new Campaign
                {
                    Name = "yaz indirimi",
                    Number = 1
                }, new Game
                {
                    Name = "NFS",
                    Id = 1
                }, new Gamer
                {
                    Id = 1,
                    BirthYear = 2000,
                    FirstName = "ATAKAN",
                    LastName = "ARSLAN",
                    IdentityNumber = 15975315975
                });

            
            Console.ReadLine();


        }
    }
}
