namespace CleanArch.Application.Model.SiteSettings;

public class DatabaseSetting
{
    public SqlServerSetting SqlServer { get; set; } = null!;
    public MongoDbSetting MongoDb { get; set; } = null!;
}

public class SqlServerSetting
{
    public string ConnectionString { get; set; } = string.Empty;
}

public class MongoDbSetting
{
    public string ConnectionString { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;
}
