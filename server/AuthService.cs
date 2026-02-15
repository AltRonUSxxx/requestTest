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
                    return "SUCCESS";
                }
                return "WRONG_PASSWORD";
            }
        }
    }
}
