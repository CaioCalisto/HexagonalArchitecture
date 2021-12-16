using Contoso.Product.Domain.SeedWork;

namespace Contoso.Product.Infrastructure.Persistence
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
