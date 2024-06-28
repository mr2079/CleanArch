using CleanArch.Domain.MongoDB.Users;
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

    public IMongoCollection<User> Users =>
        _database.GetCollection<User>(nameof(Users));
}