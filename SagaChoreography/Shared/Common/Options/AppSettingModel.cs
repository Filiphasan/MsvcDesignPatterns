namespace Shared.Common.Options;

public class AppSettingModel
{
    public const string SectionName = "Settings";

    public required string PgsqlConnectionString { get; set; }
    public required string RabbitMqConnectionString { get; set; }
}