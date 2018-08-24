
using System;

namespace HelloWord
{   
    class Program
    {
        static void Main()
        {
            RunApp();
            while (true)
            {
                
            }
        }

        private static async void RunApp()
        {
            Console.WriteLine("Enter login");
            var login = Console.ReadLine();
            
            Console.WriteLine("Enter password");
            var password = Console.ReadLine();

            var userStorage = new UserStorage("mongodb://localhost:27017");
            var users = await userStorage.CreateUserAndGetAll(login, password);
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
            RunApp();
        }
    }
}