namespace EarthquakeApi.Configuration;

public class EarthquakeDbSettings
{
    public string ConnectionString { get; set; } = null!;

    public string DatabaseName { get; set; } = null!;
}