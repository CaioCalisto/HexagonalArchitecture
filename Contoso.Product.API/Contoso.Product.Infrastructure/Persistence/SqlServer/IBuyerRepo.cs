using Contoso.Product.Domain.Aggregates.Buyers;
using Contoso.Product.Infrastructure.Persistence;

namespace Contoso.Product.Infrastructure.Persistence.SqlServer
{
    public interface IBuyerRepo
    {
        IUnitOfWork UnitOfWork { get; }

        Buyer Add(Buyer buyer);

        Buyer Update(Buyer buyer);

        Task<Buyer> FindAsync(string BuyerIdentityGuid);

        Task<Buyer> FindByIdAsync(string id);
    }
}
