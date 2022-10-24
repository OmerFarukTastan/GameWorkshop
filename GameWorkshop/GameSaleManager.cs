using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorkshop
{
    public class GameSaleManager : IGameSaleService
    {
        public void MakeDiscount(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(game.GameName + " has been sold to " + gamer.FirstName + " with %" + campaign.Discount + " discount");
        }

        public void Sale(Game game, Gamer gamer)
        {
            Console.WriteLine(game.GameName + " has been sold to " + gamer.FirstName);
        }
    }
}
