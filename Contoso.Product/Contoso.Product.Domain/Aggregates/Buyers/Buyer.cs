using Contoso.Product.Domain.SeedWork;

namespace Contoso.Product.Domain.Aggregates.Buyers
{
    public class Buyer : Entity, IAggregateRoot
    {
        private List<PaymentMethod> paymentMethods;

        public string IdentityGuid { get; private set; }

        public string Name { get; private set; }

        public IEnumerable<PaymentMethod> PaymentMethods => paymentMethods.AsReadOnly();

        public PaymentMethod VerifyOrAddPaymentMethod(
            int cardTypeId, 
            string alias, 
            string cardNumber,
            string securityNumber,
            string cardHolderName,
            DateTime expiration,
            int orderId)
        {
            var existingPayment = paymentMethods
                .SingleOrDefault(p => p.IsEqualTo(cardTypeId, cardNumber, expiration));

            if (existingPayment != null)
                return existingPayment;            

            var payment = new PaymentMethod(cardTypeId, alias, cardNumber, securityNumber, cardHolderName, expiration);

            paymentMethods.Add(payment);

            return payment;
        }
    }
}
