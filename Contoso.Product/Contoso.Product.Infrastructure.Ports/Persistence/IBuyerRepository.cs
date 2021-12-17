using Contoso.Product.Domain.Aggregates.Buyers;

namespace Contoso.Product.Infrastructure.Persistence
{
    public interface IBuyerRepository : IRepository<Buyer>, IBuyerQuery
    {
        Buyer Add(Buyer buyer);

        Buyer Update(Buyer buyer);
    }
}
