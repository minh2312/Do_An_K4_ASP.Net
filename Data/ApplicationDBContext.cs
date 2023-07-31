
using DoAN_k4.Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DoAN_k4.Data
{
    public class ApplicationDBContext
    {
        IConfiguration Configuration;

        public ApplicationDBContext(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
        public IMongoDatabase Connection
        {
            get
            {
                var client = new MongoClient(Configuration.GetConnectionString("ConnectionDB"));
                var database = client.GetDatabase(Configuration.GetConnectionString("DatabaseName"));
                return database;
            }
        }

        public IMongoCollection<User> users => Connection.GetCollection<User>("users");
        public IMongoCollection<Posts> posts => Connection.GetCollection<Posts>("posts");
    }
}

