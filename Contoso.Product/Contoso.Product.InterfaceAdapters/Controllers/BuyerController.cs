using Contoso.Product.UseCases.Buyer;
using Contoso.Product.UseCases.Buyer.Inputs;
using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.InterfaceAdapters.Controllers
{
    public class BuyerController : IAddPaymentInput
    {
        private readonly IAddPaymentMethodUseCase addPaymentMethodUseCase;

        public BuyerController(IAddPaymentMethodUseCase addPaymentMethodUseCase)
        {
            this.addPaymentMethodUseCase = addPaymentMethodUseCase;
        }

        public void AddPaymentMethod(AddPaymentMethod addPaymentMethod)
        {
            addPaymentMethodUseCase.AddPaymentMethod(addPaymentMethod);
        }
    }
}
