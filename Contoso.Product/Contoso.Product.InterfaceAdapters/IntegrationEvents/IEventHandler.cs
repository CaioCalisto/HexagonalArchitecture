namespace Contoso.Product.InterfaceAdapters.IntegrationEvents
{
    public interface IEventHandler<T> where T : IntegrationEvent
    {
        Task Handle(IntegrationEvent @event);
    }
}
