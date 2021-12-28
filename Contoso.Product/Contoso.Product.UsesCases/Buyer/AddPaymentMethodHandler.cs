using Contoso.Product.Infrastructure.Messaging;
using Contoso.Product.Infrastructure.Persistence;
using Contoso.Product.InterfaceAdapters.Buyer.Inputs;
using Contoso.Product.InterfaceAdapters.Buyer.Outputs;

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

        public ValueTask<InterfaceAdapters.Buyer.Outputs.Buyer> AddPaymentMethod(InterfaceAdapters.Buyer.Inputs.AddPaymentMethod addPaymentMethod)
        {
            throw new NotImplementedException();
        }
    }
}
