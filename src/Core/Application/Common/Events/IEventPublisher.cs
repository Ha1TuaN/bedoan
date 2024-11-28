using TD.KCN.WebApi.Shared.Events;

namespace TD.KCN.WebApi.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}