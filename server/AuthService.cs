using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace server
{
    internal class AuthService
    {
        public static async Task<string> loginAsync(string username, string password)
        {
            using (var db = new TaskManagerEntities())
            {
                var user = db.Users.FirstOrDefault(x => x.username == username);

                if (user is null)
                {
                    return "NOT FOUND";
                }

                if (passwordHasher.verifyPassword(password, user.hash_password))
                {
                    return "SUCCESS";
                }
                return "WRONG_PASSWORD";
            }
        }

        public static async Task<string> registerAsync(string username, string password, string email)
        {
            using(var db = new TaskManagerEntities())
            {
                var user = db.Users.FirstOrDefault(x => x.username == username);
                if (!(user is null))
                {
                    return "USERNAME ALREDY HAVE";
                }
                var emailCheck = db.Users.FirstOrDefault(x => x.email == email);
                if (!(emailCheck is null))
                {
                    return "EMAIL ALREDY HAVE";
                }
                user = new Users();
                user.username = username;
                user.hash_password = passwordHasher.hashPassword(password);
                user.email = email.ToLower();
                db.Users.Add(user);
                await db.SaveChangesAsync();
                Console.WriteLine("New account");
                return "SUCCESS";
            }
        }

        public static string login(string username, string password)
        {
            using (var db = new TaskManagerEntities())
            {
                var user = db.Users.FirstOrDefault(x => x.username == username);

                if (user is null)
                {
                    return "NOT FOUND";
                }

                if(passwordHasher.verifyPassword(password, user.hash_password))
                {
                    return $"SUCCESS|{user.lvl_security}";
                }
                return "WRONG_PASSWORD";
            }
        }
    }
}
