using Contoso.Product.Domain.Aggregates.Buyers;
using Contoso.Product.Infrastructure.Ports.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Product.Infrastructure.Persistence.SqlServer
{
    public class ProductContext : DbContext, IUnitOfWork
    {
        public const string DEFAULT_SCHEMA = "productName";

        public DbSet<Buyer> Buyer { get; set; }

        public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
