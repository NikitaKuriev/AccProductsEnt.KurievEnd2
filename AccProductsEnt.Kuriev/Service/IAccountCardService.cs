using AccProductsEnt.Kuriev.Entities;

namespace AccProductsEnt.Kuriev.Service
{
    public interface IAccountCardService
    {
        public void AddAccountCard(AccountCard newAccountCard);

        public List<AccountCard> GetAccountCardsAll();
    }
}
