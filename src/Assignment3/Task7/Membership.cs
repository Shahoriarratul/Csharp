using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Membership
    {
        public const string usernameError = "Username must be provided";
        public const string emailError = "Email must be provided";
        public const string passwordError = "Password must be provided";
        public static string Validate(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return usernameError;
            if (string.IsNullOrWhiteSpace(email))
                return emailError;
            if (string.IsNullOrWhiteSpace(password))
                return passwordError;

            return string.Empty;
        }
    }
}
