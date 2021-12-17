using Contoso.Product.Infrastructure.Messaging.Events;

namespace Contoso.Product.Infrastructure.Messaging
{
    public interface IMessageBroker
    {
        void DispatchEvent(string topic, string queue, IntegrationEvent integrationEvent);
    }
}
