using CleanArch.Domain.MongoDB.User;
using MongoDB.Driver;

namespace CleanArch.Infrastructure.Data;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext(string connectionString, string databaseName)
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<AppUser> Users =>
        _database.GetCollection<AppUser>(nameof(Users));
}