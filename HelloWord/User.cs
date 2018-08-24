using MongoDB.Bson;

namespace HelloWord
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string Login { get; set; }
        public string Password { get; }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
            this.Id = new ObjectId();
        }

        public override string ToString()
        {
            return $"ObjectId: {Id}, Login: {Login}, Password: {Password}";
        }
    }
}