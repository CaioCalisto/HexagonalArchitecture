namespace Contoso.Product.UseCases.Commands.Buyer.Inputs
{
    public class AddPaymentMethod
    {
        public AddPaymentMethod(
            int buyerGuid, 
            int cardTypeId,
            string alias,
            string cardNumber,
            string securityNumber,
            string cardHolderName,
            DateTime expiration,
            int orderId)
        {
            BuyerGuid = buyerGuid;
            CardTypeId = cardTypeId;
            Alias = alias;
            CardNumber = cardNumber;
            SecurityNumber = securityNumber;
            CardHolderName = cardHolderName;
            Expiration = expiration;
            OrderId = orderId;
        }

        public int BuyerGuid { get; }

        public int CardTypeId { get; }

        public string Alias { get; }

        public string CardNumber { get; }

        public string SecurityNumber { get; }

        public string CardHolderName { get; }

        public DateTime Expiration { get; }

        public int OrderId { get; }
    }
}
