namespace Contoso.Product.UseCases.Buyer.Outputs
{
    public interface IAddPaymentOutput
    {
        Task ReturnDataToViewModel(Buyer buyer);
    }
}
