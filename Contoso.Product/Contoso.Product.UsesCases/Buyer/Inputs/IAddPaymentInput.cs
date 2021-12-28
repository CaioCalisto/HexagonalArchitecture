namespace Contoso.Product.UseCases.Buyer.Inputs
{
    public interface IAddPaymentInput
    {
        ValueTask<Outputs.Buyer> AddPaymentMethod(AddPaymentMethod addPaymentMethod);
    }
}
