using CleanArch.Domain.MongoDB.Collections.User;
using MongoDB.Driver;

namespace CleanArch.Infrastructure.Persistence;

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