namespace GameWorkshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            {
                gamer.NationalityId = 5984859;
                gamer.FirstName = "Hasan";
                gamer.LastName = "Büyük";
                gamer.BirthYear = 1990;
            };

            IGamerService gamerService = new GamerManager(new UserValidationManager());

            gamerService.Add(gamer);
            gamerService.Update(gamer);
            gamerService.Remove(gamer);


            Campaign campaign = new Campaign() { Discount = 10 };

            ICampaignService campaignService = new CampaignManager();


            gamerService.Add(gamer);
            gamerService.Update(gamer);
            gamerService.Remove(gamer);

            Game game = new Game() { GameName = "Middle Earth Shadow of War", Price = 500 };

            IGameSaleService gameSaleService = new GameSaleManager();

            gameSaleService.Sale(game, gamer);
            gameSaleService.MakeDiscount(game, gamer, campaign);
        }

    }    }

