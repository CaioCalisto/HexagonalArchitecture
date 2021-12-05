using Contoso.Product.Domain.Aggregates.Buyers;

namespace Contoso.Product.Infrastructure.Ports.Persistence
{
    public interface IBuyerRepository : IRepository<Buyer>
    {
        Buyer Add(Buyer buyer);

        Buyer Update(Buyer buyer);

        Task<Buyer> FindAsync(string BuyerIdentityGuid);

        Task<Buyer> FindByIdAsync(string id);
    }
}
