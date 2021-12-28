using Contoso.Product.Infrastructure.Persistence;
using Contoso.Product.InterfaceAdapters.IntegrationEvents;

namespace Contoso.Product.UseCases.IntegrationEvents
{
    public class BuyerCardExpiredHandler : IEventHandler<BuyerCardExpired>
    {
        private readonly IBuyerRepository buyerRepository;

        public BuyerCardExpiredHandler(IBuyerRepository buyerRepository)
        {
            this.buyerRepository = buyerRepository;
        }

        public Task Handle(IntegrationEvent @event)
        {
            throw new NotImplementedException();
        }
    }
}
