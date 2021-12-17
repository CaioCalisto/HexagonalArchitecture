namespace Contoso.Product.Infrastructure.Messaging.Events
{
    public class PaymentMethodAdded : IntegrationEvent
    {
        public PaymentMethodAdded(
            int buyerGuid, 
            int cardTypeId, 
            string cardNumber,
            string securityNumber,
            DateTime expiration)
        {
            BuyerGuid = buyerGuid;
            CardTypeId = cardTypeId;
            CardNumber = cardNumber;
            SecurityNumber = securityNumber;
            Expiration = expiration;
        }

        public int BuyerGuid { get; }

        public int CardTypeId { get; }

        public string CardNumber { get; }

        public string SecurityNumber { get; }

        public DateTime Expiration { get; }
    }
}
