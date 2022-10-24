namespace GameWorkshop
{
    public interface IGameSaleService
    {
        void Sale(Game game, Gamer gamer);
        
        void MakeDiscount(Game game, Gamer gamer, Campaign campaign);
    }
}