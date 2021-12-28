using Contoso.Product.Infrastructure.Persistence;
using Contoso.Product.InterfaceAdapters.Queries;

namespace Contoso.Product.UseCases.Queries
{
    public class BuyerQueries : IBuyerQueries
    {
        private readonly IBuyerQuery buyerQuery;

        public BuyerQueries(IBuyerQuery buyerQuery)
        {
            this.buyerQuery = buyerQuery;
        }

        public ValueTask<InterfaceAdapters.Queries.Output.Buyer> GetBuyer(Guid id)
        {
            throw new NotImplementedException();
        }

        public ValueTask<InterfaceAdapters.Queries.Output.Buyer> GetBuyer(string buyerName)
        {
            throw new NotImplementedException();
        }
    }
}
