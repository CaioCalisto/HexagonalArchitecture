namespace Contoso.Product.UseCases.Buyer.Outputs
{
    public delegate void Notification(string msg);

    public abstract class AbstractionAddPaymentOutput
    {
        public event Notification OnNotified;

        internal virtual void ReturnDataToViewModel(Outputs.Buyer buyer)
        {
            this.OnNotified.Invoke("some data");
        }
    }
}
