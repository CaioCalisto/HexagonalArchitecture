using Contoso.Product.Domain.SeedWork;

namespace Contoso.Product.Domain.Aggregates.Buyers
{
    public class PaymentMethod : Entity
    {
        private string alias;
        private string cardNumber;
        private string securityNumber;
        private string cardHolderName;
        private DateTime expiration;
        private int cardTypeId;

        public CardType CardType { get; private set; }

        internal PaymentMethod(int cardTypeId, string alias, string cardNumber, string securityNumber, string cardHolderName, DateTime expiration)
        {
            this.cardNumber = !string.IsNullOrWhiteSpace(cardNumber) ? cardNumber : throw new PaymentMethodExpiredException(nameof(cardNumber));
            this.securityNumber = !string.IsNullOrWhiteSpace(securityNumber) ? securityNumber : throw new PaymentMethodExpiredException(nameof(securityNumber));
            this.cardHolderName = !string.IsNullOrWhiteSpace(cardHolderName) ? cardHolderName : throw new PaymentMethodExpiredException(nameof(cardHolderName));

            if (expiration < DateTime.UtcNow)
            {
                throw new PaymentMethodExpiredException(nameof(expiration));
            }

            this.alias = alias;
            this.expiration = expiration;
            this.cardTypeId = cardTypeId;
        }

        internal bool IsEqualTo(int cardTypeId, string cardNumber, DateTime expiration) => 
            this.cardTypeId == cardTypeId
            && this.cardNumber == cardNumber
            && this.expiration == expiration;        
    }
}
