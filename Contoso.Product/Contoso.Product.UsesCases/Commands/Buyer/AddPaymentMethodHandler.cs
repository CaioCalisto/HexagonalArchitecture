using Contoso.Product.Infrastructure.Messaging;
using Contoso.Product.Infrastructure.Persistence;

namespace Contoso.Product.UseCases.Commands.Buyer
{
    public class AddPaymentMethodHandler : IAddPaymentMethodHandler
    {
        private readonly IBuyerRepository buyerRepository;
        private readonly IMessageBroker messageBroker;

        public AddPaymentMethodHandler(IBuyerRepository buyerRepository, IMessageBroker messageBroker)
        {
            this.buyerRepository = buyerRepository;
            this.messageBroker = messageBroker;
        }

        public ValueTask<Outputs.Buyer> AddPaymentMethod(Inputs.AddPaymentMethod addPaymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
