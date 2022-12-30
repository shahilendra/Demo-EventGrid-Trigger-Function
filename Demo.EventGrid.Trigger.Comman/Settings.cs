using Demo.EventGrid.Trigger.Comman.Abstraction;

namespace Demo.EventGrid.Trigger.Comman
{
    public class Settings : ISettings
    {
        public Settings()
        {
            IsEnableLog = Convert.ToBoolean(Environment.GetEnvironmentVariable("IsEnableLog", EnvironmentVariableTarget.Process));

        }
        public bool IsEnableLog { get; set; }
    }
}
