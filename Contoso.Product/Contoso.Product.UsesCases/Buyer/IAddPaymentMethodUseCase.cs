using Contoso.Product.UseCases.Buyer.Inputs;
using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.UseCases.Buyer
{
    public interface IAddPaymentMethodUseCase
    {
        void SetOutput(AbstractionAddPaymentOutput output);

        void AddPaymentMethod(AddPaymentMethod addPaymentMethod);
    }
}