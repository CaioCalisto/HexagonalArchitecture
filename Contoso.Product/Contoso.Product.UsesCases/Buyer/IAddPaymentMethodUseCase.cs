using Contoso.Product.UseCases.Buyer.Inputs;

namespace Contoso.Product.UseCases.Buyer
{
    public interface IAddPaymentMethodUseCase
    {
        void AddPaymentMethod(AddPaymentMethod addPaymentMethod);
    }
}