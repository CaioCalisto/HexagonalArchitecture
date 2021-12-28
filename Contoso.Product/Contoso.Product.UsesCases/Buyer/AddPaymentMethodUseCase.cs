using Contoso.Product.Infrastructure.Messaging;
using Contoso.Product.Infrastructure.Persistence;
using Contoso.Product.UseCases.Buyer.Inputs;
using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.UseCases.Buyer
{
    public class AddPaymentMethodUseCase : IAddPaymentMethodUseCase
    {
        private readonly IBuyerRepository buyerRepository;
        private readonly IMessageBroker messageBroker;
        private AbstractionAddPaymentOutput addPaymentOutput;

        public AddPaymentMethodUseCase(IBuyerRepository buyerRepository, IMessageBroker messageBroker)
        {
            this.buyerRepository = buyerRepository;
            this.messageBroker = messageBroker;
        }

        public void AddPaymentMethod(AddPaymentMethod addPaymentMethod)
        {
            // call Domain
            // call Database
            this.addPaymentOutput.ReturnDataToViewModel(new Outputs.Buyer(0, string.Empty, 0));
        }

        public void SetOutput(AbstractionAddPaymentOutput output)
        {
            this.addPaymentOutput = output;
        }
    }
}
