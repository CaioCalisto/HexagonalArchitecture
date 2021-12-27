namespace Contoso.Product.UseCases.Commands.Buyer
{
    public interface IAddPaymentMethodHandler
    {
        Task AddPaymentMethod(AddPaymentMethod addPaymentMethod);
    }
}
