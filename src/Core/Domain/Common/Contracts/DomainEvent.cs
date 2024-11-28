using TD.KCN.WebApi.Shared.Events;

namespace TD.KCN.WebApi.Domain.Common.Contracts;

public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.Now;
}