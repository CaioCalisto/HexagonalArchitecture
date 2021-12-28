using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.UseCases.Buyer.Inputs
{
    public interface IAddPaymentInput
    {
        void SetOutput(AbstractionAddPaymentOutput output);

        void AddPaymentMethod(AddPaymentMethod addPaymentMethod);
    }
}
