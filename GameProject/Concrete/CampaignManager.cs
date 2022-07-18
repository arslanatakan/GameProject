using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi!");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi!");
        }
    }
}
