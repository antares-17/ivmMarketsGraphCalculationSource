﻿using ivmMarkets.GraphCalculation.BuildingBlocks.EventBus.Events;
using System.Threading.Tasks;

namespace ivmMarkets.GraphCalculation.BuildingBlocks.EventBus.Abstractions
{
    public interface IIntegrationEventHandler<in TIntegrationEvent> : IIntegrationEventHandler
        where TIntegrationEvent : IntegrationEvent
    {
        Task Handle(TIntegrationEvent @event);
    }

    public interface IIntegrationEventHandler
    {
    }
}
