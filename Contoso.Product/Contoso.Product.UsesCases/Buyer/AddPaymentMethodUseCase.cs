using Contoso.Product.Infrastructure.Messaging;
using Contoso.Product.Infrastructure.Persistence;
using Contoso.Product.UseCases.Buyer.Inputs;
using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.UseCases.Buyer
{
    public class AddPaymentMethodUseCase
    {
        private readonly IBuyerRepository buyerRepository;
        private readonly IMessageBroker messageBroker;
        private readonly IAddPaymentOutput addPaymentOutput;

        public AddPaymentMethodUseCase(IBuyerRepository buyerRepository, IMessageBroker messageBroker, IAddPaymentOutput addPaymentOutput)
        {
            this.buyerRepository = buyerRepository;
            this.messageBroker = messageBroker;
            this.addPaymentOutput = addPaymentOutput;
        }

        public void AddPaymentMethod(AddPaymentMethod addPaymentMethod)
        {
            // call Domain
            // call Database
            this.addPaymentOutput.ReturnDataToViewModel(new Outputs.Buyer(0, string.Empty, 0));
        }
    }
}
