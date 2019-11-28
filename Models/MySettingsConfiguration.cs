namespace FSL.AppSettingsAspNetCore.Models
{
    public sealed class MySettingsConfiguration
    {
        public bool Log { get; set; }
        public string ConnectionStringId { get; set; }
        public Parameters Parameters { get; set; }
    }
}
