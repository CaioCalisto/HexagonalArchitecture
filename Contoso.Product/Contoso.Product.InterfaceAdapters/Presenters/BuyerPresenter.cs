using Contoso.Product.UseCases.Buyer.Outputs;

namespace Contoso.Product.InterfaceAdapters.Presenters
{
    public delegate void Notification(Buyer data);

    public class BuyerPresenter<T> : IAddPaymentOutput
    {
        public event Notification OnNotified;

        public Task ReturnDataToViewModel(Buyer buyer)
        {
            if (OnNotified != null)
                OnNotified.Invoke(buyer);

            return Task.CompletedTask;
        }
    }
}
