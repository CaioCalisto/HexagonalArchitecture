namespace Contoso.Product.InterfaceAdapters.Buyer.Inputs
{
    public interface IAddPaymentInput
    {
        ValueTask<Outputs.Buyer> AddPaymentMethod(AddPaymentMethod addPaymentMethod);
    }
}
