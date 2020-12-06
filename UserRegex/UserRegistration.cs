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
            string namePattern = "[A-Z]{1}";//Rule:2
            Regex obj = new Regex(namePattern);
            return obj.IsMatch(pass);
        }
    }
}
