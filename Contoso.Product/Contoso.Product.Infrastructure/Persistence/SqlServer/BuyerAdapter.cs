using Contoso.Product.Domain.Aggregates.Buyers;
using Contoso.Product.Infrastructure.Persistence;

namespace Contoso.Product.Infrastructure.Persistence.SqlServer
{
    internal class BuyerAdapter : IBuyerRepository
    {
        private readonly IBuyerRepo buyerRepository;

        public IUnitOfWork UnitOfWork => buyerRepository.UnitOfWork;

        public BuyerAdapter(IBuyerRepo buyerRepository)
        {
            this.buyerRepository = buyerRepository;
        }

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
