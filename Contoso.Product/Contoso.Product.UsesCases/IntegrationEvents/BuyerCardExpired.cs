namespace Contoso.Product.UseCases.IntegrationEvents
{
    public class BuyerCardExpired : IntegrationEvent
    {
        public Guid BuyerId { get; set; }

        public string CardNumber { get; set; }
    }
}
