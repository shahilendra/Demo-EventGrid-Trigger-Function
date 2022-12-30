namespace Demo.EventGrid.Trigger.Services.Abstraction
{
    public interface IDataService
    {
        Task ProcessData(string data);
    }
}