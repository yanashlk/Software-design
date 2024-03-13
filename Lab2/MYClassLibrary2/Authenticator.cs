using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYClassLibrary2
{
    public sealed class Authenticator
    {
        private static readonly Lazy<Authenticator> lazyInstance =
        new Lazy<Authenticator>(() => new Authenticator());

        private Authenticator() { }

        public static Authenticator Instance => lazyInstance.Value;

        public bool Authenticate(string username, string password)
        {
            // проста логіка аутентифікації
            if (username == "admin" && password == "admin")
            {
                Console.WriteLine($"Користувач {username} успішно аутентифікований.");
                return true;
            }
            else
            {
                Console.WriteLine($"Невдача аутентифікації для користувача {username}.");
                return false;
            }
        }
    }
}
