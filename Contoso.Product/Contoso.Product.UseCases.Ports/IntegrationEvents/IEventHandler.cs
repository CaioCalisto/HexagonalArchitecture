namespace Contoso.Product.UseCases.IntegrationEvents
{
    public interface IEventHandler<T> where T : IntegrationEvent
    {
        Task Handle(IntegrationEvent @event);
    }
}
