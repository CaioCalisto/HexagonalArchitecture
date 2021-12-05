using Contoso.Product.Domain.Aggregates.Buyers;
using Contoso.Product.Infrastructure.Ports.Persistence;

namespace Contoso.Product.Infrastructure.Persistence.SqlServer
{
    public class BuyerRepo : IBuyerRepo
    {
        private readonly ProductContext productContext;

        public IUnitOfWork UnitOfWork => productContext;

        public BuyerRepo(ProductContext productContext)
        {
            this.productContext = productContext;
        }

        public Buyer Add(Buyer buyer)
        {
            throw new NotImplementedException();
        }

        public Buyer Update(Buyer buyer)
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
    }
}
