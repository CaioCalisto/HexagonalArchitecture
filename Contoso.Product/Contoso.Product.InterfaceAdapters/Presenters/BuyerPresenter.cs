using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.InterfaceAdapters.Presenters
{
    public class BuyerPresenter : AbstractionAddPaymentOutput
    {
        public Task ReturnDataToViewModel(Buyer buyer)
        {
            this.ReturnDataToViewModel(buyer);

            return Task.CompletedTask;
        }
    }
}
