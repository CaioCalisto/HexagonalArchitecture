using Contoso.Product.Infrastructure.Messaging;
using Contoso.Product.Infrastructure.Persistence;
using Contoso.Product.UseCases.Buyer.Inputs;
using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.UseCases.Buyer
{
    public class AddPaymentMethodHandler : IAddPaymentInput
    {
        private readonly IBuyerRepository buyerRepository;
        private readonly IMessageBroker messageBroker;
        private readonly IAddPaymentOutput addPaymentOutput;

        public AddPaymentMethodHandler(IBuyerRepository buyerRepository, IMessageBroker messageBroker, IAddPaymentOutput addPaymentOutput)
        {
            this.buyerRepository = buyerRepository;
            this.messageBroker = messageBroker;
            this.addPaymentOutput = addPaymentOutput;
        }

        public ValueTask<Outputs.Buyer> AddPaymentMethod(Inputs.AddPaymentMethod addPaymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
