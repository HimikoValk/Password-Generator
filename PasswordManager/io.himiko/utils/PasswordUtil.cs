using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager.io.himiko.utils
{
    internal class PasswordUtil
    {
        public static PasswordUtil INSTANCE = new PasswordUtil();
        private static string password { get; set; }
        private static Random random = new Random();

        public string createPassword(int lenght, string passwordForm)
        {
            this.password = $"{passwordForm}{randomString(lenght)}manager";
            return this.password; 
        }

        public string randomString(int length)
        {
            return new string((from s in Enumerable.Repeat<string>("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
                               select s[random.Next(s.Length)]).ToArray<char>());
        }
    }
}
