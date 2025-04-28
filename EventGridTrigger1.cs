using System;
using Azure.Messaging.EventGrid;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class EventGridTrigger1
    {
        private readonly ILogger<EventGridTrigger1> _logger;

        public EventGridTrigger1(ILogger<EventGridTrigger1> logger)
        {
            _logger = logger;
        }

        [Function(nameof(EventGridTrigger1))]
        public void Run([EventGridTrigger] EventGridEvent eventGridEvent)
        {
            _logger.LogInformation("Event type: {eventType}, Subject: {subject}, Data: {data}", 
                eventGridEvent.EventType, eventGridEvent.Subject, eventGridEvent.Data.ToString());
        }
    }
}
