using Contoso.Product.Domain.Aggregates.Buyers;
using Contoso.Product.Infrastructure.Ports.Persistence;

namespace Contoso.Product.Infrastructure.Persistence.MongoDb
{
    public class BuyerAdapter : IBuyerRepository
    {
        private readonly IBuyerCollection buyerCollection;

        public BuyerAdapter(IBuyerCollection buyerCollection)
        {
            this.buyerCollection = buyerCollection;
        }

        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public Buyer Add(Buyer buyer)
        {
            throw new NotImplementedException();
        }

        public Task<Buyer> FindAsync(string BuyerIdentityGuid)
        {
            throw new NotImplementedException();
        }

        public Task<Buyer> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Buyer Update(Buyer buyer)
        {
            throw new NotImplementedException();
        }
    }
}
