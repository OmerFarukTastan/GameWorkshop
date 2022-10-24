using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorkshop
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Added");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Updated");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Deleted");
        }

    }
}
