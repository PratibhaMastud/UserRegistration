using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegex
{
    class UserRegistration
    {
        public static bool regexPassword(string pass)
        {
            string namePattern = "[a-zA-z]{8,}";//Rule:1
            Regex obj = new Regex(namePattern);
            return obj.IsMatch(pass);
        }
    }
}
