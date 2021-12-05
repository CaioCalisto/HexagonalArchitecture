using Contoso.Product.Domain.SeedWork;

namespace Contoso.Product.Infrastructure.Ports.Persistence
{
    public interface IRepository<T> where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
