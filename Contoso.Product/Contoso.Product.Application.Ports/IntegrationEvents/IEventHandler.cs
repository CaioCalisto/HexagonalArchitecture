namespace Contoso.Product.Application.IntegrationEvents
{
    public interface IEventHandler<T> where T : IntegrationEvent
    {
        Task Handle(IntegrationEvent @event);
    }
}
