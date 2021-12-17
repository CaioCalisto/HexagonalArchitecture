namespace Contoso.Product.Application.IntegrationEvents
{
    public class BuyerCardExpired
    {
        public Guid BuyerId { get; set; }

        public string CardNumber { get; set; }
    }
}
