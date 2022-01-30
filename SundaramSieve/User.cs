using System;
using System.Text;
using System.Security.Cryptography;

namespace SundaramSieve
{
    class User
    {
        private string key = "sundaram";
        private string salt = "sieve";
        private Database database;

        public User()
        {
            database = new Database();
        }

        private string getHash(string line)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(key + line));

            return Convert.ToBase64String(hash);
        }

        public bool Valid(string username, string password)
        {
            password = getHash(password);

            return database.Valid(username, password);
        }

        public bool Exists(string username)
        {
            return database.Exists(username);
        }

        public bool Add(string username, string password)
        {
            password = getHash(password);

            return database.Add(username, password);
        }
    }
}
