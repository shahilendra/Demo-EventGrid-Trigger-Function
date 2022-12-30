using Demo.EventGrid.Trigger.Services.Abstraction;
using Microsoft.Extensions.Logging;

namespace Demo.EventGrid.Trigger.Services
{
    public class DataService : IDataService
    {
        private readonly ILogger<DataService> _logger;

        public DataService(ILogger<DataService> logger)
        {
            _logger = logger?? throw new ArgumentNullException(nameof(logger)); ;
        }
        public async Task ProcessData(string data)
        {
            try
            {
                _logger.LogInformation($"{nameof(DataService)}.{nameof(ProcessData)} called!");
                _logger.LogInformation(data);
                await Task.FromResult("Event has been Capture");
                _logger.LogInformation($"{nameof(DataService)}.{nameof(ProcessData)} Commpleted!");
            }
            catch (Exception ex)
            {
                _logger.LogError($"{nameof(DataService)}.{nameof(ProcessData)} getting error Message: {ex.Message}", ex);
                throw;
            }
        }
    }
}