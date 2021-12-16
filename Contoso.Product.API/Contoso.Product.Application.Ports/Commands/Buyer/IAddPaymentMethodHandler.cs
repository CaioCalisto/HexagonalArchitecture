namespace Contoso.Product.Application.Commands.Buyer
{
    public interface IAddPaymentMethodHandler
    {
        Task AddPaymentMethod(AddPaymentMethod addPaymentMethod);
    }
}
