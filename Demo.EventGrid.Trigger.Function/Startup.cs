using Demo.EventGrid.Trigger.Services;
using Demo.EventGrid.Trigger.Services.Abstraction;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

[assembly: FunctionsStartup(typeof(Demo.EventGrid.Trigger.Function.Startup))]
namespace Demo.EventGrid.Trigger.Function
{
    public class Startup : FunctionsStartup
    {
        public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        {
        }
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddLogging(_builder =>
            {
                _builder.SetMinimumLevel(LogLevel.Information);
                _builder.AddFilter("Demo.EventGrid.Trigger.Function", LogLevel.Information);
                _builder.AddFilter("Demo.EventGrid.Trigger.Services", LogLevel.Information);
            });
            builder.Services.AddSingleton<IDataService, DataService>();
        }
    }
}