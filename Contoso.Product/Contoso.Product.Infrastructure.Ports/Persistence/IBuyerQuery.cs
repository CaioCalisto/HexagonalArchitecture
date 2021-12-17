using Contoso.Product.Domain.Aggregates.Buyers;

namespace Contoso.Product.Infrastructure.Persistence
{
    public interface IBuyerQuery
    {
        Task<Buyer> FindAsync(string BuyerIdentityGuid);

        Task<Buyer> FindByIdAsync(string id);
    }
}
