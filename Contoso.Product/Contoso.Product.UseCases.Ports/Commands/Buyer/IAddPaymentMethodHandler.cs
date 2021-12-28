using Contoso.Product.UseCases.Commands.Buyer.Inputs;

namespace Contoso.Product.UseCases.Commands.Buyer
{
    public interface IAddPaymentMethodHandler
    {
        ValueTask<Outputs.Buyer> AddPaymentMethod(AddPaymentMethod addPaymentMethod);
    }
}
