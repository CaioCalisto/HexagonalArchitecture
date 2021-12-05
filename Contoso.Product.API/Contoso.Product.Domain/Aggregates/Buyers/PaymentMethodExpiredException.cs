namespace Contoso.Product.Domain.Aggregates.Buyers
{
    public class PaymentMethodExpiredException : Exception
    {
        public PaymentMethodExpiredException()
        { }

        public PaymentMethodExpiredException(string message)
            : base(message)
        { }

        public PaymentMethodExpiredException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
