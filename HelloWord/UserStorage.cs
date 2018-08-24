using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace HelloWord
{
    public class UserStorage
    {
        private IMongoCollection<User> collection;
        
        public UserStorage(string mongoUrl)
        {
            var client = new MongoClient(mongoUrl);
            var db = client.GetDatabase("test");
            
            if (db.GetCollection<User>("Users") == null)
            {
                db.CreateCollection("Users");
            }

            collection = db.GetCollection<User>("Users");
        }

        public async Task<List<User>> CreateUserAndGetAll(string login, string password)
        {
            await collection.InsertOneAsync(new User(login, password));
            return await collection.Find(x => true).ToListAsync();
        }
    }
}