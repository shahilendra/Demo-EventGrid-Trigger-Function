// Default URL for triggering event grid function in the local environment.
// http://localhost:7071/runtime/webhooks/EventGrid?functionName={functionname}
using Azure.Messaging.EventGrid;
using Demo.EventGrid.Trigger.Services.Abstraction;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.EventGrid;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using static Demo.EventGrid.Trigger.Comman.Constants;

namespace Demo.EventGrid.Trigger.Function
{
    public class EventGridTriggerFunction
    {
        private readonly ILogger<EventGridTriggerFunction> _logger;
        private readonly IDataService _dataService;

        public EventGridTriggerFunction(IDataService dataService, ILogger<EventGridTriggerFunction> logger)
        {
            _dataService = dataService ?? throw new ArgumentNullException(nameof(dataService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [FunctionName(FUNCTION_NAME)]
        public async Task Run([EventGridTrigger] EventGridEvent eventGridEvent)
        {

            _logger.LogInformation($"{nameof(EventGridTriggerFunction)}.{nameof(Run)} called!");
            await _dataService.ProcessData(eventGridEvent.Data.ToString());
            _logger.LogInformation($"{nameof(EventGridTriggerFunction)}.{nameof(Run)} Commpleted!");
        }
    }
}
