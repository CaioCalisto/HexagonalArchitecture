using Contoso.Product.Infrastructure.Persistence;

namespace Contoso.Product.UseCases.Queries
{
    public class BuyerQueries : IBuyerQueries
    {
        private readonly IBuyerQuery buyerQuery;

        public BuyerQueries(IBuyerQuery buyerQuery)
        {
            this.buyerQuery = buyerQuery;
        }

        public ValueTask<Buyer> GetBuyer(Guid id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Buyer> GetBuyer(string buyerName)
        {
            throw new NotImplementedException();
        }
    }
}
