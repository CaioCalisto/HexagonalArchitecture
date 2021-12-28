namespace Contoso.Product.UseCases.Buyer.Outputs
{
    public class Buyer
    {
        public Buyer(
            int buyerGuid,
            string cardNumber,
            int orderId)
        {
            BuyerGuid = buyerGuid;
            CardNumber = cardNumber;
            OrderId = orderId;
        }

        public int BuyerGuid { get; }
        public string CardNumber { get; }
        public int OrderId { get; }
    }
}
